using FplClientModels;
using System.Text.Json;
using static FplClient.Constants;

namespace FplClient;

public class Client(IHttpClientFactory clientFactory)
{
    public Task<Fixture[]> GetAllFixtures(CancellationToken cancellationToken) 
        => GetData<Fixture[]>("api/fixtures/", cancellationToken);

    public Task<Fixture[]> GetAllFixtures(int gameweek, CancellationToken cancellationToken) 
        => GetData<Fixture[]>($"api/fixtures/?event={gameweek}", cancellationToken);
    
    public Task<GenericDataSet> GetGenericDataSet(CancellationToken cancellationToken)
        => GetData<GenericDataSet>("api/bootstrap-static/", cancellationToken);
    
    public Task<ElementSummary> GetPlayerDetails(long playerId, CancellationToken cancellationToken)
        => GetData<ElementSummary>($"api/element-summary/{playerId}/", cancellationToken);
    
    public Task<FixturePlayerStatsWrapper> GetPlayerStatsForGameWeek(int gameweek, CancellationToken cancellationToken)
        => GetData<FixturePlayerStatsWrapper>($"/api/event/{gameweek}/live", cancellationToken);
    
    public Task<Manager> GetManagerSummary(int managerId, CancellationToken cancellationToken)
        => GetData<Manager>($"api/entry/{managerId}/", cancellationToken);
    
    public Task<ManagerStats> GetManagerHistory(int managerId, CancellationToken cancellationToken)
        => GetData<ManagerStats>($"api/entry/{managerId}/history/", cancellationToken);
    
    public Task<Transfer[]> GetManagerTransfers(int managerId, CancellationToken cancellationToken)
        => GetData<Transfer[]>($"api/entry/{managerId}/transfers/", cancellationToken);
    
    //time to get a token (missing step for username/password)1
    //1. https://account.premierleague.com/as/authorize?client_id=bfcbaf69-aade-4c1b-8f00-c1cb8a193030&redirect_uri=https%3A%2F%2Ffantasy.premierleague.com%2F&response_type=code&scope=openid+profile+email+offline_access&state=e64a6b6557dd40d9b0a09dcd895c5aa4&code_challenge=tsZvC7yVFtKkVsiW50ryJa6zAjlckjzJwLWikyF2mOE&code_challenge_method=S256 *get request
    //2. this will redirect to a example https://fantasy.premierleague.com/?code=0fe0769d-ddca-49b8-955b-6ed2fa32671d&state=e64a6b6557dd40d9b0a09dcd895c5aa4
    //3. pull the code from this request
    //4. POST REQUEST to https://account.premierleague.com/as/token


    private async Task<T> GetData<T>(string url, CancellationToken cancellationToken)
    {
        using var client = clientFactory.CreateClient(FplClientName);
        var response = await client.GetAsync(url ,cancellationToken);
        response.EnsureSuccessStatusCode();
        var responseString = await response.Content.ReadAsStringAsync(cancellationToken);
        var result = JsonSerializer.Deserialize<T>(responseString);
        ArgumentNullException.ThrowIfNull(result);
        return result;
    }
}
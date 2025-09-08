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
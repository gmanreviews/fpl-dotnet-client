using FplClientModels;
using System.Text.Json;

namespace FplClient;

public class Client(IHttpClientFactory clientFactory)
{
    public Task<Fixture[]> GetAllFixtures(CancellationToken cancellationToken) 
        => StreamData<Fixture[]>("api/fixtures/", cancellationToken);

    public Task<Fixture[]> GetAllFixtures(int gameweek, CancellationToken cancellationToken) 
        => StreamData<Fixture[]>($"api/fixtures/?event={gameweek}", cancellationToken);
    
    public Task<GenericDataSet> GetGenericDataSet(CancellationToken cancellationToken)
        => StreamData<GenericDataSet>("api/bootstrap-static/", cancellationToken);

    private async Task<T> StreamData<T>(string url, CancellationToken cancellationToken)
    {
        using var client = ConfigureClient();
        var response = await client.GetAsync(url ,cancellationToken);
        response.EnsureSuccessStatusCode();
        var responseString = await response.Content.ReadAsStringAsync(cancellationToken);
        var result = JsonSerializer.Deserialize<T>(responseString);
        ArgumentNullException.ThrowIfNull(result);
        return result;
    }

    private HttpClient ConfigureClient()
    {
        var client = clientFactory.CreateClient("FplClient");
        client.BaseAddress = new Uri("https://fantasy.premierleague.com/");
        return client;
    }
}
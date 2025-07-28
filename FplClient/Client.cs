using FplClientModels;
using System.Text.Json;

namespace FplClient;

public class Client(IHttpClientFactory clientFactory)
{
    public async Task<Gameweek[]> Gameweeks(CancellationToken cancellationToken)
    {
        using var client = ConfigureClient();
        var response = await client.GetAsync("api/fixtures" ,cancellationToken);
        response.EnsureSuccessStatusCode();
        var responseString = await response.Content.ReadAsStringAsync(cancellationToken);
        return JsonSerializer.Deserialize<Gameweek[]>(responseString) ?? [];
    }

    private HttpClient ConfigureClient()
    {
        var client = clientFactory.CreateClient("FplClient");
        client.BaseAddress = new Uri("https://fantasy.premierleague.com/");
        return client;
    }
}
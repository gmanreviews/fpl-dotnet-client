using FplClientModels;
using System.Text.Json;

namespace FplClient;

public class Client(IHttpClientFactory clientFactory)
{
    public async Task<List<Gameweek>> Gameweeks()
    {
        var client = ConfigureClient();
        var response = await client.GetAsync("api/gameweeks");
        response.EnsureSuccessStatusCode();
        var stringResp = await response.Content.ReadAsStringAsync();
        return Enumerable.Empty<Gameweek>().ToList(); 
        //JsonSerializer.Deserialize<dynamic>(stringResp) ?? Enumerable.Empty<Gameweek>().ToList();
    }

    private HttpClient ConfigureClient()
    {
        var client = clientFactory.CreateClient("FplClient");
        client.BaseAddress = new Uri("https://fantasy.premierleague.com/");
        return client;
    }
}
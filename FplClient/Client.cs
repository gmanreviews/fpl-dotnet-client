using System.Net.Http.Headers;
using System.Text;
using FplClientModels;
using System.Text.Json;
using static System.Text.RegularExpressions.Regex;

namespace FplClient;

public partial class Client(IHttpClientFactory clientFactory)
{
    public async Task<Gameweek[]> Gameweeks(CancellationToken cancellationToken = default)
    {
        using var client = ConfigureClient();
        var response = await client.GetAsync("api/fixtures" ,cancellationToken);
        response.EnsureSuccessStatusCode();
        var responseString = await response.Content.ReadAsStringAsync(cancellationToken);
        var decodedString = DecodeUniCode(responseString).Replace(@"\r\n", string.Empty);
        try
        {
            var o =  JsonSerializer.Deserialize<Gameweek[]>(decodedString);
        } 
        catch (Exception e)
        {
            _ = e.Message;
            //do nothing for now
        }
        return Enumerable.Empty<Gameweek>().ToArray();
        //JsonSerializer.Deserialize<dynamic>(stringResp) ?? Enumerable.Empty<Gameweek>().ToList();
    }

    private HttpClient ConfigureClient()
    {
        var client = clientFactory.CreateClient("FplClient");
        client.BaseAddress = new Uri("https://fantasy.premierleague.com/");
        return client;
    }

    private static string DecodeUniCode(string stringWithUnicodeSymbols)
    {
        var split = MyRegex().Split(stringWithUnicodeSymbols);
        var outString = new StringBuilder();
        foreach (var s in split)
        {
            try
            {
                if (s.Length == 4)
                {
                    var decoded = ((char) Convert.ToUInt16(s, 16)).ToString();
                    outString.Append(decoded);
                }
                else
                {
                    outString.Append(s);
                }
            }
            catch
            {
                outString.Append(s);
            }
        }

        return outString.ToString();
    }

    [System.Text.RegularExpressions.GeneratedRegex(@"\\u([a-fA-F\d]{4})")]
    private static partial System.Text.RegularExpressions.Regex MyRegex();
}
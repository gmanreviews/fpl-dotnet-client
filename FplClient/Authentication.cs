using System.Text.Json;
using static FplClient.Constants;

namespace FplClient;

public class Authentication(IHttpClientFactory clientFactory)
{
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
using Microsoft.Extensions.DependencyInjection;
using static FplClient.Constants;

namespace FplClient;

public static class FplClientExtensions
{
    extension(IServiceCollection services)
    {
        public void AddServices()
        {
            services.AddHttpClient(FplClientName, httpClient =>
            {
                httpClient.BaseAddress = new Uri("https://fantasy.premierleague.com/");
            });
            services.AddScoped<Client>(s => new Client(s.GetRequiredService<IHttpClientFactory>()));
            services.AddScoped<Authentication>();
        }
    }
}
using Microsoft.Extensions.DependencyInjection;

namespace FplClient;

public static class FplClientExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddHttpClient();
        return services;
    }
}
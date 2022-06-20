using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceTemplate._1.Infrastructure.Configuration.Extensions;

internal static class HttpClientServicesExtensions
{
    internal static IServiceCollection AddHttpClientServices(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddHttpClient<IYourClient, YourClient>();

        return services;
    }

}

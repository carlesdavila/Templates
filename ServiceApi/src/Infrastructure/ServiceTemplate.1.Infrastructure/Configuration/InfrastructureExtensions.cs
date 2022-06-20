using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceTemplate._1.Infrastructure.Configuration.Extensions;

namespace ServiceTemplate._1.Infrastructure.Configuration;

public static class InfrastructureExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClientServices(configuration);
        
        //Register your Infrastructure services
    }
}

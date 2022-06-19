using Microsoft.Extensions.DependencyInjection;
using ServiceTemplate._1.Infrastructure.Configuration.Extensions;

namespace ServiceTemplate._1.Infrastructure.Configuration;

public static class InfrastructureExtensions
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddHttpClientServices();
        
        //Register your Infrastructure services
    }
}

using ServiceTemplate._1.Api.Configuration.Extensions;
using ServiceTemplate._1.Application.Configuration;
using ServiceTemplate._1.Infrastructure.Configuration;
using ServiceTemplate._1.Persistence.Configuration;

namespace ServiceTemplate._1.Api.Configuration;

public static class PresentationExtensions
{
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddPresentation();
        services.AddApplication();
        services.AddInfrastructure();
        services.AddPersistence();
    }

    internal static void AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        
        services.AddOpenApi();
    }

}


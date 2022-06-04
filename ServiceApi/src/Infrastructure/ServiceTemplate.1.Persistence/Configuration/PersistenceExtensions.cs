using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceTemplate._1.Application.Interfaces;

namespace ServiceTemplate._1.Persistence.Configuration;

public static class PersistenceExtensions
{
    public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ServiceTemplate__1DbContext>(
            options => options.UseNpgsql(configuration.GetConnectionString("ServiceTemplate.1Connection"),
                x => x.MigrationsAssembly(typeof(ServiceTemplate__1DbContext).Assembly.FullName)));

        services.AddScoped<IServiceTemplate__1DbContext>(provider => provider.GetRequiredService<ServiceTemplate__1DbContext>());
    }
}

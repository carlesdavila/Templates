using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using ServiceTemplate._1.Api.Configuration;
using ServiceTemplate._1.Persistence;
using Microsoft.EntityFrameworkCore;
using Respawn;
using Respawn.Graph;

namespace ServiceTemplate._1.Application.IntegrationTests;

[SetUpFixture]
public class Testing
{
    private static IConfigurationRoot _configuration = null!;
    private static IServiceScopeFactory _scopeFactory = null!;
    private static Checkpoint _checkpoint = null!;

    [OneTimeSetUp]
    public void RunBeforeAnyTests()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .AddEnvironmentVariables();

        _configuration = builder.Build();

        var services = new ServiceCollection();

        services.AddSingleton(Mock.Of<IWebHostEnvironment>(w =>
            w.EnvironmentName == "Development" &&
            w.ApplicationName == "ServiceTemplate.1.Api"));

        services.ConfigureServices();

        _scopeFactory = services.BuildServiceProvider().GetRequiredService<IServiceScopeFactory>();


        _checkpoint = new Checkpoint
        {
            TablesToIgnore = new Table[] { "__EFMigrationsHistory" }
        };

        EnsureDatabase();
    }

    public static async Task AddAsync<TEntity>(TEntity entity) where TEntity : class
    {
        using var scope = _scopeFactory.CreateScope();

        var context = scope.ServiceProvider.GetRequiredService<ServiceTemplate__1DbContext>();

        context.Add(entity);

        await context.SaveChangesAsync();
    }

    private static void EnsureDatabase()
    {
        using var scope = _scopeFactory.CreateScope();

        var context = scope.ServiceProvider.GetRequiredService<ServiceTemplate__1DbContext>();

        context.Database.Migrate();
    }

    public static async Task ResetState()
    {
        await _checkpoint.Reset(_configuration.GetConnectionString("DefaultConnection"));
    }

    //public static async Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request)
    //{
    //    using var scope = _scopeFactory.CreateScope();

    //    var mediator = scope.ServiceProvider.GetRequiredService<ISender>();

    //    return await mediator.Send(request);
    //}

}

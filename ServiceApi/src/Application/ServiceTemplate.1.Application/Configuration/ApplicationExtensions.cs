using System.Reflection;
using ApplicationFramework.Application.Behaviours;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceTemplate._1.Application.Configuration;

public static class ApplicationExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
         services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
    }
}

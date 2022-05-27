using Microsoft.OpenApi.Models;

namespace ServiceTemplate._1.Api.Configuration.Extensions;

public static class SwaggerExtensions
{
    public static void UseCustomSwagger(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

}


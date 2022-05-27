using ServiceTemplate._1.Api.Configuration;
using ServiceTemplate._1.Api.Configuration.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.ConfigureServices();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseCustomSwagger();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

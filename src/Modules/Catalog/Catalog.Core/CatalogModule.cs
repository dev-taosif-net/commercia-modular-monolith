using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog.Core;

public static class CatalogModule
{
    public static IServiceCollection AddCatalogModule(this IServiceCollection services,
        IConfiguration configuration)
    {
        // Add services to the container.

        // Api Endpoint services

        // Application Use Case services       

        // Data - Infrastructure services

        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<CatalogDbContext>(options => options.UseNpgsql(connectionString));

        return services;
    }

    public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder app)
    {
        // Configure the HTTP request pipeline.

        // 1. Use Api Endpoint services

        // 2. Use Application Use Case services

        // 3. Use Data - Infrastructure services  


        return app;
    }
}
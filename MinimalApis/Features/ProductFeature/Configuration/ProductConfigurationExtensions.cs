using MinimalApis.Features.ProductFeature.Repository;
using MinimalApis.Features.ProductFeature.Service;

namespace MinimalApis.Features.ProductFeature.Configuration;

public static class ProductConfigurationExtensions
{
    public static WebApplicationBuilder AddProductConfiguration(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IProductRepository>(
            _ => new ProductRepository()
        );

        builder.Services.AddScoped<IProductService>(
            x => new ProductService(
                x.GetRequiredService<IProductRepository>())
        );

        return builder;
    }
}
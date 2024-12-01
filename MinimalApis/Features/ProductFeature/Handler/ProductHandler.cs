using MinimalApis.Features.ProductFeature.EndpointFilters;
using MinimalApis.Features.ProductFeature.Repository.Models;
using MinimalApis.Features.ProductFeature.Service;

namespace MinimalApis.Features.ProductFeature.Handler;

public static class ProductHandler
{
    private static async Task<IResult> GetAllProducts(IProductService productService)
    {
        var products = await productService.GetAllProductsAsync();
        return Results.Ok(products);
    }

    public static IEndpointRouteBuilder MapProductEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/products", () => GetAllProducts)
            .AddEndpointFilter<ProductsEndpointFilter>()
            .Produces<List<Product>>()
            .Produces(StatusCodes.Status400BadRequest)
            .WithName("GetProducts")
            .WithOpenApi();

        return endpoints;
    }
}
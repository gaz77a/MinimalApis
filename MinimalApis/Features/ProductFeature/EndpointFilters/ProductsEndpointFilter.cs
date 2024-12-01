namespace MinimalApis.Features.ProductFeature.EndpointFilters;

public class ProductsEndpointFilter : IEndpointFilter
{
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next) =>
        true //context.HttpContext.Request.Query.ContainsKey("apiKey")
            ? await next(context) // Proceed to the next filter or endpoint
            : Results.BadRequest("API Key is missing");
}
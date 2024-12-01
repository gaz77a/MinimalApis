namespace MinimalApis.Features.OrderFeature.EndpointFilters;

public class OrdersEndpointFilter : IEndpointFilter
{
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next) =>
        context.HttpContext.Request.Query.ContainsKey("apiKey")
            ? await next(context) // Proceed to the next filter or endpoint
            : Results.BadRequest("API Key is missing");
}
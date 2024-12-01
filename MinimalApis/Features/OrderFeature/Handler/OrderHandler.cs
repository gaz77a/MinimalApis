using MinimalApis.Features.OrderFeature.EndpointFilters;
using MinimalApis.Features.OrderFeature.Repository.Models;
using MinimalApis.Features.OrderFeature.Service;

namespace MinimalApis.Features.OrderFeature.Handler;

public static class OrderHandler
{
    private static async Task<IResult> GetAllOrders(IOrderService orderService)
    {
        var orders = await orderService.GetAllOrdersAsync();
        return Results.Ok(orders);
    }

    public static IEndpointRouteBuilder MapOrderEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/orders", () => GetAllOrders)
            .AddEndpointFilter<OrdersEndpointFilter>()
            .Produces<List<Order>>()
            .Produces(StatusCodes.Status400BadRequest)
            .WithName("GetOrders")
            .WithOpenApi();

        return endpoints;
    }
}
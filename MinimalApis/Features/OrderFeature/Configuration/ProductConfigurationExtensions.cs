using MinimalApis.Features.OrderFeature.Repository;
using MinimalApis.Features.OrderFeature.Service;

namespace MinimalApis.Features.OrderFeature.Configuration;

public static class OrderConfigurationExtensions
{
    public static WebApplicationBuilder AddOrderConfiguration(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IOrderRepository>(
            _ => new OrderRepository()
        );

        builder.Services.AddScoped<IOrderService>(
            x => new OrderService(
                x.GetRequiredService<IOrderRepository>())
        );

        return builder;
    }
}
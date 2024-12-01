using MinimalApis.Features.HealthCheck.Handler;
using MinimalApis.Features.OrderFeature.Handler;
using MinimalApis.Features.ProductFeature.Handler;

namespace MinimalApis.Configuration;

public static class Endpoints
{
    public static WebApplication MapEndpoints(this WebApplication app)
    {
        app
            .MapHealthCheckEndpoint()
            .MapProductEndpoints()
            .MapOrderEndpoints();

        return app;
    }
}
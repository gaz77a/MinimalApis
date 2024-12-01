namespace MinimalApis.Features.HealthCheck.Handler;

public static class HealthCheckHandler
{
    private const string HealthCheck = "I'm Alive";

    private static string GetHealthCheck() => HealthCheck;

    public static IEndpointRouteBuilder MapHealthCheckEndpoint(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/", () => GetHealthCheck)
            .Produces<string>()
            .Produces(StatusCodes.Status400BadRequest)
            .WithName("GetHealthCheck")
            .WithOpenApi();

        return endpoints;
    }
}
namespace MinimalApis.Configuration;

public static class WebApplicationBuilderExtensions
{
    public static bool IsDevelopmentEnvironment(this WebApplicationBuilder builder) => builder.Environment.IsDevelopment();
}
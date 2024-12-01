namespace MinimalApis.Configuration;

public static class UserSecretsExtensions
{
    public static WebApplicationBuilder AddUserSecretsIfNeeded(this WebApplicationBuilder builder)
    {
        if (builder.IsDevelopmentEnvironment())
        {
            builder.Configuration.AddUserSecrets<Program>();
        }

        return builder;
    }
}
namespace MinimalApis.Configuration;

public static class MiddlewareConfigurationExtensions
{
    public static WebApplication UseMiddleware(this WebApplication app)
    {
        app.UseHttpsRedirection();

        if (!app.Environment.IsDevelopment())
        {
            return app;
        }

        app.UseSwagger();
        app.UseSwaggerUI();

        app.MapOpenApi();
        // app.UseRouting();

        return app;
    }
}

public static class CoreConfigurationExtensions
{
    public static WebApplicationBuilder AddCoreConfiguration(this WebApplicationBuilder builder)
    {
        // Add services to the container.
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle // TODO: Should this now be removed? Is it deprecated
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddOpenApi();
        return builder;
    }
}
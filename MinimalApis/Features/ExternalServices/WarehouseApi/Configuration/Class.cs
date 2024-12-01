using System.Diagnostics.CodeAnalysis;
using MinimalApis.Features.ExternalServices.WarehouseApi.HttpClient;

#if DEBUG
using MinimalApis.Features.ExternalServices.WarehouseApi.MockedHttpClient;
#else
using Microsoft.AspNetCore.Authentication;
#endif
namespace MinimalApis.Features.ExternalServices.WarehouseApi.Configuration;

[ExcludeFromCodeCoverage(Justification = "Configuration isn't unit tested")]
public static class WarehouseApiServicesConfiguration
{
    public static IServiceCollection AddWarehouseApi(this IServiceCollection services) =>
        services

#if DEBUG
            .AddSingleton<IHttpClientWrapper>(_ => new MockedHttpClientWrapper())
#else
            .AddHttpClient()
            .AddSingleton<IHttpClientWrapper>(x => new HttpClientWrapper(x.GetRequiredService<System.Net.Http.HttpClient>()))
#endif

            .AddSingleton<IWarehouseApiService, WarehouseApiService>();
}
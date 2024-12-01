using MinimalApis.Features.OrderFeature.Configuration;
using MinimalApis.Features.ProductFeature.Configuration;

namespace MinimalApis.Features.Configuration;

public static class FeaturesConfigurationExtensions
{
    public static WebApplicationBuilder AddFeaturesAddFeatureConfiguration(this WebApplicationBuilder builder)
    {
        builder
            .AddOrderConfiguration()
            .AddProductConfiguration();

        return builder;
    }
}
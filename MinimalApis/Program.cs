using MinimalApis.Configuration;
using MinimalApis.Features.Configuration;

var app = WebApplication
    .CreateBuilder(args)
    .AddCoreConfiguration()
    .AddUserSecretsIfNeeded()
    .AddFeaturesAddFeatureConfiguration()

    .Build()

    .UseMiddleware()
    .MapEndpoints(); 

app.Run();

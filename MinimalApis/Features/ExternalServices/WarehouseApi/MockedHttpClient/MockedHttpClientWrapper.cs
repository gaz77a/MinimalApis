using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;

using MinimalApis.Features.ExternalServices.WarehouseApi.HttpClient;

namespace MinimalApis.Features.ExternalServices.WarehouseApi.MockedHttpClient;

public class MockedHttpClientWrapper : IHttpClientWrapper
{
    public Task<HttpResponseMessage> GetAsync(string requestUri)
    {
        // Mock responses based on the request URI
        var products = new JsonArray
        {
            new JsonObject
            {
                ["Id"] = 1,
                ["Name"] = "Product A",
                ["PriceInAud"] = 19.99m
            },
            new JsonObject
            {
                ["Id"] = 2,
                ["Name"] = "Product B",
                ["PriceInAud"] = 29.99m
            },
            new JsonObject
            {
                ["Id"] = 3,
                ["Name"] = "Product C",
                ["PriceInAud"] = 15.49m
            }
        };

        var orders = new JsonArray
        {
            new JsonObject
            {
                ["Id"] = 10,
                ["Name"] = "Order 1",
                ["OrderProducts"] = new JsonArray
                {
                    new JsonObject
                    {
                        ["Id"] = 100,
                        ["ProductId"] = 1,
                        ["Quantity"] = 5
                    }
                }
            },
            new JsonObject
            {
                ["Id"] = 20,
                ["Name"] = "Order 2",
                ["OrderProducts"] = new JsonArray
                {
                    new JsonObject
                    {
                        ["Id"] = 200,
                        ["ProductId"] = 2,
                        ["Quantity"] = 6
                    }
                }
            },
            new JsonObject
            {
                ["Id"] = 30,
                ["Name"] = "Order 3",
                ["OrderProducts"] = new JsonArray
                {
                    new JsonObject
                    {
                        ["Id"] = 300,
                        ["ProductId"] = 3,
                        ["Quantity"] = 8
                    }
                }
            }
        };

        var responseArray = requestUri switch
        {
            _ when requestUri.EndsWith("/products") => products,
            _ when requestUri.EndsWith("/orders") => orders,
            _ => []
        };

        var json = JsonSerializer.Serialize(responseArray);
        return Task.FromResult(CreateHttpResponseMessage(json));
    }

    public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content) =>
        Task.FromResult(new HttpResponseMessage(HttpStatusCode.NotImplemented));

    private static HttpResponseMessage CreateHttpResponseMessage(string json)
    {
        return new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json")
        };
    }
}
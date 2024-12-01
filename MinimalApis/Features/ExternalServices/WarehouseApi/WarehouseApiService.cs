using MinimalApis.Features.ExternalServices.WarehouseApi.HttpClient;
using MinimalApis.Features.ExternalServices.WarehouseApi.Models;

namespace MinimalApis.Features.ExternalServices.WarehouseApi;

public class WarehouseApiService(IHttpClientWrapper httpClientWrapper): IWarehouseApiService
{
    public async Task<WarehouseProduct> GetProducts()
    {
        var response =  await httpClientWrapper.GetAsync("/products");
        return await response.Content.ReadFromJsonAsync<WarehouseProduct>() ?? throw new InvalidOperationException();
    }

    public async Task<WarehouseOrder> GetOrders()
    {
        var response = await httpClientWrapper.GetAsync("/orders");
        return await response.Content.ReadFromJsonAsync<WarehouseOrder>() ?? throw new InvalidOperationException();
    }
}
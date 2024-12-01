using MinimalApis.Features.ExternalServices.WarehouseApi.Models;

namespace MinimalApis.Features.ExternalServices.WarehouseApi;

public interface IWarehouseApiService
{
    Task<WarehouseProduct> GetProducts();
    Task<WarehouseOrder> GetOrders();
}
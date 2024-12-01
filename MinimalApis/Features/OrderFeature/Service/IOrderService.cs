using MinimalApis.Features.OrderFeature.Repository.Models;

namespace MinimalApis.Features.OrderFeature.Service;

public interface IOrderService
{
    Task<IEnumerable<Order>> GetAllOrdersAsync();
}
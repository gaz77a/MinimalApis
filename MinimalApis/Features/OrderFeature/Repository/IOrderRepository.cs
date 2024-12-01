using MinimalApis.Features.OrderFeature.Repository.Models;

namespace MinimalApis.Features.OrderFeature.Repository;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetAllOrdersAsync();
}
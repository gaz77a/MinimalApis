using MinimalApis.Features.OrderFeature.Repository;
using MinimalApis.Features.OrderFeature.Repository.Models;

namespace MinimalApis.Features.OrderFeature.Service;

public class OrderService(IOrderRepository repository) : IOrderService
{
    public async Task<IEnumerable<Order>> GetAllOrdersAsync() =>
        await repository.GetAllOrdersAsync();
}
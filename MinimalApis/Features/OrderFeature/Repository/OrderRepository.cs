using MinimalApis.Features.OrderFeature.Repository.Models;
using MinimalApis.Features.ProductFeature.Repository.Models;

namespace MinimalApis.Features.OrderFeature.Repository;

public class OrderRepository : IOrderRepository
{
    public async Task<IEnumerable<Order>> GetAllOrdersAsync()
    {
        // Mocked data return
        var products = new List<Product>
        {
            new() { Id = 1, Name = "Laptop", Price = 1200.24m },
            new() { Id = 2, Name = "Smartphone", Price = 800.56m }
        };

        var orders = new List<Order>
        {
            new() { Id = 10, Product = products[0], Quantity = 2 },
            new() { Id = 20, Product = products[1], Quantity = 3 }

        };

        return await Task.FromResult(orders);
    }
}
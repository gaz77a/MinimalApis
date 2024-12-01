using MinimalApis.Features.ProductFeature.Repository.Models;

namespace MinimalApis.Features.ProductFeature.Repository;

public class ProductRepository : IProductRepository
{
    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        // Mocked data return
        var products = new List<Product>
        {
            new() { Id = 1, Name = "Laptop", Price = 1200.24m },
            new() { Id = 2, Name = "Smartphone", Price = 800.56m }

        };

        return await Task.FromResult(products);
    }
}
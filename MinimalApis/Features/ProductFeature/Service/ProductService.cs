using MinimalApis.Features.ProductFeature.Repository;
using MinimalApis.Features.ProductFeature.Repository.Models;

namespace MinimalApis.Features.ProductFeature.Service;

public class ProductService(IProductRepository repository) : IProductService
{
    public async Task<IEnumerable<Product>> GetAllProductsAsync() =>
        await repository.GetAllProductsAsync();
}
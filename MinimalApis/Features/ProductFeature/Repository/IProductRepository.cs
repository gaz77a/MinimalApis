using MinimalApis.Features.ProductFeature.Repository.Models;

namespace MinimalApis.Features.ProductFeature.Repository;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProductsAsync();
}
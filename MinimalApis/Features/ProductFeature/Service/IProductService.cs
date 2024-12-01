using MinimalApis.Features.ProductFeature.Repository.Models;

namespace MinimalApis.Features.ProductFeature.Service;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllProductsAsync();
}
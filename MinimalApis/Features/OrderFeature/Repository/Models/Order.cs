using MinimalApis.Features.ProductFeature.Repository.Models;

namespace MinimalApis.Features.OrderFeature.Repository.Models;

public record Order
{
    public required int Id { get; init; }
    public required Product Product { get; init;  }
    public required int Quantity { get; set; }
}
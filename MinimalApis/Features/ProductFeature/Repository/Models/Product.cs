namespace MinimalApis.Features.ProductFeature.Repository.Models;

public record Product
{
    public required int Id { get; init; }
    public required string Name { get; init; }
    public required decimal Price { get; init; }
}
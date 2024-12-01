using System.Text.Json.Serialization;

namespace MinimalApis.Features.ExternalServices.WarehouseApi.Models;

public record WarehouseProduct
{
    [JsonPropertyName("Id")]
    public required int Id { get; init; }

    [JsonPropertyName("Name")]
    public required string Name { get; init; }

    [JsonPropertyName("PriceInAud")]
    public required decimal Price { get; init; }
}
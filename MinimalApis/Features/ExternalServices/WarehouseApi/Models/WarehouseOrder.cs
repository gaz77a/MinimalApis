using System.Text.Json.Serialization;

namespace MinimalApis.Features.ExternalServices.WarehouseApi.Models;

public record WarehouseOrder
{
    [JsonPropertyName("Id")]
    public required int Id { get; init; }

    [JsonPropertyName("Name")]
    public required string Name { get; init; }

    [JsonPropertyName("Products")]
    public required List<WarehouseOrderProduct> OrderProducts { get; init; }
}
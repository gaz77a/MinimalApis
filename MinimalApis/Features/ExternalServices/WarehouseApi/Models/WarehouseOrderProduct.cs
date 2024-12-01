using System.Text.Json.Serialization;

namespace MinimalApis.Features.ExternalServices.WarehouseApi.Models;

public record WarehouseOrderProduct
{
    [JsonPropertyName("Id")]
    public required int Id { get; init; }

    [JsonPropertyName("ProductId")]
    public required int ProductId { get; init; }

    [JsonPropertyName("Quantity")]
    public required int Quantity { get; init; }
}
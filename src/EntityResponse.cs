using System;
using System.Text.Json.Serialization;

namespace Soenneker.Responses.Entity;

/// <summary>
/// A base response model with ID and timestamps, serialized using System.Text.Json property names.
/// </summary>
public record EntityResponse
{
    [JsonPropertyName("id")]
    public virtual string Id { get; set; } = null!;

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("modifiedAt")]
    public DateTime? ModifiedAt { get; set; }
}
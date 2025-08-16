using System;
using System.Text.Json.Serialization;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Responses.Entity;

/// <summary>
/// A base response model with ID and timestamps, serialized using System.Text.Json property names.
/// </summary>
[PublicOpenApiObject]
public record EntityResponse
{
    [JsonPropertyName("id")]
    public virtual string Id { get; set; } = null!;

    [JsonPropertyName("createdAt")]
    public virtual DateTime CreatedAt { get; set; }

    [JsonPropertyName("modifiedAt")]
    public virtual DateTime? ModifiedAt { get; set; }
}
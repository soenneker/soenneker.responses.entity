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
    /// <summary>
    /// The unique identifier for the entity.
    /// </summary>
    [JsonPropertyName("id")]
    public virtual string Id { get; set; } = null!;

    /// <summary>
    /// The date and time when the entity was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public virtual DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// The date and time when the entity was last modified, if applicable.
    /// </summary>
    [JsonPropertyName("modifiedAt")]
    public virtual DateTimeOffset? ModifiedAt { get; set; }
}

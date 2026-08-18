using System;
using System.Text.Json.Serialization;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Responses.Entity;

/// <summary>
/// Provides the stable identifier and creation or modification timestamps shared by API resource responses.
/// </summary>
[PublicOpenApiObject]
public record EntityResponse
{
    /// <summary>
    /// Stable unique identifier of the resource.
    /// </summary>
    [JsonPropertyName("id")]
    public virtual string Id { get; set; } = null!;

    /// <summary>
    /// UTC timestamp when the resource was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public virtual DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// UTC timestamp when the resource was last modified, or <see langword="null"/> when it has not been updated.
    /// </summary>
    [JsonPropertyName("modifiedAt")]
    public virtual DateTimeOffset? ModifiedAt { get; set; }
}


#nullable enable

namespace Fal
{
    /// <summary>
    /// Asset tag
    /// </summary>
    public sealed partial class ListAssetTagsResponseTag
    {
        /// <summary>
        /// Tag ID<br/>
        /// Example: tag_123
        /// </summary>
        /// <example>tag_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Tag name<br/>
        /// Example: moodboard
        /// </summary>
        /// <example>moodboard</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Tag creation time<br/>
        /// Example: 2026-05-23T20:00:00.000Z
        /// </summary>
        /// <example>2026-05-23T20:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAssetTagsResponseTag" /> class.
        /// </summary>
        /// <param name="id">
        /// Tag ID<br/>
        /// Example: tag_123
        /// </param>
        /// <param name="name">
        /// Tag name<br/>
        /// Example: moodboard
        /// </param>
        /// <param name="createdAt">
        /// Tag creation time<br/>
        /// Example: 2026-05-23T20:00:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAssetTagsResponseTag(
            string id,
            string name,
            string? createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAssetTagsResponseTag" /> class.
        /// </summary>
        public ListAssetTagsResponseTag()
        {
        }

    }
}
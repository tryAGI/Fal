
#nullable enable

namespace Fal
{
    /// <summary>
    /// Asset tag
    /// </summary>
    public sealed partial class ListAssetCollectionAssetsResponseAssetTag
    {
        /// <summary>
        /// Tag ID<br/>
        /// Example: 43ce3411-1a25-4d14-875e-3562d341b090
        /// </summary>
        /// <example>43ce3411-1a25-4d14-875e-3562d341b090</example>
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
        /// Initializes a new instance of the <see cref="ListAssetCollectionAssetsResponseAssetTag" /> class.
        /// </summary>
        /// <param name="id">
        /// Tag ID<br/>
        /// Example: 43ce3411-1a25-4d14-875e-3562d341b090
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
        public ListAssetCollectionAssetsResponseAssetTag(
            string id,
            string name,
            string? createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAssetCollectionAssetsResponseAssetTag" /> class.
        /// </summary>
        public ListAssetCollectionAssetsResponseAssetTag()
        {
        }

    }
}
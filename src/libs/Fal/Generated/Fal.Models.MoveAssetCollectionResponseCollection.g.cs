
#nullable enable

namespace Fal
{
    /// <summary>
    /// Asset collection
    /// </summary>
    public sealed partial class MoveAssetCollectionResponseCollection
    {
        /// <summary>
        /// Collection ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Collection type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.MoveAssetCollectionResponseCollectionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.MoveAssetCollectionResponseCollectionType Type { get; set; }

        /// <summary>
        /// Collection display name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Collection description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Optional collection icon
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// Optional collection color
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Optional cover image URL for the collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
        public string? CoverImageUrl { get; set; }

        /// <summary>
        /// Character @mention identifier for character collections
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_identifier")]
        public string? CharacterIdentifier { get; set; }

        /// <summary>
        /// Parent collection ID for a nested (manual) collection; null when top-level
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_collection_id")]
        public string? ParentCollectionId { get; set; }

        /// <summary>
        /// Whether the collection is favorited
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_favorited")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFavorited { get; set; }

        /// <summary>
        /// Filter DSL backing smart and character collections
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public object? Filters { get; set; }

        /// <summary>
        /// Exact asset count when available; null for smart/character collections
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_count")]
        public double? AssetCount { get; set; }

        /// <summary>
        /// Collection creation time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Collection update time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveAssetCollectionResponseCollection" /> class.
        /// </summary>
        /// <param name="id">
        /// Collection ID
        /// </param>
        /// <param name="type">
        /// Collection type
        /// </param>
        /// <param name="name">
        /// Collection display name
        /// </param>
        /// <param name="isFavorited">
        /// Whether the collection is favorited
        /// </param>
        /// <param name="createdAt">
        /// Collection creation time
        /// </param>
        /// <param name="updatedAt">
        /// Collection update time
        /// </param>
        /// <param name="description">
        /// Collection description
        /// </param>
        /// <param name="icon">
        /// Optional collection icon
        /// </param>
        /// <param name="color">
        /// Optional collection color
        /// </param>
        /// <param name="coverImageUrl">
        /// Optional cover image URL for the collection
        /// </param>
        /// <param name="characterIdentifier">
        /// Character @mention identifier for character collections
        /// </param>
        /// <param name="parentCollectionId">
        /// Parent collection ID for a nested (manual) collection; null when top-level
        /// </param>
        /// <param name="filters">
        /// Filter DSL backing smart and character collections
        /// </param>
        /// <param name="assetCount">
        /// Exact asset count when available; null for smart/character collections
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MoveAssetCollectionResponseCollection(
            string id,
            global::Fal.MoveAssetCollectionResponseCollectionType type,
            string name,
            bool isFavorited,
            string createdAt,
            string updatedAt,
            string? description,
            string? icon,
            string? color,
            string? coverImageUrl,
            string? characterIdentifier,
            string? parentCollectionId,
            object? filters,
            double? assetCount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Icon = icon;
            this.Color = color;
            this.CoverImageUrl = coverImageUrl;
            this.CharacterIdentifier = characterIdentifier;
            this.ParentCollectionId = parentCollectionId;
            this.IsFavorited = isFavorited;
            this.Filters = filters;
            this.AssetCount = assetCount;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveAssetCollectionResponseCollection" /> class.
        /// </summary>
        public MoveAssetCollectionResponseCollection()
        {
        }

    }
}
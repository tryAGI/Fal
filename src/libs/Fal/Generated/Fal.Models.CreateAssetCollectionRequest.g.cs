
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssetCollectionRequest
    {
        /// <summary>
        /// Collection display name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional collection description
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
        /// Optional fal-hosted cover image URL for the collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
        public string? CoverImageUrl { get; set; }

        /// <summary>
        /// Optional parent collection ID to nest this collection under (manual collections only). Omit or null to create a top-level collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_collection_id")]
        public string? ParentCollectionId { get; set; }

        /// <summary>
        /// Assets filter DSL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public object? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetCollectionRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Collection display name
        /// </param>
        /// <param name="description">
        /// Optional collection description
        /// </param>
        /// <param name="icon">
        /// Optional collection icon
        /// </param>
        /// <param name="color">
        /// Optional collection color
        /// </param>
        /// <param name="coverImageUrl">
        /// Optional fal-hosted cover image URL for the collection
        /// </param>
        /// <param name="parentCollectionId">
        /// Optional parent collection ID to nest this collection under (manual collections only). Omit or null to create a top-level collection.
        /// </param>
        /// <param name="filters">
        /// Assets filter DSL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAssetCollectionRequest(
            string name,
            string? description,
            string? icon,
            string? color,
            string? coverImageUrl,
            string? parentCollectionId,
            object? filters)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Icon = icon;
            this.Color = color;
            this.CoverImageUrl = coverImageUrl;
            this.ParentCollectionId = parentCollectionId;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetCollectionRequest" /> class.
        /// </summary>
        public CreateAssetCollectionRequest()
        {
        }

    }
}
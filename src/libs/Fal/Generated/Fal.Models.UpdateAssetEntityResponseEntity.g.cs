
#nullable enable

namespace Fal
{
    /// <summary>
    /// Saved smart entity
    /// </summary>
    public sealed partial class UpdateAssetEntityResponseEntity
    {
        /// <summary>
        /// Smart entity ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Smart entity type<br/>
        /// Example: character
        /// </summary>
        /// <example>character</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.UpdateAssetEntityResponseEntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.UpdateAssetEntityResponseEntityType Type { get; set; }

        /// <summary>
        /// Entity display name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Resolved @mention handle, without the leading @
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Handle { get; set; }

        /// <summary>
        /// Entity visual description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Entity cover image URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
        public string? CoverImageUrl { get; set; }

        /// <summary>
        /// Defining reference image URLs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ReferenceImages { get; set; }

        /// <summary>
        /// Whether the entity is favorited
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_favorited")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFavorited { get; set; }

        /// <summary>
        /// Creation time in UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Last update time in UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetEntityResponseEntity" /> class.
        /// </summary>
        /// <param name="id">
        /// Smart entity ID
        /// </param>
        /// <param name="type">
        /// Smart entity type<br/>
        /// Example: character
        /// </param>
        /// <param name="name">
        /// Entity display name
        /// </param>
        /// <param name="handle">
        /// Resolved @mention handle, without the leading @
        /// </param>
        /// <param name="referenceImages">
        /// Defining reference image URLs
        /// </param>
        /// <param name="isFavorited">
        /// Whether the entity is favorited
        /// </param>
        /// <param name="createdAt">
        /// Creation time in UTC
        /// </param>
        /// <param name="updatedAt">
        /// Last update time in UTC
        /// </param>
        /// <param name="description">
        /// Entity visual description
        /// </param>
        /// <param name="coverImageUrl">
        /// Entity cover image URL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAssetEntityResponseEntity(
            string id,
            global::Fal.UpdateAssetEntityResponseEntityType type,
            string name,
            string handle,
            global::System.Collections.Generic.IList<string> referenceImages,
            bool isFavorited,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            string? coverImageUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Handle = handle ?? throw new global::System.ArgumentNullException(nameof(handle));
            this.Description = description;
            this.CoverImageUrl = coverImageUrl;
            this.ReferenceImages = referenceImages ?? throw new global::System.ArgumentNullException(nameof(referenceImages));
            this.IsFavorited = isFavorited;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetEntityResponseEntity" /> class.
        /// </summary>
        public UpdateAssetEntityResponseEntity()
        {
        }

    }
}
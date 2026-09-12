
#nullable enable

namespace Fal
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAssetEntityRequest
    {
        /// <summary>
        /// Smart entity type<br/>
        /// Example: character
        /// </summary>
        /// <example>character</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.CreateAssetEntityRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.CreateAssetEntityRequestType Type { get; set; }

        /// <summary>
        /// Entity display name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional @mention handle. Defaults from the name; must be unique across all entity types in the account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        public string? Handle { get; set; }

        /// <summary>
        /// Visual description. Required and non-empty for characters; optional for other types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Defining reference images. Use saved asset IDs, request IDs, vector IDs, or fal-hosted image URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ReferenceImages { get; set; }

        /// <summary>
        /// Cover image URL. Must be one of the entity's reference images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
        public string? CoverImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetEntityRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// Smart entity type<br/>
        /// Example: character
        /// </param>
        /// <param name="name">
        /// Entity display name
        /// </param>
        /// <param name="referenceImages">
        /// Defining reference images. Use saved asset IDs, request IDs, vector IDs, or fal-hosted image URLs.
        /// </param>
        /// <param name="handle">
        /// Optional @mention handle. Defaults from the name; must be unique across all entity types in the account.
        /// </param>
        /// <param name="description">
        /// Visual description. Required and non-empty for characters; optional for other types.
        /// </param>
        /// <param name="coverImageUrl">
        /// Cover image URL. Must be one of the entity's reference images.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAssetEntityRequest(
            global::Fal.CreateAssetEntityRequestType type,
            string name,
            global::System.Collections.Generic.IList<string> referenceImages,
            string? handle,
            string? description,
            string? coverImageUrl)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Handle = handle;
            this.Description = description;
            this.ReferenceImages = referenceImages ?? throw new global::System.ArgumentNullException(nameof(referenceImages));
            this.CoverImageUrl = coverImageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetEntityRequest" /> class.
        /// </summary>
        public CreateAssetEntityRequest()
        {
        }

    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssetCharacterRequest
    {
        /// <summary>
        /// Character display name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional @mention identifier for the character
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// Text description used for character semantic matching
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Reference images for the character. Prefer vector IDs or request IDs for existing fal-generated assets. Use fal-hosted image URLs only for standalone images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ReferenceImages { get; set; }

        /// <summary>
        /// Optional fal-hosted cover image URL for the character
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
        public string? CoverImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetCharacterRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Character display name
        /// </param>
        /// <param name="description">
        /// Text description used for character semantic matching
        /// </param>
        /// <param name="referenceImages">
        /// Reference images for the character. Prefer vector IDs or request IDs for existing fal-generated assets. Use fal-hosted image URLs only for standalone images.
        /// </param>
        /// <param name="identifier">
        /// Optional @mention identifier for the character
        /// </param>
        /// <param name="coverImageUrl">
        /// Optional fal-hosted cover image URL for the character
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAssetCharacterRequest(
            string name,
            string description,
            global::System.Collections.Generic.IList<string> referenceImages,
            string? identifier,
            string? coverImageUrl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Identifier = identifier;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ReferenceImages = referenceImages ?? throw new global::System.ArgumentNullException(nameof(referenceImages));
            this.CoverImageUrl = coverImageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetCharacterRequest" /> class.
        /// </summary>
        public CreateAssetCharacterRequest()
        {
        }

    }
}
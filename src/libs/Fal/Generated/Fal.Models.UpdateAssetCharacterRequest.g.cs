
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAssetCharacterRequest
    {
        /// <summary>
        /// Character display name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Text description used for character semantic matching
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Reference images for the character. Prefer vector IDs or request IDs for existing fal-generated assets. Use fal-hosted image URLs only for standalone images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<string>? ReferenceImages { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateAssetCharacterRequest" /> class.
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
        /// <param name="coverImageUrl">
        /// Optional fal-hosted cover image URL for the character
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAssetCharacterRequest(
            string? name,
            string? description,
            global::System.Collections.Generic.IList<string>? referenceImages,
            string? coverImageUrl)
        {
            this.Name = name;
            this.Description = description;
            this.ReferenceImages = referenceImages;
            this.CoverImageUrl = coverImageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetCharacterRequest" /> class.
        /// </summary>
        public UpdateAssetCharacterRequest()
        {
        }

    }
}
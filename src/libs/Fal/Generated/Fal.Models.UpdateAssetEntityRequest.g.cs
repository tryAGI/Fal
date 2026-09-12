
#nullable enable

namespace Fal
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateAssetEntityRequest
    {
        /// <summary>
        /// Entity display name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Replacement @mention handle. Character handles cannot be changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        public string? Handle { get; set; }

        /// <summary>
        /// Replacement visual description; null clears it for non-character entities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Replace the defining references with these saved asset IDs, request IDs, vector IDs, or fal-hosted image URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<string>? ReferenceImages { get; set; }

        /// <summary>
        /// Replacement cover image URL from the entity's reference images; null clears the explicit cover.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
        public string? CoverImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetEntityRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Entity display name
        /// </param>
        /// <param name="handle">
        /// Replacement @mention handle. Character handles cannot be changed.
        /// </param>
        /// <param name="description">
        /// Replacement visual description; null clears it for non-character entities.
        /// </param>
        /// <param name="referenceImages">
        /// Replace the defining references with these saved asset IDs, request IDs, vector IDs, or fal-hosted image URLs.
        /// </param>
        /// <param name="coverImageUrl">
        /// Replacement cover image URL from the entity's reference images; null clears the explicit cover.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAssetEntityRequest(
            string? name,
            string? handle,
            string? description,
            global::System.Collections.Generic.IList<string>? referenceImages,
            string? coverImageUrl)
        {
            this.Name = name;
            this.Handle = handle;
            this.Description = description;
            this.ReferenceImages = referenceImages;
            this.CoverImageUrl = coverImageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetEntityRequest" /> class.
        /// </summary>
        public UpdateAssetEntityRequest()
        {
        }

    }
}
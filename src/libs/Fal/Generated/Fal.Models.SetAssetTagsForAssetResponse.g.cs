
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetAssetTagsForAssetResponse
    {
        /// <summary>
        /// Asset tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.SetAssetTagsForAssetResponseTag> Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetAssetTagsForAssetResponse" /> class.
        /// </summary>
        /// <param name="tags">
        /// Asset tags
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetAssetTagsForAssetResponse(
            global::System.Collections.Generic.IList<global::Fal.SetAssetTagsForAssetResponseTag> tags)
        {
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetAssetTagsForAssetResponse" /> class.
        /// </summary>
        public SetAssetTagsForAssetResponse()
        {
        }

    }
}
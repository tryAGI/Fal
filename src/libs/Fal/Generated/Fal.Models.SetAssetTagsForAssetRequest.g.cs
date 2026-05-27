
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetAssetTagsForAssetRequest
    {
        /// <summary>
        /// Persisted asset ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// Request ID to save as an asset before mutating
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Vector ID to save as an asset before mutating
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_id")]
        public string? VectorId { get; set; }

        /// <summary>
        /// Full replacement set of tag IDs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TagIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetAssetTagsForAssetRequest" /> class.
        /// </summary>
        /// <param name="tagIds">
        /// Full replacement set of tag IDs
        /// </param>
        /// <param name="assetId">
        /// Persisted asset ID
        /// </param>
        /// <param name="requestId">
        /// Request ID to save as an asset before mutating
        /// </param>
        /// <param name="vectorId">
        /// Vector ID to save as an asset before mutating
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetAssetTagsForAssetRequest(
            global::System.Collections.Generic.IList<string> tagIds,
            string? assetId,
            string? requestId,
            string? vectorId)
        {
            this.AssetId = assetId;
            this.RequestId = requestId;
            this.VectorId = vectorId;
            this.TagIds = tagIds ?? throw new global::System.ArgumentNullException(nameof(tagIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetAssetTagsForAssetRequest" /> class.
        /// </summary>
        public SetAssetTagsForAssetRequest()
        {
        }

    }
}
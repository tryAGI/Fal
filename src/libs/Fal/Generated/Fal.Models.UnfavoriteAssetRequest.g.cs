
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnfavoriteAssetRequest
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnfavoriteAssetRequest" /> class.
        /// </summary>
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
        public UnfavoriteAssetRequest(
            string? assetId,
            string? requestId,
            string? vectorId)
        {
            this.AssetId = assetId;
            this.RequestId = requestId;
            this.VectorId = vectorId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnfavoriteAssetRequest" /> class.
        /// </summary>
        public UnfavoriteAssetRequest()
        {
        }

    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FavoriteAssetResponse
    {
        /// <summary>
        /// Asset ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssetId { get; set; }

        /// <summary>
        /// Whether the asset is now favorited
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_favorited")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFavorited { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteAssetResponse" /> class.
        /// </summary>
        /// <param name="assetId">
        /// Asset ID
        /// </param>
        /// <param name="isFavorited">
        /// Whether the asset is now favorited
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FavoriteAssetResponse(
            string assetId,
            bool isFavorited)
        {
            this.AssetId = assetId ?? throw new global::System.ArgumentNullException(nameof(assetId));
            this.IsFavorited = isFavorited;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteAssetResponse" /> class.
        /// </summary>
        public FavoriteAssetResponse()
        {
        }

    }
}
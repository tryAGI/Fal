#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Get asset lineage<br/>
        /// Get the derivation lineage of an asset by asset ID: the inputs it was generated from, the generation requests along the way, and any referenced characters, traversed recursively up to `depth` levels. Deleted or expired ancestors stay in the graph flagged as tombstones; inputs that were never captured appear as external inputs.
        /// </summary>
        /// <param name="assetId">
        /// Asset ID<br/>
        /// Example: d8b6elcregj72v34jr8g
        /// </param>
        /// <param name="depth">
        /// Maximum traversal depth (levels of derivation edges)<br/>
        /// Default Value: 5<br/>
        /// Example: 5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.GetAssetLineageResponse> GetAssetLineageAsync(
            string assetId,
            int? depth = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get asset lineage<br/>
        /// Get the derivation lineage of an asset by asset ID: the inputs it was generated from, the generation requests along the way, and any referenced characters, traversed recursively up to `depth` levels. Deleted or expired ancestors stay in the graph flagged as tombstones; inputs that were never captured appear as external inputs.
        /// </summary>
        /// <param name="assetId">
        /// Asset ID<br/>
        /// Example: d8b6elcregj72v34jr8g
        /// </param>
        /// <param name="depth">
        /// Maximum traversal depth (levels of derivation edges)<br/>
        /// Default Value: 5<br/>
        /// Example: 5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.GetAssetLineageResponse>> GetAssetLineageAsResponseAsync(
            string assetId,
            int? depth = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Get asset<br/>
        /// Get an asset from the authenticated user's fal Assets library by asset ID; a vector ID is also accepted. Returns 404 when the asset has no live catalog record, including one whose deletion has not yet propagated to the search index.
        /// </summary>
        /// <param name="assetId">
        /// Asset ID. A vector ID is also accepted<br/>
        /// Example: d8b6elcregj72v34jr8g
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.GetAssetResponse> GetAssetAsync(
            string assetId,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get asset<br/>
        /// Get an asset from the authenticated user's fal Assets library by asset ID; a vector ID is also accepted. Returns 404 when the asset has no live catalog record, including one whose deletion has not yet propagated to the search index.
        /// </summary>
        /// <param name="assetId">
        /// Asset ID. A vector ID is also accepted<br/>
        /// Example: d8b6elcregj72v34jr8g
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.GetAssetResponse>> GetAssetAsResponseAsync(
            string assetId,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
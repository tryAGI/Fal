#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// List tags for an asset<br/>
        /// List tags for an asset by asset ID; a vector ID is also accepted. Assets without a live catalog record return an empty tag list.
        /// </summary>
        /// <param name="assetId">
        /// Asset ID. A vector ID is also accepted<br/>
        /// Example: d8b6elcregj72v34jr8g
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.ListAssetTagsForAssetResponse> ListAssetTagsForAssetAsync(
            string assetId,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List tags for an asset<br/>
        /// List tags for an asset by asset ID; a vector ID is also accepted. Assets without a live catalog record return an empty tag list.
        /// </summary>
        /// <param name="assetId">
        /// Asset ID. A vector ID is also accepted<br/>
        /// Example: d8b6elcregj72v34jr8g
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.ListAssetTagsForAssetResponse>> ListAssetTagsForAssetAsResponseAsync(
            string assetId,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
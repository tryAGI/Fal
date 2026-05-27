#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Get asset<br/>
        /// Get a persisted asset from the authenticated user's fal Assets library.
        /// </summary>
        /// <param name="assetId">
        /// Asset ID<br/>
        /// Example: ast_01hxyq3m9k6d2r7p8v4n5c1b2a
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
        /// Get a persisted asset from the authenticated user's fal Assets library.
        /// </summary>
        /// <param name="assetId">
        /// Asset ID<br/>
        /// Example: ast_01hxyq3m9k6d2r7p8v4n5c1b2a
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
#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// List asset characters<br/>
        /// List asset characters for the authenticated user's fal Assets library.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of collections to return<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="offset">
        /// Number of collections to skip<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.ListAssetCharactersResponse> ListAssetCharactersAsync(
            int? limit = default,
            int? offset = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List asset characters<br/>
        /// List asset characters for the authenticated user's fal Assets library.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of collections to return<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="offset">
        /// Number of collections to skip<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.ListAssetCharactersResponse>> ListAssetCharactersAsResponseAsync(
            int? limit = default,
            int? offset = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
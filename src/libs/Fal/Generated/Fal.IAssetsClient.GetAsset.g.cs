#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Get asset<br/>
        /// Get an asset document by vector ID from the authenticated user's fal Assets library. The vector may exist only in Turbopuffer; in that case the response returns the Turbopuffer document with empty local state.
        /// </summary>
        /// <param name="vectorId">
        /// Vector ID<br/>
        /// Example: b1a2b4a5-cb89-51dc-a108-6dbfd8e742fc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.GetAssetResponse> GetAssetAsync(
            string vectorId,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get asset<br/>
        /// Get an asset document by vector ID from the authenticated user's fal Assets library. The vector may exist only in Turbopuffer; in that case the response returns the Turbopuffer document with empty local state.
        /// </summary>
        /// <param name="vectorId">
        /// Vector ID<br/>
        /// Example: b1a2b4a5-cb89-51dc-a108-6dbfd8e742fc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.GetAssetResponse>> GetAssetAsResponseAsync(
            string vectorId,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// List tags for an asset<br/>
        /// List tags for an asset by vector ID. Vectors that have not been saved as assets return an empty tag list.
        /// </summary>
        /// <param name="vectorId">
        /// Vector ID<br/>
        /// Example: b1a2b4a5-cb89-51dc-a108-6dbfd8e742fc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.ListAssetTagsForAssetResponse> ListAssetTagsForAssetAsync(
            string vectorId,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List tags for an asset<br/>
        /// List tags for an asset by vector ID. Vectors that have not been saved as assets return an empty tag list.
        /// </summary>
        /// <param name="vectorId">
        /// Vector ID<br/>
        /// Example: b1a2b4a5-cb89-51dc-a108-6dbfd8e742fc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.ListAssetTagsForAssetResponse>> ListAssetTagsForAssetAsResponseAsync(
            string vectorId,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
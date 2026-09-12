#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Get asset entity<br/>
        /// Get a saved entity's type, @mention handle, visual description, and defining reference images. Only entities belonging to the authenticated account are accessible.
        /// </summary>
        /// <param name="entityId">
        /// Smart entity ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.GetAssetEntityResponse> GetAssetEntityAsync(
            string entityId,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get asset entity<br/>
        /// Get a saved entity's type, @mention handle, visual description, and defining reference images. Only entities belonging to the authenticated account are accessible.
        /// </summary>
        /// <param name="entityId">
        /// Smart entity ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.GetAssetEntityResponse>> GetAssetEntityAsResponseAsync(
            string entityId,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
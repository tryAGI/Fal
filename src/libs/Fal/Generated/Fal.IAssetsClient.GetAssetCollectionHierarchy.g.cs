#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Get asset collection hierarchy<br/>
        /// Get the nested subtree rooted at an asset collection, plus its ancestor collections ordered from the top level down to its direct parent.
        /// </summary>
        /// <param name="collectionId">
        /// Collection ID<br/>
        /// Example: d8b6elcregj72v34jr8g
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.GetAssetCollectionHierarchyResponse> GetAssetCollectionHierarchyAsync(
            string collectionId,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get asset collection hierarchy<br/>
        /// Get the nested subtree rooted at an asset collection, plus its ancestor collections ordered from the top level down to its direct parent.
        /// </summary>
        /// <param name="collectionId">
        /// Collection ID<br/>
        /// Example: d8b6elcregj72v34jr8g
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.GetAssetCollectionHierarchyResponse>> GetAssetCollectionHierarchyAsResponseAsync(
            string collectionId,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
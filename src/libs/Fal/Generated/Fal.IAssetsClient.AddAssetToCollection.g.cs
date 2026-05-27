#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Add asset to collection<br/>
        /// Add an asset to a manual or character collection. Provide an asset ID, request ID, or vector ID; unresolved references are saved automatically before they are added. For character collections, the asset is added by applying the character tag.
        /// </summary>
        /// <param name="collectionId">
        /// Collection ID<br/>
        /// Example: col_01hxyq3m9k6d2r7p8v4n5c1b2a
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AddAssetToCollectionResponse> AddAssetToCollectionAsync(
            string collectionId,

            global::Fal.AddAssetToCollectionRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add asset to collection<br/>
        /// Add an asset to a manual or character collection. Provide an asset ID, request ID, or vector ID; unresolved references are saved automatically before they are added. For character collections, the asset is added by applying the character tag.
        /// </summary>
        /// <param name="collectionId">
        /// Collection ID<br/>
        /// Example: col_01hxyq3m9k6d2r7p8v4n5c1b2a
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.AddAssetToCollectionResponse>> AddAssetToCollectionAsResponseAsync(
            string collectionId,

            global::Fal.AddAssetToCollectionRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add asset to collection<br/>
        /// Add an asset to a manual or character collection. Provide an asset ID, request ID, or vector ID; unresolved references are saved automatically before they are added. For character collections, the asset is added by applying the character tag.
        /// </summary>
        /// <param name="collectionId">
        /// Collection ID<br/>
        /// Example: col_01hxyq3m9k6d2r7p8v4n5c1b2a
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="assetId">
        /// Persisted asset ID
        /// </param>
        /// <param name="requestId">
        /// Request ID to save as an asset before mutating
        /// </param>
        /// <param name="vectorId">
        /// Vector ID to save as an asset before mutating
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AddAssetToCollectionResponse> AddAssetToCollectionAsync(
            string collectionId,
            string? idempotencyKey = default,
            string? assetId = default,
            string? requestId = default,
            string? vectorId = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Update asset collection<br/>
        /// Update asset collection for the authenticated user's fal Assets library.
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
        global::System.Threading.Tasks.Task<global::Fal.UpdateAssetCollectionResponse> UpdateAssetCollectionAsync(
            string collectionId,

            global::Fal.UpdateAssetCollectionRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update asset collection<br/>
        /// Update asset collection for the authenticated user's fal Assets library.
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
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.UpdateAssetCollectionResponse>> UpdateAssetCollectionAsResponseAsync(
            string collectionId,

            global::Fal.UpdateAssetCollectionRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update asset collection<br/>
        /// Update asset collection for the authenticated user's fal Assets library.
        /// </summary>
        /// <param name="collectionId">
        /// Collection ID<br/>
        /// Example: col_01hxyq3m9k6d2r7p8v4n5c1b2a
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="name">
        /// Collection display name
        /// </param>
        /// <param name="description">
        /// Optional collection description
        /// </param>
        /// <param name="icon">
        /// Optional collection icon
        /// </param>
        /// <param name="color">
        /// Optional collection color
        /// </param>
        /// <param name="coverImageUrl">
        /// Optional fal-hosted cover image URL for the collection
        /// </param>
        /// <param name="filters">
        /// Assets filter DSL
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.UpdateAssetCollectionResponse> UpdateAssetCollectionAsync(
            string collectionId,
            string? idempotencyKey = default,
            string? name = default,
            string? description = default,
            string? icon = default,
            string? color = default,
            string? coverImageUrl = default,
            object? filters = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
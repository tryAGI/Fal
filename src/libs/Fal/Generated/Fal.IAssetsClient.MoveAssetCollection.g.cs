#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Move asset collection<br/>
        /// Move a manual asset collection under another collection, or to the top level. Only manual collections can be moved or act as folders; nesting is limited to 5 levels deep and cannot create a cycle.
        /// </summary>
        /// <param name="collectionId">
        /// Collection ID<br/>
        /// Example: d8b6elcregj72v34jr8g
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.MoveAssetCollectionResponse> MoveAssetCollectionAsync(
            string collectionId,

            global::Fal.MoveAssetCollectionRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move asset collection<br/>
        /// Move a manual asset collection under another collection, or to the top level. Only manual collections can be moved or act as folders; nesting is limited to 5 levels deep and cannot create a cycle.
        /// </summary>
        /// <param name="collectionId">
        /// Collection ID<br/>
        /// Example: d8b6elcregj72v34jr8g
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.MoveAssetCollectionResponse>> MoveAssetCollectionAsResponseAsync(
            string collectionId,

            global::Fal.MoveAssetCollectionRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move asset collection<br/>
        /// Move a manual asset collection under another collection, or to the top level. Only manual collections can be moved or act as folders; nesting is limited to 5 levels deep and cannot create a cycle.
        /// </summary>
        /// <param name="collectionId">
        /// Collection ID<br/>
        /// Example: d8b6elcregj72v34jr8g
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="parentCollectionId">
        /// Parent collection ID to move this collection under, or null to move it to the top level. Must be a manual collection; nesting is limited to 5 levels and cannot create a cycle.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.MoveAssetCollectionResponse> MoveAssetCollectionAsync(
            string collectionId,
            string? idempotencyKey = default,
            string? parentCollectionId = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
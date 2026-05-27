#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Update asset tag<br/>
        /// Update asset tag for the authenticated user's fal Assets library.
        /// </summary>
        /// <param name="tagId">
        /// Tag ID<br/>
        /// Example: tag_01hxyq3m9k6d2r7p8v4n5c1b2a
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.UpdateAssetTagResponse> UpdateAssetTagAsync(
            string tagId,

            global::Fal.UpdateAssetTagRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update asset tag<br/>
        /// Update asset tag for the authenticated user's fal Assets library.
        /// </summary>
        /// <param name="tagId">
        /// Tag ID<br/>
        /// Example: tag_01hxyq3m9k6d2r7p8v4n5c1b2a
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.UpdateAssetTagResponse>> UpdateAssetTagAsResponseAsync(
            string tagId,

            global::Fal.UpdateAssetTagRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update asset tag<br/>
        /// Update asset tag for the authenticated user's fal Assets library.
        /// </summary>
        /// <param name="tagId">
        /// Tag ID<br/>
        /// Example: tag_01hxyq3m9k6d2r7p8v4n5c1b2a
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="name">
        /// Tag name
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.UpdateAssetTagResponse> UpdateAssetTagAsync(
            string tagId,
            string? idempotencyKey = default,
            string? name = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Assign tag to asset<br/>
        /// Assign a tag to an asset. Provide a request ID or vector ID; unresolved references are materialized before tag state is added.
        /// </summary>
        /// <param name="tagId">
        /// Tag ID<br/>
        /// Example: 43ce3411-1a25-4d14-875e-3562d341b090
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AssignAssetTagResponse> AssignAssetTagAsync(
            string tagId,

            global::Fal.AssignAssetTagRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign tag to asset<br/>
        /// Assign a tag to an asset. Provide a request ID or vector ID; unresolved references are materialized before tag state is added.
        /// </summary>
        /// <param name="tagId">
        /// Tag ID<br/>
        /// Example: 43ce3411-1a25-4d14-875e-3562d341b090
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.AssignAssetTagResponse>> AssignAssetTagAsResponseAsync(
            string tagId,

            global::Fal.AssignAssetTagRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign tag to asset<br/>
        /// Assign a tag to an asset. Provide a request ID or vector ID; unresolved references are materialized before tag state is added.
        /// </summary>
        /// <param name="tagId">
        /// Tag ID<br/>
        /// Example: 43ce3411-1a25-4d14-875e-3562d341b090
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
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
        global::System.Threading.Tasks.Task<global::Fal.AssignAssetTagResponse> AssignAssetTagAsync(
            string tagId,
            string? idempotencyKey = default,
            string? requestId = default,
            string? vectorId = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
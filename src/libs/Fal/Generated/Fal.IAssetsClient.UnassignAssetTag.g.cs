#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Unassign tag from asset<br/>
        /// Unassign a tag from an asset by request ID or vector ID.
        /// </summary>
        /// <param name="tagId">
        /// Tag ID<br/>
        /// Example: d9k7q2m4n6p8r1s3t5uv
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task UnassignAssetTagAsync(
            string tagId,

            global::Fal.UnassignAssetTagRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unassign tag from asset<br/>
        /// Unassign a tag from an asset by request ID or vector ID.
        /// </summary>
        /// <param name="tagId">
        /// Tag ID<br/>
        /// Example: d9k7q2m4n6p8r1s3t5uv
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse> UnassignAssetTagAsResponseAsync(
            string tagId,

            global::Fal.UnassignAssetTagRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unassign tag from asset<br/>
        /// Unassign a tag from an asset by request ID or vector ID.
        /// </summary>
        /// <param name="tagId">
        /// Tag ID<br/>
        /// Example: d9k7q2m4n6p8r1s3t5uv
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="assetId">
        /// Asset ID (canonical catalog identity)
        /// </param>
        /// <param name="requestId">
        /// Request ID to save as an asset before mutating
        /// </param>
        /// <param name="vectorId">
        /// Vector ID to save as an asset before mutating. Prefer asset_id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UnassignAssetTagAsync(
            string tagId,
            string? idempotencyKey = default,
            string? assetId = default,
            string? requestId = default,
            string? vectorId = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
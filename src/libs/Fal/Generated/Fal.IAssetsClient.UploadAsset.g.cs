#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Upload asset<br/>
        /// Upload asset for the authenticated user's fal Assets library.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.UploadAssetResponse> UploadAssetAsync(

            global::Fal.UploadAssetRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload asset<br/>
        /// Upload asset for the authenticated user's fal Assets library.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.UploadAssetResponse>> UploadAssetAsResponseAsync(

            global::Fal.UploadAssetRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload asset<br/>
        /// Upload asset for the authenticated user's fal Assets library.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="url">
        /// fal-hosted media URL to ingest into the asset library
        /// </param>
        /// <param name="type">
        /// Media type for the uploaded asset
        /// </param>
        /// <param name="prompt">
        /// Optional caller-provided caption or description to index with the uploaded asset
        /// </param>
        /// <param name="collectionId">
        /// Optional manual collection ID to add the uploaded asset to
        /// </param>
        /// <param name="favorite">
        /// Whether to favorite the uploaded asset immediately<br/>
        /// Default Value: false
        /// </param>
        /// <param name="tagIds">
        /// Tag IDs to assign to the uploaded asset<br/>
        /// Default Value: []
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.UploadAssetResponse> UploadAssetAsync(
            string url,
            global::Fal.UploadAssetRequestType type,
            string? idempotencyKey = default,
            string? prompt = default,
            string? collectionId = default,
            bool? favorite = default,
            global::System.Collections.Generic.IList<string>? tagIds = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
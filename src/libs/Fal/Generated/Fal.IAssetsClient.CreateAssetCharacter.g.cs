#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Create asset character<br/>
        /// Create an asset character for the authenticated user's fal Assets library. Prefer vector IDs or request IDs in reference_images for existing fal-generated assets; use fal-hosted image URLs only for standalone images. Unresolved ID references are materialized before character state is added.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.CreateAssetCharacterResponse> CreateAssetCharacterAsync(

            global::Fal.CreateAssetCharacterRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create asset character<br/>
        /// Create an asset character for the authenticated user's fal Assets library. Prefer vector IDs or request IDs in reference_images for existing fal-generated assets; use fal-hosted image URLs only for standalone images. Unresolved ID references are materialized before character state is added.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.CreateAssetCharacterResponse>> CreateAssetCharacterAsResponseAsync(

            global::Fal.CreateAssetCharacterRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create asset character<br/>
        /// Create an asset character for the authenticated user's fal Assets library. Prefer vector IDs or request IDs in reference_images for existing fal-generated assets; use fal-hosted image URLs only for standalone images. Unresolved ID references are materialized before character state is added.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="name">
        /// Character display name
        /// </param>
        /// <param name="identifier">
        /// Optional @mention identifier for the character
        /// </param>
        /// <param name="description">
        /// Text description used for character semantic matching
        /// </param>
        /// <param name="referenceImages">
        /// Reference images for the character. Prefer vector IDs or request IDs for existing fal-generated assets. Use fal-hosted image URLs only for standalone images.
        /// </param>
        /// <param name="coverImageUrl">
        /// Optional fal-hosted cover image URL for the character
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.CreateAssetCharacterResponse> CreateAssetCharacterAsync(
            string name,
            string description,
            global::System.Collections.Generic.IList<string> referenceImages,
            string? idempotencyKey = default,
            string? identifier = default,
            string? coverImageUrl = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
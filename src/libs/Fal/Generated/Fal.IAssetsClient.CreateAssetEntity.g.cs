#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Create asset entity<br/>
        /// Create a reusable character, prop, environment, style, or scene in fal Assets. The entity is available to @mention in the UI and agent. The handle defaults from the name and must be unique across all entity types in the account. Characters require a description. Reference images accept saved asset IDs, request IDs, vector IDs, or fal-hosted image URLs. Existing character endpoints remain supported.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.CreateAssetEntityResponse> CreateAssetEntityAsync(

            global::Fal.CreateAssetEntityRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create asset entity<br/>
        /// Create a reusable character, prop, environment, style, or scene in fal Assets. The entity is available to @mention in the UI and agent. The handle defaults from the name and must be unique across all entity types in the account. Characters require a description. Reference images accept saved asset IDs, request IDs, vector IDs, or fal-hosted image URLs. Existing character endpoints remain supported.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.CreateAssetEntityResponse>> CreateAssetEntityAsResponseAsync(

            global::Fal.CreateAssetEntityRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create asset entity<br/>
        /// Create a reusable character, prop, environment, style, or scene in fal Assets. The entity is available to @mention in the UI and agent. The handle defaults from the name and must be unique across all entity types in the account. Characters require a description. Reference images accept saved asset IDs, request IDs, vector IDs, or fal-hosted image URLs. Existing character endpoints remain supported.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="type">
        /// Smart entity type<br/>
        /// Example: character
        /// </param>
        /// <param name="name">
        /// Entity display name
        /// </param>
        /// <param name="handle">
        /// Optional @mention handle. Defaults from the name; must be unique across all entity types in the account.
        /// </param>
        /// <param name="description">
        /// Visual description. Required and non-empty for characters; optional for other types.
        /// </param>
        /// <param name="referenceImages">
        /// Defining reference images. Use saved asset IDs, request IDs, vector IDs, or fal-hosted image URLs.
        /// </param>
        /// <param name="coverImageUrl">
        /// Cover image URL. Must be one of the entity's reference images.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.CreateAssetEntityResponse> CreateAssetEntityAsync(
            global::Fal.CreateAssetEntityRequestType type,
            string name,
            global::System.Collections.Generic.IList<string> referenceImages,
            string? idempotencyKey = default,
            string? handle = default,
            string? description = default,
            string? coverImageUrl = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Update asset entity<br/>
        /// Update a saved entity without recreating it. Omitted fields stay unchanged; reference_images replaces the defining reference set. Entity types cannot be changed. Character handles cannot be changed and character descriptions cannot be cleared. Other entity handles must remain unique within the account.
        /// </summary>
        /// <param name="entityId">
        /// Smart entity ID
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.UpdateAssetEntityResponse> UpdateAssetEntityAsync(
            string entityId,

            global::Fal.UpdateAssetEntityRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update asset entity<br/>
        /// Update a saved entity without recreating it. Omitted fields stay unchanged; reference_images replaces the defining reference set. Entity types cannot be changed. Character handles cannot be changed and character descriptions cannot be cleared. Other entity handles must remain unique within the account.
        /// </summary>
        /// <param name="entityId">
        /// Smart entity ID
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.UpdateAssetEntityResponse>> UpdateAssetEntityAsResponseAsync(
            string entityId,

            global::Fal.UpdateAssetEntityRequest request,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update asset entity<br/>
        /// Update a saved entity without recreating it. Omitted fields stay unchanged; reference_images replaces the defining reference set. Entity types cannot be changed. Character handles cannot be changed and character descriptions cannot be cleared. Other entity handles must remain unique within the account.
        /// </summary>
        /// <param name="entityId">
        /// Smart entity ID
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="name">
        /// Entity display name
        /// </param>
        /// <param name="handle">
        /// Replacement @mention handle. Character handles cannot be changed.
        /// </param>
        /// <param name="description">
        /// Replacement visual description; null clears it for non-character entities.
        /// </param>
        /// <param name="referenceImages">
        /// Replace the defining references with these saved asset IDs, request IDs, vector IDs, or fal-hosted image URLs.
        /// </param>
        /// <param name="coverImageUrl">
        /// Replacement cover image URL from the entity's reference images; null clears the explicit cover.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.UpdateAssetEntityResponse> UpdateAssetEntityAsync(
            string entityId,
            string? idempotencyKey = default,
            string? name = default,
            string? handle = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? referenceImages = default,
            string? coverImageUrl = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
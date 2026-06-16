#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Favorite asset character<br/>
        /// Favorite an asset character for the authenticated user's fal Assets library.
        /// </summary>
        /// <param name="characterId">
        /// Character collection ID<br/>
        /// Example: d7tatpsregjaga2cf3d0
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.FavoriteAssetCharacterResponse> FavoriteAssetCharacterAsync(
            string characterId,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Favorite asset character<br/>
        /// Favorite an asset character for the authenticated user's fal Assets library.
        /// </summary>
        /// <param name="characterId">
        /// Character collection ID<br/>
        /// Example: d7tatpsregjaga2cf3d0
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.FavoriteAssetCharacterResponse>> FavoriteAssetCharacterAsResponseAsync(
            string characterId,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
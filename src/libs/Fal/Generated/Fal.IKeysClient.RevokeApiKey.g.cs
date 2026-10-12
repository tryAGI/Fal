#nullable enable

namespace Fal
{
    public partial interface IKeysClient
    {
        /// <summary>
        /// Revoke API Key<br/>
        /// Revokes an API key by its ID, so it can no longer be used. This action is irreversible.<br/>
        /// The key stops working immediately and drops out of `GET /v1/keys`, but the<br/>
        /// record is retained with when it was revoked and by whom.<br/>
        /// **Requirements:**<br/>
        /// - Key must belong to the authenticated user's workspace<br/>
        /// **Key Features:**<br/>
        /// - Permanently revoke API key access while retaining the audit record<br/>
        /// - Idempotent operation (safe to retry)<br/>
        /// - Optional Idempotency-Key header for safe retries<br/>
        /// **Important:**<br/>
        /// - This action cannot be undone<br/>
        /// - Any applications using this key will immediately lose access<br/>
        /// - Returns 204 even if the key doesn't exist or is already revoked<br/>
        /// **Common Use Cases:**<br/>
        /// - Revoke compromised keys<br/>
        /// - Clean up unused keys<br/>
        /// - Implement key rotation (revoke old, create new)<br/>
        /// - Offboard team members<br/>
        /// **Required permissions:** `auth:keys:write`. Key presets that include them: `FULL`. See [key permissions](https://fal.ai/docs/documentation/model-apis/authentication/key-based#permissions).
        /// </summary>
        /// <param name="keyId">
        /// Unique identifier of the API key to revoke<br/>
        /// Example: abc123def456
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task RevokeApiKeyAsync(
            string keyId,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revoke API Key<br/>
        /// Revokes an API key by its ID, so it can no longer be used. This action is irreversible.<br/>
        /// The key stops working immediately and drops out of `GET /v1/keys`, but the<br/>
        /// record is retained with when it was revoked and by whom.<br/>
        /// **Requirements:**<br/>
        /// - Key must belong to the authenticated user's workspace<br/>
        /// **Key Features:**<br/>
        /// - Permanently revoke API key access while retaining the audit record<br/>
        /// - Idempotent operation (safe to retry)<br/>
        /// - Optional Idempotency-Key header for safe retries<br/>
        /// **Important:**<br/>
        /// - This action cannot be undone<br/>
        /// - Any applications using this key will immediately lose access<br/>
        /// - Returns 204 even if the key doesn't exist or is already revoked<br/>
        /// **Common Use Cases:**<br/>
        /// - Revoke compromised keys<br/>
        /// - Clean up unused keys<br/>
        /// - Implement key rotation (revoke old, create new)<br/>
        /// - Offboard team members<br/>
        /// **Required permissions:** `auth:keys:write`. Key presets that include them: `FULL`. See [key permissions](https://fal.ai/docs/documentation/model-apis/authentication/key-based#permissions).
        /// </summary>
        /// <param name="keyId">
        /// Unique identifier of the API key to revoke<br/>
        /// Example: abc123def456
        /// </param>
        /// <param name="idempotencyKey">
        /// Optional idempotency key for safe request retries<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse> RevokeApiKeyAsResponseAsync(
            string keyId,
            string? idempotencyKey = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
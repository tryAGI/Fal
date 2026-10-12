#nullable enable

namespace Fal
{
    public partial interface IKeysClient
    {
        /// <summary>
        /// Create API Key<br/>
        /// Creates a new API key with the specified alias.<br/>
        /// Keys are created with granular permissions. Pass `preset` for a named preset<br/>
        /// or `permissions` to list them explicitly; omit both to get the `API` preset.<br/>
        /// **Important Security Notice:**<br/>
        /// The `key_secret` is only returned once at creation time. Store it securely immediately<br/>
        /// as it cannot be retrieved again. If lost, you must delete the key and create a new one.<br/>
        /// **Key Features:**<br/>
        /// - Create API keys programmatically without UI access<br/>
        /// - Assign meaningful aliases for key identification<br/>
        /// - Scope a key with a named preset or an explicit list of permissions<br/>
        /// - Optionally set an expiry with `expires_at`<br/>
        /// - Keys are immediately active upon creation<br/>
        /// **Common Use Cases:**<br/>
        /// - Programmatic key provisioning for CI/CD pipelines<br/>
        /// - Self-serve key generation for team members<br/>
        /// - Automated key rotation workflows<br/>
        /// - Integration with secret management systems<br/>
        /// **Required permissions:** `auth:keys:write`. Key presets that include them: `FULL`. See [key permissions](https://fal.ai/docs/documentation/model-apis/authentication/key-based#permissions).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.CreateApiKeyResponse> CreateApiKeyAsync(

            global::Fal.CreateApiKeyRequest request,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create API Key<br/>
        /// Creates a new API key with the specified alias.<br/>
        /// Keys are created with granular permissions. Pass `preset` for a named preset<br/>
        /// or `permissions` to list them explicitly; omit both to get the `API` preset.<br/>
        /// **Important Security Notice:**<br/>
        /// The `key_secret` is only returned once at creation time. Store it securely immediately<br/>
        /// as it cannot be retrieved again. If lost, you must delete the key and create a new one.<br/>
        /// **Key Features:**<br/>
        /// - Create API keys programmatically without UI access<br/>
        /// - Assign meaningful aliases for key identification<br/>
        /// - Scope a key with a named preset or an explicit list of permissions<br/>
        /// - Optionally set an expiry with `expires_at`<br/>
        /// - Keys are immediately active upon creation<br/>
        /// **Common Use Cases:**<br/>
        /// - Programmatic key provisioning for CI/CD pipelines<br/>
        /// - Self-serve key generation for team members<br/>
        /// - Automated key rotation workflows<br/>
        /// - Integration with secret management systems<br/>
        /// **Required permissions:** `auth:keys:write`. Key presets that include them: `FULL`. See [key permissions](https://fal.ai/docs/documentation/model-apis/authentication/key-based#permissions).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.CreateApiKeyResponse>> CreateApiKeyAsResponseAsync(

            global::Fal.CreateApiKeyRequest request,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create API Key<br/>
        /// Creates a new API key with the specified alias.<br/>
        /// Keys are created with granular permissions. Pass `preset` for a named preset<br/>
        /// or `permissions` to list them explicitly; omit both to get the `API` preset.<br/>
        /// **Important Security Notice:**<br/>
        /// The `key_secret` is only returned once at creation time. Store it securely immediately<br/>
        /// as it cannot be retrieved again. If lost, you must delete the key and create a new one.<br/>
        /// **Key Features:**<br/>
        /// - Create API keys programmatically without UI access<br/>
        /// - Assign meaningful aliases for key identification<br/>
        /// - Scope a key with a named preset or an explicit list of permissions<br/>
        /// - Optionally set an expiry with `expires_at`<br/>
        /// - Keys are immediately active upon creation<br/>
        /// **Common Use Cases:**<br/>
        /// - Programmatic key provisioning for CI/CD pipelines<br/>
        /// - Self-serve key generation for team members<br/>
        /// - Automated key rotation workflows<br/>
        /// - Integration with secret management systems<br/>
        /// **Required permissions:** `auth:keys:write`. Key presets that include them: `FULL`. See [key permissions](https://fal.ai/docs/documentation/model-apis/authentication/key-based#permissions).
        /// </summary>
        /// <param name="alias">
        /// Required friendly name for the API key<br/>
        /// Example: Production Key
        /// </param>
        /// <param name="description">
        /// Optional description of what the key is for<br/>
        /// Example: CI deploy key for the main environment
        /// </param>
        /// <param name="preset">
        /// Named permission preset to apply. Defaults to "API" when neither preset nor permissions is given. Mutually exclusive with permissions.<br/>
        /// Example: API
        /// </param>
        /// <param name="permissions">
        /// Explicit list of permissions to grant instead of a preset. Mutually exclusive with preset.<br/>
        /// Example: [models:requests:read, models:requests:write]
        /// </param>
        /// <param name="expiresAt">
        /// ISO8601 timestamp after which the key stops working<br/>
        /// Example: 2025-07-15T12:00:00Z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.CreateApiKeyResponse> CreateApiKeyAsync(
            string alias,
            string? description = default,
            global::Fal.CreateApiKeyRequestPreset? preset = default,
            global::System.Collections.Generic.IList<string>? permissions = default,
            global::System.DateTime? expiresAt = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
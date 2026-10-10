#nullable enable

namespace Fal
{
    public partial interface IKeysClient
    {
        /// <summary>
        /// Create API Key<br/>
        /// Creates a new API key on the `API` preset with the specified alias.<br/>
        /// **Important Security Notice:**<br/>
        /// The `key_secret` is only returned once at creation time. Store it securely immediately<br/>
        /// as it cannot be retrieved again. If lost, you must delete the key and create a new one.<br/>
        /// **Key Features:**<br/>
        /// - Create API keys programmatically without UI access<br/>
        /// - Assign meaningful aliases for key identification<br/>
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
        /// Creates a new API key on the `API` preset with the specified alias.<br/>
        /// **Important Security Notice:**<br/>
        /// The `key_secret` is only returned once at creation time. Store it securely immediately<br/>
        /// as it cannot be retrieved again. If lost, you must delete the key and create a new one.<br/>
        /// **Key Features:**<br/>
        /// - Create API keys programmatically without UI access<br/>
        /// - Assign meaningful aliases for key identification<br/>
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
        /// Creates a new API key on the `API` preset with the specified alias.<br/>
        /// **Important Security Notice:**<br/>
        /// The `key_secret` is only returned once at creation time. Store it securely immediately<br/>
        /// as it cannot be retrieved again. If lost, you must delete the key and create a new one.<br/>
        /// **Key Features:**<br/>
        /// - Create API keys programmatically without UI access<br/>
        /// - Assign meaningful aliases for key identification<br/>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.CreateApiKeyResponse> CreateApiKeyAsync(
            string alias,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Fal
{
    public partial interface IKeysClient
    {
        /// <summary>
        /// List API Keys<br/>
        /// Returns the API keys in the authenticated user's workspace that are on the `API` preset<br/>
        /// or the legacy `API` scope. Keys on other presets or custom policies are not listed.<br/>
        /// **Key Features:**<br/>
        /// - View all API keys with their aliases and creation dates<br/>
        /// - Optionally expand to include creator information<br/>
        /// - Paginated results for workspaces with many keys<br/>
        /// **Expansion Options:**<br/>
        /// - `expand=creator_info`: Include creator_nickname and creator_email for each key<br/>
        /// **Common Use Cases:**<br/>
        /// - Audit existing API keys<br/>
        /// - Find keys by alias<br/>
        /// - Monitor key creation activity<br/>
        /// - Build key management interfaces<br/>
        /// **Required permissions:** `auth:keys:read`. Key presets that include them: `BILLING`, `FULL`. See [key permissions](https://fal.ai/docs/documentation/model-apis/authentication/key-based#permissions).
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="expand">
        /// Fields to expand in the response. Available: creator_info (includes creator_nickname and creator_email)<br/>
        /// Example: [creator_info]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.ListApiKeysResponse> ListApiKeysAsync(
            int? limit = default,
            string? cursor = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List API Keys<br/>
        /// Returns the API keys in the authenticated user's workspace that are on the `API` preset<br/>
        /// or the legacy `API` scope. Keys on other presets or custom policies are not listed.<br/>
        /// **Key Features:**<br/>
        /// - View all API keys with their aliases and creation dates<br/>
        /// - Optionally expand to include creator information<br/>
        /// - Paginated results for workspaces with many keys<br/>
        /// **Expansion Options:**<br/>
        /// - `expand=creator_info`: Include creator_nickname and creator_email for each key<br/>
        /// **Common Use Cases:**<br/>
        /// - Audit existing API keys<br/>
        /// - Find keys by alias<br/>
        /// - Monitor key creation activity<br/>
        /// - Build key management interfaces<br/>
        /// **Required permissions:** `auth:keys:read`. Key presets that include them: `BILLING`, `FULL`. See [key permissions](https://fal.ai/docs/documentation/model-apis/authentication/key-based#permissions).
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="expand">
        /// Fields to expand in the response. Available: creator_info (includes creator_nickname and creator_email)<br/>
        /// Example: [creator_info]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.ListApiKeysResponse>> ListApiKeysAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Fal
{
    public partial interface IKeysClient
    {
        /// <summary>
        /// List API Keys<br/>
        /// Returns a list of all API keys belonging to the authenticated user's workspace.<br/>
        /// **Key Features:**<br/>
        /// - View all API keys with their aliases and creation dates<br/>
        /// - See how each key is permissioned via `mode`, `preset` and `permissions`<br/>
        /// - Optionally expand to include creator information<br/>
        /// - Paginated results for workspaces with many keys<br/>
        /// **Key Modes:**<br/>
        /// - `preset`: created from a named permission preset, reported in `preset`<br/>
        /// - `custom`: created with an explicit list of permissions<br/>
        /// - `legacy`: predates granular permissions and carries a coarse scope<br/>
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
        /// Returns a list of all API keys belonging to the authenticated user's workspace.<br/>
        /// **Key Features:**<br/>
        /// - View all API keys with their aliases and creation dates<br/>
        /// - See how each key is permissioned via `mode`, `preset` and `permissions`<br/>
        /// - Optionally expand to include creator information<br/>
        /// - Paginated results for workspaces with many keys<br/>
        /// **Key Modes:**<br/>
        /// - `preset`: created from a named permission preset, reported in `preset`<br/>
        /// - `custom`: created with an explicit list of permissions<br/>
        /// - `legacy`: predates granular permissions and carries a coarse scope<br/>
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
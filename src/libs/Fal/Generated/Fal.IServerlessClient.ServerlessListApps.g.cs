#nullable enable

namespace Fal
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// List Applications<br/>
        /// Lists the serverless applications owned by the authenticated account, with<br/>
        /// the configuration needed for follow-up calls.<br/>
        /// Each application includes its canonical `endpoint_id` ('&lt;owner&gt;/&lt;name&gt;'),<br/>
        /// which is the identifier accepted by the analytics, requests, logs, and<br/>
        /// queue endpoints — use this endpoint to discover identifiers instead of<br/>
        /// asking users to paste them.<br/>
        /// **Authentication:** Required via API key. Only applications owned by the<br/>
        /// authenticated account are returned.
        /// </summary>
        /// <param name="environment">
        /// Environment to list apps from. Defaults to the main environment.<br/>
        /// Example: main
        /// </param>
        /// <param name="search">
        /// Case-insensitive substring match on the app name<br/>
        /// Example: image
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.ServerlessListAppsResponse> ServerlessListAppsAsync(
            string? environment = default,
            string? search = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Applications<br/>
        /// Lists the serverless applications owned by the authenticated account, with<br/>
        /// the configuration needed for follow-up calls.<br/>
        /// Each application includes its canonical `endpoint_id` ('&lt;owner&gt;/&lt;name&gt;'),<br/>
        /// which is the identifier accepted by the analytics, requests, logs, and<br/>
        /// queue endpoints — use this endpoint to discover identifiers instead of<br/>
        /// asking users to paste them.<br/>
        /// **Authentication:** Required via API key. Only applications owned by the<br/>
        /// authenticated account are returned.
        /// </summary>
        /// <param name="environment">
        /// Environment to list apps from. Defaults to the main environment.<br/>
        /// Example: main
        /// </param>
        /// <param name="search">
        /// Case-insensitive substring match on the app name<br/>
        /// Example: image
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.ServerlessListAppsResponse>> ServerlessListAppsAsResponseAsync(
            string? environment = default,
            string? search = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
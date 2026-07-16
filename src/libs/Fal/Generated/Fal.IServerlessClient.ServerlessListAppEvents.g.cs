#nullable enable

namespace Fal
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// Application Events<br/>
        /// Returns the operational event history for an application: deployments,<br/>
        /// configuration changes, and runner lifecycle transitions (started, failed,<br/>
        /// draining, etc.), newest first.<br/>
        /// **Use cases:**<br/>
        /// - Incident correlation: answer "what changed around this time?" — did a<br/>
        ///   deploy, config change, or runner failure coincide with an error spike?<br/>
        /// - Deployment audit: see when revisions went out and who triggered them<br/>
        /// **Time range:** defaults to the last 24 hours when `start`/`end` are<br/>
        /// omitted. Use `category` filters to narrow to specific event types.<br/>
        /// **Authentication:** Required via API key. Only the app owner can query it.
        /// </summary>
        /// <param name="owner">
        /// Username of the app owner<br/>
        /// Example: user_123
        /// </param>
        /// <param name="name">
        /// Application name<br/>
        /// Example: my-app
        /// </param>
        /// <param name="start">
        /// Start date in ISO8601 format (e.g., '2025-01-01T00:00:00Z' or '2025-01-01'). Defaults to 24 hours ago.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </param>
        /// <param name="end">
        /// End date in ISO8601 format, exclusive (e.g., '2025-02-01T00:00:00Z' or '2025-02-01'). Data up to but not including this timestamp is returned. Defaults to current time.<br/>
        /// Example: 2025-02-01T00:00:00Z
        /// </param>
        /// <param name="category">
        /// Filter by event category. Repeat the parameter to include multiple categories: ?category=deployment_started&amp;category=config_changed<br/>
        /// Example: [deployment_started]
        /// </param>
        /// <param name="limit">
        /// Maximum number of events to return per page (1-1000)<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.ServerlessListAppEventsResponse> ServerlessListAppEventsAsync(
            string owner,
            string name,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            global::Fal.AnyOf<global::Fal.ServerlessListAppEventsCategory2?, global::System.Collections.Generic.IList<global::Fal.ServerlessListAppEventsCategoryItem>>? category = default,
            int? limit = default,
            string? cursor = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Application Events<br/>
        /// Returns the operational event history for an application: deployments,<br/>
        /// configuration changes, and runner lifecycle transitions (started, failed,<br/>
        /// draining, etc.), newest first.<br/>
        /// **Use cases:**<br/>
        /// - Incident correlation: answer "what changed around this time?" — did a<br/>
        ///   deploy, config change, or runner failure coincide with an error spike?<br/>
        /// - Deployment audit: see when revisions went out and who triggered them<br/>
        /// **Time range:** defaults to the last 24 hours when `start`/`end` are<br/>
        /// omitted. Use `category` filters to narrow to specific event types.<br/>
        /// **Authentication:** Required via API key. Only the app owner can query it.
        /// </summary>
        /// <param name="owner">
        /// Username of the app owner<br/>
        /// Example: user_123
        /// </param>
        /// <param name="name">
        /// Application name<br/>
        /// Example: my-app
        /// </param>
        /// <param name="start">
        /// Start date in ISO8601 format (e.g., '2025-01-01T00:00:00Z' or '2025-01-01'). Defaults to 24 hours ago.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </param>
        /// <param name="end">
        /// End date in ISO8601 format, exclusive (e.g., '2025-02-01T00:00:00Z' or '2025-02-01'). Data up to but not including this timestamp is returned. Defaults to current time.<br/>
        /// Example: 2025-02-01T00:00:00Z
        /// </param>
        /// <param name="category">
        /// Filter by event category. Repeat the parameter to include multiple categories: ?category=deployment_started&amp;category=config_changed<br/>
        /// Example: [deployment_started]
        /// </param>
        /// <param name="limit">
        /// Maximum number of events to return per page (1-1000)<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.ServerlessListAppEventsResponse>> ServerlessListAppEventsAsResponseAsync(
            string owner,
            string name,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            global::Fal.AnyOf<global::Fal.ServerlessListAppEventsCategory2?, global::System.Collections.Generic.IList<global::Fal.ServerlessListAppEventsCategoryItem>>? category = default,
            int? limit = default,
            string? cursor = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
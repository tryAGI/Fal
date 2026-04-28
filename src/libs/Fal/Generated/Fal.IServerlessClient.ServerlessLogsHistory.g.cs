#nullable enable

namespace Fal
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// Logs history (paginated)<br/>
        /// Returns paginated historical logs that match the provided filters.
        /// </summary>
        /// <param name="limit">
        /// Number of results per page<br/>
        /// Example: 100
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response (timestamp-based). Use as 'until' parameter for next page.<br/>
        /// Example: 2024-11-09T00:00:00.000Z
        /// </param>
        /// <param name="start">
        /// Start date in ISO8601 format (e.g., '2025-01-01T00:00:00Z' or '2025-01-01'). Defaults to 24 hours ago.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </param>
        /// <param name="end">
        /// End date in ISO8601 format, exclusive (e.g., '2025-02-01T00:00:00Z' or '2025-02-01'). Data up to but not including this timestamp is returned. Defaults to current time.<br/>
        /// Example: 2025-02-01T00:00:00Z
        /// </param>
        /// <param name="appId">
        /// Filter by specific app ID(s) in '&lt;owner&gt;/&lt;name&gt;' format (e.g. 'fal-ai/my-app'). Accepts 1-50 app IDs. Supports comma-separated values: ?app_id=fal-ai/foo,fal-ai/bar or array syntax: ?app_id=fal-ai/foo&amp;app_id=fal-ai/bar<br/>
        /// Example: [fal-ai/my-app]
        /// </param>
        /// <param name="revision">
        /// Filter by revision<br/>
        /// Example: rev_abc123
        /// </param>
        /// <param name="runSource">
        /// Filter by run source<br/>
        /// Example: grpc-run
        /// </param>
        /// <param name="traceback">
        /// Include tracebacks<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="search">
        /// Free-text search<br/>
        /// Example: error
        /// </param>
        /// <param name="level">
        /// Minimum log level<br/>
        /// Example: error
        /// </param>
        /// <param name="jobId">
        /// Filter by job id<br/>
        /// Example: job_123
        /// </param>
        /// <param name="requestId">
        /// Filter by request id<br/>
        /// Example: req_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.ServerlessLogsHistoryResponse> ServerlessLogsHistoryAsync(

            global::System.Collections.Generic.IList<global::Fal.ServerlessLogsHistoryRequestItem> request,
            int? limit = default,
            string? cursor = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? appId = default,
            string? revision = default,
            global::Fal.ServerlessLogsHistoryRunSource? runSource = default,
            bool? traceback = default,
            string? search = default,
            string? level = default,
            string? jobId = default,
            string? requestId = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
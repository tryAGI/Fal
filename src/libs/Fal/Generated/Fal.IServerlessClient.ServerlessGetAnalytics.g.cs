#nullable enable

namespace Fal
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// Analytics<br/>
        /// Time-bucketed metrics for your serverless app endpoints, including request counts,<br/>
        /// success/error rates, and latency percentiles across all inbound traffic.<br/>
        /// `prepare_duration` reflects queue/prepare time before execution;<br/>
        /// `duration` is request execution time.<br/>
        /// This endpoint shows all inbound requests to endpoints you own — not just<br/>
        /// your own calls. This is ideal for monitoring your deployed apps, tracking<br/>
        /// SLAs, and exporting data to tools like BigQuery or Grafana. You must own<br/>
        /// all requested endpoints; returns 403 otherwise.<br/>
        /// **Metric Selection:**<br/>
        /// You must specify which metrics to include using the `expand` query<br/>
        /// parameter. Only requested metrics will be populated in the response,<br/>
        /// allowing you to optimize query performance and data transfer.<br/>
        /// **Available Metrics:**<br/>
        /// - `request_count`: Total number of requests in the time bucket<br/>
        /// - `success_count`: Number of successful requests (2xx responses)<br/>
        /// - `user_error_count`: Number of user errors (4xx responses)<br/>
        /// - `error_count`: Number of server errors (5xx responses)<br/>
        /// - `p50_prepare_duration`: 50th percentile queue/prepare time<br/>
        /// - `p75_prepare_duration`: 75th percentile queue/prepare time<br/>
        /// - `p90_prepare_duration`: 90th percentile queue/prepare time<br/>
        /// - `p50_duration`: 50th percentile request execution duration<br/>
        /// - `p75_duration`: 75th percentile request execution duration<br/>
        /// - `p90_duration`: 90th percentile request execution duration<br/>
        /// **Key Features:**<br/>
        /// - See all traffic to your apps across all callers<br/>
        /// - Selective metric inclusion via expand parameter<br/>
        /// - Performance metrics (latency percentiles, duration stats)<br/>
        /// - Reliability metrics (success/error rates, request counts)<br/>
        /// - Time-bucketed data for trend analysis<br/>
        /// - Flexible date range and timeframe options<br/>
        /// **Common Use Cases:**<br/>
        /// - Monitor your serverless app performance and reliability<br/>
        /// - Export analytics to your own observability tools<br/>
        /// - Analyze latency trends across all callers<br/>
        /// - Track error rates and SLA compliance<br/>
        ///     
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="start">
        /// Start date in ISO8601 format (e.g., '2025-01-01T00:00:00Z' or '2025-01-01'). Defaults to 24 hours ago.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </param>
        /// <param name="end">
        /// End date in ISO8601 format, exclusive (e.g., '2025-02-01T00:00:00Z' or '2025-02-01'). Data up to but not including this timestamp is returned. Defaults to current time.<br/>
        /// Example: 2025-02-01T00:00:00Z
        /// </param>
        /// <param name="timezone">
        /// Timezone for date aggregation and boundaries. All timestamps in responses are in UTC, but this controls how dates are bucketed.<br/>
        /// Default Value: UTC<br/>
        /// Example: UTC
        /// </param>
        /// <param name="timeframe">
        /// Aggregation timeframe for timeseries data (auto-detected from date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
        /// Example: day
        /// </param>
        /// <param name="boundToTimeframe">
        /// Whether to adjust start/end dates to align with timeframe boundaries and use exclusive end. Defaults to true. When true, dates are aligned to the start of the timeframe period (e.g., start of day) and end is made exclusive (e.g., start of next day). When false, uses exact dates provided.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="endpointId">
        /// Filter by specific endpoint ID(s). Accepts 1-50 endpoint IDs. Supports comma-separated values: ?endpoint_id=model1,model2 or array syntax: ?endpoint_id=model1&amp;endpoint_id=model2<br/>
        /// Example: [fal-ai/flux/dev]
        /// </param>
        /// <param name="expand">
        /// Data and metrics to include in the response. Use 'time_series' for time-bucketed data, metric names for specific metrics in time series, and 'summary' for aggregate statistics. At least one of 'time_series' or 'summary' and at least one metric are required.<br/>
        /// Default Value: [time_series, request_count]<br/>
        /// Example: [request_count, success_count]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.ServerlessGetAnalyticsResponse> ServerlessGetAnalyticsAsync(
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>> endpointId,
            int? limit = default,
            string? cursor = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            string? timezone = default,
            global::Fal.ServerlessGetAnalyticsTimeframe? timeframe = default,
            global::Fal.ServerlessGetAnalyticsBoundToTimeframe? boundToTimeframe = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
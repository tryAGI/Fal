#nullable enable

namespace Fal
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Analytics<br/>
        /// Time-bucketed metrics per model endpoint, including request counts, success/error<br/>
        /// rates, and latency percentiles. `prepare_duration` reflects queue/prepare<br/>
        /// time before execution; `duration` is request execution time. Use with the<br/>
        /// Queue/Webhooks flow to monitor SLAs.<br/>
        /// **Metric Selection:**<br/>
        /// You must specify which metrics to include using the `expand` query<br/>
        /// parameter. Only requested metrics will be populated in the response,<br/>
        /// allowing you to optimize query performance and data transfer.<br/>
        /// **Available Metrics:**<br/>
        /// The `expand` parameter accepts these values, grouped by category:<br/>
        /// *Volume*<br/>
        /// - `request_count`: Total number of requests in the time bucket<br/>
        /// - `success_count`: Successful requests (2xx responses)<br/>
        /// - `user_error_count`: User errors (4xx responses)<br/>
        /// - `error_count`: Server errors (5xx responses)<br/>
        /// *Error type breakdown*<br/>
        /// - `startup_error_count`: Startup errors (startup timeout, scheduling failure)<br/>
        /// - `connection_error_count`: Connection errors (timeout, disconnected, refused)<br/>
        /// - `timeout_error_count`: Request timeout errors<br/>
        /// - `runtime_error_count`: Runtime errors (internal error, server error)<br/>
        /// *Queue / prepare latency*<br/>
        /// - `p50_prepare_duration`, `p75_prepare_duration`, `p90_prepare_duration`, `p95_prepare_duration`, `p99_prepare_duration`: Time from request submission until execution starts<br/>
        /// *Request execution latency*<br/>
        /// - `p25_duration`, `p50_duration`, `p75_duration`, `p90_duration`, `p95_duration`, `p99_duration`: Time spent processing the request<br/>
        /// *Cold boot*<br/>
        /// - `cold_boot_count`: Requests with cold boot (startup &gt; 1s)<br/>
        /// - `p50_cold_boot_duration`, `p75_cold_boot_duration`, `p90_cold_boot_duration`: Cold boot duration percentiles<br/>
        /// *Billing*<br/>
        /// - `total_billable_duration`: Aggregate billed execution time<br/>
        /// **Key Features:**<br/>
        /// - Selective metric inclusion via expand parameter<br/>
        /// - Performance metrics (latency percentiles, duration stats)<br/>
        /// - Reliability metrics (success/error rates, request counts)<br/>
        /// - Error type breakdown (startup, connection, timeout, runtime)<br/>
        /// - Cold boot metrics (count, latency percentiles)<br/>
        /// - Billing duration tracking<br/>
        /// - Time-bucketed data for trend analysis<br/>
        /// - Single or multi-model analytics<br/>
        /// - Flexible date range and timeframe options<br/>
        /// **Common Use Cases:**<br/>
        /// - Monitor model performance and reliability<br/>
        /// - Generate performance dashboards<br/>
        /// - Analyze latency trends and patterns<br/>
        /// - Track error rates and success metrics<br/>
        /// See [Queue API docs](https://docs.fal.ai/model-apis/model-endpoints/queue) for more details.<br/>
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
        global::System.Threading.Tasks.Task<global::Fal.GetAnalyticsResponse> GetAnalyticsAsync(
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>> endpointId,
            int? limit = default,
            string? cursor = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            string? timezone = default,
            global::Fal.GetAnalyticsTimeframe? timeframe = default,
            global::Fal.GetAnalyticsBoundToTimeframe? boundToTimeframe = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Analytics<br/>
        /// Time-bucketed metrics per model endpoint, including request counts, success/error<br/>
        /// rates, and latency percentiles. `prepare_duration` reflects queue/prepare<br/>
        /// time before execution; `duration` is request execution time. Use with the<br/>
        /// Queue/Webhooks flow to monitor SLAs.<br/>
        /// **Metric Selection:**<br/>
        /// You must specify which metrics to include using the `expand` query<br/>
        /// parameter. Only requested metrics will be populated in the response,<br/>
        /// allowing you to optimize query performance and data transfer.<br/>
        /// **Available Metrics:**<br/>
        /// The `expand` parameter accepts these values, grouped by category:<br/>
        /// *Volume*<br/>
        /// - `request_count`: Total number of requests in the time bucket<br/>
        /// - `success_count`: Successful requests (2xx responses)<br/>
        /// - `user_error_count`: User errors (4xx responses)<br/>
        /// - `error_count`: Server errors (5xx responses)<br/>
        /// *Error type breakdown*<br/>
        /// - `startup_error_count`: Startup errors (startup timeout, scheduling failure)<br/>
        /// - `connection_error_count`: Connection errors (timeout, disconnected, refused)<br/>
        /// - `timeout_error_count`: Request timeout errors<br/>
        /// - `runtime_error_count`: Runtime errors (internal error, server error)<br/>
        /// *Queue / prepare latency*<br/>
        /// - `p50_prepare_duration`, `p75_prepare_duration`, `p90_prepare_duration`, `p95_prepare_duration`, `p99_prepare_duration`: Time from request submission until execution starts<br/>
        /// *Request execution latency*<br/>
        /// - `p25_duration`, `p50_duration`, `p75_duration`, `p90_duration`, `p95_duration`, `p99_duration`: Time spent processing the request<br/>
        /// *Cold boot*<br/>
        /// - `cold_boot_count`: Requests with cold boot (startup &gt; 1s)<br/>
        /// - `p50_cold_boot_duration`, `p75_cold_boot_duration`, `p90_cold_boot_duration`: Cold boot duration percentiles<br/>
        /// *Billing*<br/>
        /// - `total_billable_duration`: Aggregate billed execution time<br/>
        /// **Key Features:**<br/>
        /// - Selective metric inclusion via expand parameter<br/>
        /// - Performance metrics (latency percentiles, duration stats)<br/>
        /// - Reliability metrics (success/error rates, request counts)<br/>
        /// - Error type breakdown (startup, connection, timeout, runtime)<br/>
        /// - Cold boot metrics (count, latency percentiles)<br/>
        /// - Billing duration tracking<br/>
        /// - Time-bucketed data for trend analysis<br/>
        /// - Single or multi-model analytics<br/>
        /// - Flexible date range and timeframe options<br/>
        /// **Common Use Cases:**<br/>
        /// - Monitor model performance and reliability<br/>
        /// - Generate performance dashboards<br/>
        /// - Analyze latency trends and patterns<br/>
        /// - Track error rates and success metrics<br/>
        /// See [Queue API docs](https://docs.fal.ai/model-apis/model-endpoints/queue) for more details.<br/>
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
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.GetAnalyticsResponse>> GetAnalyticsAsResponseAsync(
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>> endpointId,
            int? limit = default,
            string? cursor = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            string? timezone = default,
            global::Fal.GetAnalyticsTimeframe? timeframe = default,
            global::Fal.GetAnalyticsBoundToTimeframe? boundToTimeframe = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
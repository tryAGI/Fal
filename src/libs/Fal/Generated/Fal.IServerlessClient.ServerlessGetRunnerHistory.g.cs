#nullable enable

namespace Fal
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// Runner State History<br/>
        /// Returns historical runner counts by state (running, idle, pending, draining)<br/>
        /// for an application, bucketed over time.<br/>
        /// **Use cases:**<br/>
        /// - Capacity/utilization analysis: compare idle vs running over days or weeks<br/>
        ///   to see how much reserved capacity goes unused (use `aggregation=avg`)<br/>
        /// - Incident forensics: correlate error spikes with runner drops or drain<br/>
        ///   events around the incident window (use `aggregation=max`)<br/>
        /// **Time range:** up to 90 days of history. Defaults to the last 24 hours when<br/>
        /// `start`/`end` are omitted. Bucket size is auto-detected from the range<br/>
        /// unless `timeframe` is specified.<br/>
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
        /// <param name="timeframe">
        /// Bucket size for the time series (auto-detected from the date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
        /// Example: day
        /// </param>
        /// <param name="aggregation">
        /// How runner counts are aggregated within each bucket: 'max' shows peak concurrency (capacity analysis), 'avg' shows mean concurrency (utilization analysis).<br/>
        /// Default Value: max<br/>
        /// Example: max
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.ServerlessGetRunnerHistoryResponse> ServerlessGetRunnerHistoryAsync(
            string owner,
            string name,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            global::Fal.ServerlessGetRunnerHistoryTimeframe? timeframe = default,
            global::Fal.ServerlessGetRunnerHistoryAggregation? aggregation = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Runner State History<br/>
        /// Returns historical runner counts by state (running, idle, pending, draining)<br/>
        /// for an application, bucketed over time.<br/>
        /// **Use cases:**<br/>
        /// - Capacity/utilization analysis: compare idle vs running over days or weeks<br/>
        ///   to see how much reserved capacity goes unused (use `aggregation=avg`)<br/>
        /// - Incident forensics: correlate error spikes with runner drops or drain<br/>
        ///   events around the incident window (use `aggregation=max`)<br/>
        /// **Time range:** up to 90 days of history. Defaults to the last 24 hours when<br/>
        /// `start`/`end` are omitted. Bucket size is auto-detected from the range<br/>
        /// unless `timeframe` is specified.<br/>
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
        /// <param name="timeframe">
        /// Bucket size for the time series (auto-detected from the date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
        /// Example: day
        /// </param>
        /// <param name="aggregation">
        /// How runner counts are aggregated within each bucket: 'max' shows peak concurrency (capacity analysis), 'avg' shows mean concurrency (utilization analysis).<br/>
        /// Default Value: max<br/>
        /// Example: max
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.ServerlessGetRunnerHistoryResponse>> ServerlessGetRunnerHistoryAsResponseAsync(
            string owner,
            string name,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            global::Fal.ServerlessGetRunnerHistoryTimeframe? timeframe = default,
            global::Fal.ServerlessGetRunnerHistoryAggregation? aggregation = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
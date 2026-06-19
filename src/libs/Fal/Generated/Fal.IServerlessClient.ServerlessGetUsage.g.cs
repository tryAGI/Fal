#nullable enable

namespace Fal
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// Usage<br/>
        /// Time-bucketed, aggregated serverless compute usage for **your own account** —<br/>
        /// the machine-seconds your deployed serverless apps consumed, priced with your<br/>
        /// machine prices and net of discounts. This matches the serverless portion of the<br/>
        /// dashboard usage view. Unlike `/v1/models/usage` (which reports model API<br/>
        /// endpoint calls), this reports the `sdk_billing_event` compute spend of the apps<br/>
        /// you run on fal Serverless. Requires an `ADMIN`-scoped API key (this endpoint<br/>
        /// returns billing and usage data, which the standard `API` key scope does not<br/>
        /// include); results are always scoped to the apps you own.<br/>
        /// **Filtering by app:**<br/>
        /// - `app` — exact match on one or more app names (comma-separated or repeated,<br/>
        ///   up to 50): `?app=my-app-dev,my-app-prod`. Use the value exactly as it appears<br/>
        ///   in the response `app` field.<br/>
        /// - `search` — case-insensitive substring match on the app name, for when you<br/>
        ///   know the name but not the exact environment/version suffix: `?search=my-app`<br/>
        ///   returns every `my-app*` variant.<br/>
        /// - Provide both to AND them. Omit both to return every app you own — useful for<br/>
        ///   discovering the exact app names to filter on.<br/>
        /// **Expansions:**<br/>
        /// - `time_series`: usage grouped into time buckets (default)<br/>
        /// - `summary`: a single aggregate row per app × machine type across the window<br/>
        /// **Notes:**<br/>
        /// - Each row is machine-seconds (`unit` is always `"second"`); surge and<br/>
        ///   non-surge usage of the same app/machine come back as separate rows<br/>
        ///   (`is_surge`), so sum across them for a per-app total.<br/>
        /// - Time-series `bucket` timestamps are returned in the `timezone` you request<br/>
        ///   (ISO 8601 with offset, e.g. `2025-01-15T00:00:00-05:00`), which also controls<br/>
        ///   how usage is grouped into buckets.<br/>
        /// **Common Use Cases:**<br/>
        /// - Track your serverless apps' compute consumption and cost over time<br/>
        /// - Break down spend per app, environment, and machine type<br/>
        /// - Export usage to your own billing/observability tooling<br/>
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
        /// <param name="app">
        /// Filter to one or more serverless apps, matched exactly against the `app` value in the response (deployed name, owner prefix stripped). Accepts a comma-separated list or repeated parameter (1-50). For partial/name-only matching use `search`.<br/>
        /// Example: [autohdr-raw-to-jpg-dev]
        /// </param>
        /// <param name="search">
        /// Case-insensitive substring match on the app name — returns every app whose name contains this term (e.g. `search=autohdr` matches all `autohdr-*` apps across environments). Combined with `app` via AND when both are given.<br/>
        /// Example: autohdr-raw-to-jpg
        /// </param>
        /// <param name="expand">
        /// Data to include in the response. Use 'time_series' for time-bucketed data and 'summary' for aggregate statistics across the entire window. At least one is required.<br/>
        /// Default Value: [time_series]<br/>
        /// Example: [time_series, summary]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.ServerlessGetUsageResponse> ServerlessGetUsageAsync(
            int? limit = default,
            string? cursor = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            string? timezone = default,
            global::Fal.ServerlessGetUsageTimeframe? timeframe = default,
            global::Fal.ServerlessGetUsageBoundToTimeframe? boundToTimeframe = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? app = default,
            string? search = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Usage<br/>
        /// Time-bucketed, aggregated serverless compute usage for **your own account** —<br/>
        /// the machine-seconds your deployed serverless apps consumed, priced with your<br/>
        /// machine prices and net of discounts. This matches the serverless portion of the<br/>
        /// dashboard usage view. Unlike `/v1/models/usage` (which reports model API<br/>
        /// endpoint calls), this reports the `sdk_billing_event` compute spend of the apps<br/>
        /// you run on fal Serverless. Requires an `ADMIN`-scoped API key (this endpoint<br/>
        /// returns billing and usage data, which the standard `API` key scope does not<br/>
        /// include); results are always scoped to the apps you own.<br/>
        /// **Filtering by app:**<br/>
        /// - `app` — exact match on one or more app names (comma-separated or repeated,<br/>
        ///   up to 50): `?app=my-app-dev,my-app-prod`. Use the value exactly as it appears<br/>
        ///   in the response `app` field.<br/>
        /// - `search` — case-insensitive substring match on the app name, for when you<br/>
        ///   know the name but not the exact environment/version suffix: `?search=my-app`<br/>
        ///   returns every `my-app*` variant.<br/>
        /// - Provide both to AND them. Omit both to return every app you own — useful for<br/>
        ///   discovering the exact app names to filter on.<br/>
        /// **Expansions:**<br/>
        /// - `time_series`: usage grouped into time buckets (default)<br/>
        /// - `summary`: a single aggregate row per app × machine type across the window<br/>
        /// **Notes:**<br/>
        /// - Each row is machine-seconds (`unit` is always `"second"`); surge and<br/>
        ///   non-surge usage of the same app/machine come back as separate rows<br/>
        ///   (`is_surge`), so sum across them for a per-app total.<br/>
        /// - Time-series `bucket` timestamps are returned in the `timezone` you request<br/>
        ///   (ISO 8601 with offset, e.g. `2025-01-15T00:00:00-05:00`), which also controls<br/>
        ///   how usage is grouped into buckets.<br/>
        /// **Common Use Cases:**<br/>
        /// - Track your serverless apps' compute consumption and cost over time<br/>
        /// - Break down spend per app, environment, and machine type<br/>
        /// - Export usage to your own billing/observability tooling<br/>
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
        /// <param name="app">
        /// Filter to one or more serverless apps, matched exactly against the `app` value in the response (deployed name, owner prefix stripped). Accepts a comma-separated list or repeated parameter (1-50). For partial/name-only matching use `search`.<br/>
        /// Example: [autohdr-raw-to-jpg-dev]
        /// </param>
        /// <param name="search">
        /// Case-insensitive substring match on the app name — returns every app whose name contains this term (e.g. `search=autohdr` matches all `autohdr-*` apps across environments). Combined with `app` via AND when both are given.<br/>
        /// Example: autohdr-raw-to-jpg
        /// </param>
        /// <param name="expand">
        /// Data to include in the response. Use 'time_series' for time-bucketed data and 'summary' for aggregate statistics across the entire window. At least one is required.<br/>
        /// Default Value: [time_series]<br/>
        /// Example: [time_series, summary]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.ServerlessGetUsageResponse>> ServerlessGetUsageAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            string? timezone = default,
            global::Fal.ServerlessGetUsageTimeframe? timeframe = default,
            global::Fal.ServerlessGetUsageBoundToTimeframe? boundToTimeframe = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? app = default,
            string? search = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
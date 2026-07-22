#nullable enable

namespace Fal
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// Organization Usage<br/>
        /// Returns paginated usage records across all teams and product lines in your<br/>
        /// organization, with each record attributed to a specific team via the<br/>
        /// `username` field and a product line via the `product` field.<br/>
        /// Covers all three fal product lines:<br/>
        /// - `model_apis` — model API endpoint calls (e.g. `fal-ai/flux/dev`)<br/>
        /// - `serverless` — fal Serverless SDK billing<br/>
        /// - `compute` — fal Compute (raw instance time)<br/>
        /// &gt; **Availability:** This endpoint is available to enterprise customers with organizations enabled. Contact your account team or support@fal.ai to request access.<br/>
        /// Must be called with an admin API key on the organization's root team.<br/>
        /// **Key Features:**<br/>
        /// - Organization-wide usage data across all teams and products<br/>
        /// - Filter by team(s) (`team_username`), product line (`product`), endpoint, API key (`api_key_id`), date range, and auth method<br/>
        /// - Per-team and per-product attribution on every usage record<br/>
        /// - Paginated time series and aggregate summary views<br/>
        /// See [fal.ai docs](https://docs.fal.ai) for more details.<br/>
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
        /// <param name="apiKeyId">
        /// Filter by specific API key ID(s). Accepts 1-50 key IDs. Supports comma-separated values: ?api_key_id=key1,key2 or array syntax: ?api_key_id=key1&amp;api_key_id=key2<br/>
        /// Example: [abc123]
        /// </param>
        /// <param name="teamUsername">
        /// Filter by one or more team usernames within the organization. Accepts a comma-separated list or repeated parameter. If not provided, returns usage across all teams.<br/>
        /// Example: [acme-ml-team]
        /// </param>
        /// <param name="product">
        /// Restrict results to one or more product lines. Accepts a comma-separated list or repeated parameter. Defaults to all three (model_apis, serverless, compute).<br/>
        /// Example: [model_apis, compute]
        /// </param>
        /// <param name="expand">
        /// Data to include in the response. Use 'time_series' for time-bucketed data, 'summary' for aggregate statistics, 'auth_method' for a resolved authentication method label, and 'auth_method_structured' for a machine-readable auth method object (detail, api_key_id, login_username). At least one of 'time_series' or 'summary' is required.<br/>
        /// Default Value: [time_series]<br/>
        /// Example: [time_series, auth_method]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.GetOrganizationUsageResponse> GetOrganizationUsageAsync(
            int? limit = default,
            string? cursor = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            string? timezone = default,
            global::Fal.GetOrganizationUsageTimeframe? timeframe = default,
            global::Fal.GetOrganizationUsageBoundToTimeframe? boundToTimeframe = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? endpointId = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? apiKeyId = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? teamUsername = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? product = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Organization Usage<br/>
        /// Returns paginated usage records across all teams and product lines in your<br/>
        /// organization, with each record attributed to a specific team via the<br/>
        /// `username` field and a product line via the `product` field.<br/>
        /// Covers all three fal product lines:<br/>
        /// - `model_apis` — model API endpoint calls (e.g. `fal-ai/flux/dev`)<br/>
        /// - `serverless` — fal Serverless SDK billing<br/>
        /// - `compute` — fal Compute (raw instance time)<br/>
        /// &gt; **Availability:** This endpoint is available to enterprise customers with organizations enabled. Contact your account team or support@fal.ai to request access.<br/>
        /// Must be called with an admin API key on the organization's root team.<br/>
        /// **Key Features:**<br/>
        /// - Organization-wide usage data across all teams and products<br/>
        /// - Filter by team(s) (`team_username`), product line (`product`), endpoint, API key (`api_key_id`), date range, and auth method<br/>
        /// - Per-team and per-product attribution on every usage record<br/>
        /// - Paginated time series and aggregate summary views<br/>
        /// See [fal.ai docs](https://docs.fal.ai) for more details.<br/>
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
        /// <param name="apiKeyId">
        /// Filter by specific API key ID(s). Accepts 1-50 key IDs. Supports comma-separated values: ?api_key_id=key1,key2 or array syntax: ?api_key_id=key1&amp;api_key_id=key2<br/>
        /// Example: [abc123]
        /// </param>
        /// <param name="teamUsername">
        /// Filter by one or more team usernames within the organization. Accepts a comma-separated list or repeated parameter. If not provided, returns usage across all teams.<br/>
        /// Example: [acme-ml-team]
        /// </param>
        /// <param name="product">
        /// Restrict results to one or more product lines. Accepts a comma-separated list or repeated parameter. Defaults to all three (model_apis, serverless, compute).<br/>
        /// Example: [model_apis, compute]
        /// </param>
        /// <param name="expand">
        /// Data to include in the response. Use 'time_series' for time-bucketed data, 'summary' for aggregate statistics, 'auth_method' for a resolved authentication method label, and 'auth_method_structured' for a machine-readable auth method object (detail, api_key_id, login_username). At least one of 'time_series' or 'summary' is required.<br/>
        /// Default Value: [time_series]<br/>
        /// Example: [time_series, auth_method]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.GetOrganizationUsageResponse>> GetOrganizationUsageAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            string? timezone = default,
            global::Fal.GetOrganizationUsageTimeframe? timeframe = default,
            global::Fal.GetOrganizationUsageBoundToTimeframe? boundToTimeframe = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? endpointId = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? apiKeyId = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? teamUsername = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? product = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Fal
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// Organization FOCUS Report<br/>
        /// Returns a FOCUS compliant billing report as a CSV download, spanning every team<br/>
        /// in your organization. Each invoiced billing customer is reported as a<br/>
        /// `BillingAccount`. Under shared (pooled) billing — one billing customer covering<br/>
        /// multiple teams — each row is additionally attributed to the calling team via the<br/>
        /// `SubAccountId` / `SubAccountName` columns. `SubAccountId` is that team's own<br/>
        /// billing customer ID, so both account columns share one identifier namespace.<br/>
        /// &gt; **Availability:** This endpoint is available to enterprise customers with FOCUS reports and organizations enabled. Contact your account team or support@fal.ai to request access.<br/>
        /// Must be called with an admin API key on the organization's root team.<br/>
        /// Supports three data sources:<br/>
        /// - **estimate**: Real-time usage estimates for a date range. Under pooled billing every row is attributed to the calling team.<br/>
        /// - **tagged-estimate**: Those same estimates with the `Tags` column populated from the `X-Fal-Tags` tags set on your requests. Requires tagged reporting to be enabled for the organization; recent usage is delayed relative to `estimate`.<br/>
        /// - **invoice**: Finalized invoice data for a billing month. Under pooled billing, per-team `SubAccount` attribution is available on endpoint (Model API) lines that carry a caller; app and compute lines carry no caller and have no SubAccount.<br/>
        /// Use `team_username` to restrict the report to a single team. Under shared<br/>
        /// (pooled) billing this is rejected for `source=invoice` — the invoice is issued<br/>
        /// to one billing customer shared across teams and cannot be split per team; use<br/>
        /// `source=estimate` for per-team figures.<br/>
        /// **Invoice reports** default to the most recently available billing month.<br/>
        /// **Usage estimates** default to the last 24 hours, with a maximum 90-day date range.<br/>
        ///
        /// </summary>
        /// <param name="source">
        /// Report source. 'invoice' returns finalized invoice data for a billing month. 'estimate' returns real-time usage estimates for a date range. 'tagged-estimate' returns those same estimates with the Tags column populated from the X-Fal-Tags tags set on your requests; it requires tagged reporting to be enabled for the organization, and recent usage is delayed relative to 'estimate'.<br/>
        /// Example: estimate
        /// </param>
        /// <param name="billingMonth">
        /// Invoice billing month (YYYY-MM). The month the invoice was issued (e.g. '2025-02' for January charges). Used with source=invoice. Defaults to most recent available billing month.<br/>
        /// Example: 2025-02
        /// </param>
        /// <param name="chargeMonth">
        /// Charge month (YYYY-MM) — selects line items by the period charges were incurred, capturing them even when split across invoices issued in different months. Alternative to billing_month. Used with source=invoice.<br/>
        /// Example: 2025-01
        /// </param>
        /// <param name="teamUsername">
        /// Restrict the report to a single team (workspace nickname) in the organization. Omit to report across all teams.<br/>
        /// Example: acme-ml-team
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetOrganizationFocusReportAsync(
            global::Fal.GetOrganizationFocusReportSource source,
            string? billingMonth = default,
            string? chargeMonth = default,
            string? teamUsername = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            string? timezone = default,
            global::Fal.GetOrganizationFocusReportTimeframe? timeframe = default,
            global::Fal.GetOrganizationFocusReportBoundToTimeframe? boundToTimeframe = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Organization FOCUS Report<br/>
        /// Returns a FOCUS compliant billing report as a CSV download, spanning every team<br/>
        /// in your organization. Each invoiced billing customer is reported as a<br/>
        /// `BillingAccount`. Under shared (pooled) billing — one billing customer covering<br/>
        /// multiple teams — each row is additionally attributed to the calling team via the<br/>
        /// `SubAccountId` / `SubAccountName` columns. `SubAccountId` is that team's own<br/>
        /// billing customer ID, so both account columns share one identifier namespace.<br/>
        /// &gt; **Availability:** This endpoint is available to enterprise customers with FOCUS reports and organizations enabled. Contact your account team or support@fal.ai to request access.<br/>
        /// Must be called with an admin API key on the organization's root team.<br/>
        /// Supports three data sources:<br/>
        /// - **estimate**: Real-time usage estimates for a date range. Under pooled billing every row is attributed to the calling team.<br/>
        /// - **tagged-estimate**: Those same estimates with the `Tags` column populated from the `X-Fal-Tags` tags set on your requests. Requires tagged reporting to be enabled for the organization; recent usage is delayed relative to `estimate`.<br/>
        /// - **invoice**: Finalized invoice data for a billing month. Under pooled billing, per-team `SubAccount` attribution is available on endpoint (Model API) lines that carry a caller; app and compute lines carry no caller and have no SubAccount.<br/>
        /// Use `team_username` to restrict the report to a single team. Under shared<br/>
        /// (pooled) billing this is rejected for `source=invoice` — the invoice is issued<br/>
        /// to one billing customer shared across teams and cannot be split per team; use<br/>
        /// `source=estimate` for per-team figures.<br/>
        /// **Invoice reports** default to the most recently available billing month.<br/>
        /// **Usage estimates** default to the last 24 hours, with a maximum 90-day date range.<br/>
        ///
        /// </summary>
        /// <param name="source">
        /// Report source. 'invoice' returns finalized invoice data for a billing month. 'estimate' returns real-time usage estimates for a date range. 'tagged-estimate' returns those same estimates with the Tags column populated from the X-Fal-Tags tags set on your requests; it requires tagged reporting to be enabled for the organization, and recent usage is delayed relative to 'estimate'.<br/>
        /// Example: estimate
        /// </param>
        /// <param name="billingMonth">
        /// Invoice billing month (YYYY-MM). The month the invoice was issued (e.g. '2025-02' for January charges). Used with source=invoice. Defaults to most recent available billing month.<br/>
        /// Example: 2025-02
        /// </param>
        /// <param name="chargeMonth">
        /// Charge month (YYYY-MM) — selects line items by the period charges were incurred, capturing them even when split across invoices issued in different months. Alternative to billing_month. Used with source=invoice.<br/>
        /// Example: 2025-01
        /// </param>
        /// <param name="teamUsername">
        /// Restrict the report to a single team (workspace nickname) in the organization. Omit to report across all teams.<br/>
        /// Example: acme-ml-team
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<string>> GetOrganizationFocusReportAsResponseAsync(
            global::Fal.GetOrganizationFocusReportSource source,
            string? billingMonth = default,
            string? chargeMonth = default,
            string? teamUsername = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            string? timezone = default,
            global::Fal.GetOrganizationFocusReportTimeframe? timeframe = default,
            global::Fal.GetOrganizationFocusReportBoundToTimeframe? boundToTimeframe = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
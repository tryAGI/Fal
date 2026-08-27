#nullable enable

namespace Fal
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// Organization Billing Events<br/>
        /// Returns paginated individual billing event records across all teams in your<br/>
        /// organization, with each record attributed to a specific team via the<br/>
        /// `username` field. Each record includes a per-request cost breakdown in USD<br/>
        /// (cost_subtotal, cost_discount, cost_total; cost_estimate_nano_usd carries<br/>
        /// cost_total in nano USD).<br/>
        /// Scoped to fal Model API billing events. Must be called with an admin API key on<br/>
        /// the organization's root team.<br/>
        /// &gt; **Availability:** This endpoint is available to enterprise customers with organizations enabled. Contact your account team or support@fal.ai to request access.<br/>
        /// **Key Features:**<br/>
        /// - Organization-wide model-API billing event records across all teams<br/>
        /// - Filter by team(s) (`team_username`), endpoint, API key (`api_key_id`), request ID, and date range<br/>
        /// - Per-team attribution and per-request cost breakdown on every record<br/>
        /// - Cursor-based pagination for efficient large dataset queries<br/>
        /// - Limited to 100 records per page for performance<br/>
        /// - Date range capped at 90 days per request<br/>
        /// See [fal.ai docs](https://fal.ai/docs/documentation/model-apis/faq) for more details.<br/>
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
        /// <param name="endpointId">
        /// Filter by specific endpoint ID(s). Accepts 1-50 endpoint IDs. Supports comma-separated values: ?endpoint_id=model1,model2 or array syntax: ?endpoint_id=model1&amp;endpoint_id=model2<br/>
        /// Example: [fal-ai/flux/dev]
        /// </param>
        /// <param name="requestId">
        /// Filter by specific request ID(s). Accepts 1-50 request IDs. Supports comma-separated values: ?request_id=req1,req2 or array syntax: ?request_id=req1&amp;request_id=req2<br/>
        /// Example: [req-abc123]
        /// </param>
        /// <param name="apiKeyId">
        /// Filter by specific API key ID(s). Accepts 1-50 key IDs. Supports comma-separated values: ?api_key_id=key1,key2 or array syntax: ?api_key_id=key1&amp;api_key_id=key2<br/>
        /// Example: [abc123]
        /// </param>
        /// <param name="teamUsername">
        /// Filter billing events by one or more team usernames within the organization. Accepts a comma-separated list or repeated parameter. If not provided, returns billing events across all teams.<br/>
        /// Example: [acme-ml-team]
        /// </param>
        /// <param name="expand">
        /// Data to include in the response. Use 'auth_method' for a resolved authentication method label, and 'auth_method_structured' for a machine-readable auth method object (detail, api_key_id, login_username).<br/>
        /// Example: auth_method
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.GetOrganizationBillingEventsResponse> GetOrganizationBillingEventsAsync(
            int? limit = default,
            string? cursor = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? endpointId = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? requestId = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? apiKeyId = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? teamUsername = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Organization Billing Events<br/>
        /// Returns paginated individual billing event records across all teams in your<br/>
        /// organization, with each record attributed to a specific team via the<br/>
        /// `username` field. Each record includes a per-request cost breakdown in USD<br/>
        /// (cost_subtotal, cost_discount, cost_total; cost_estimate_nano_usd carries<br/>
        /// cost_total in nano USD).<br/>
        /// Scoped to fal Model API billing events. Must be called with an admin API key on<br/>
        /// the organization's root team.<br/>
        /// &gt; **Availability:** This endpoint is available to enterprise customers with organizations enabled. Contact your account team or support@fal.ai to request access.<br/>
        /// **Key Features:**<br/>
        /// - Organization-wide model-API billing event records across all teams<br/>
        /// - Filter by team(s) (`team_username`), endpoint, API key (`api_key_id`), request ID, and date range<br/>
        /// - Per-team attribution and per-request cost breakdown on every record<br/>
        /// - Cursor-based pagination for efficient large dataset queries<br/>
        /// - Limited to 100 records per page for performance<br/>
        /// - Date range capped at 90 days per request<br/>
        /// See [fal.ai docs](https://fal.ai/docs/documentation/model-apis/faq) for more details.<br/>
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
        /// <param name="endpointId">
        /// Filter by specific endpoint ID(s). Accepts 1-50 endpoint IDs. Supports comma-separated values: ?endpoint_id=model1,model2 or array syntax: ?endpoint_id=model1&amp;endpoint_id=model2<br/>
        /// Example: [fal-ai/flux/dev]
        /// </param>
        /// <param name="requestId">
        /// Filter by specific request ID(s). Accepts 1-50 request IDs. Supports comma-separated values: ?request_id=req1,req2 or array syntax: ?request_id=req1&amp;request_id=req2<br/>
        /// Example: [req-abc123]
        /// </param>
        /// <param name="apiKeyId">
        /// Filter by specific API key ID(s). Accepts 1-50 key IDs. Supports comma-separated values: ?api_key_id=key1,key2 or array syntax: ?api_key_id=key1&amp;api_key_id=key2<br/>
        /// Example: [abc123]
        /// </param>
        /// <param name="teamUsername">
        /// Filter billing events by one or more team usernames within the organization. Accepts a comma-separated list or repeated parameter. If not provided, returns billing events across all teams.<br/>
        /// Example: [acme-ml-team]
        /// </param>
        /// <param name="expand">
        /// Data to include in the response. Use 'auth_method' for a resolved authentication method label, and 'auth_method_structured' for a machine-readable auth method object (detail, api_key_id, login_username).<br/>
        /// Example: auth_method
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.GetOrganizationBillingEventsResponse>> GetOrganizationBillingEventsAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? endpointId = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? requestId = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? apiKeyId = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? teamUsername = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
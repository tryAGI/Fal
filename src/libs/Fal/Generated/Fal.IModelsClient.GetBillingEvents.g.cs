#nullable enable

namespace Fal
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Billing Events<br/>
        /// Returns paginated individual billing event records with filters<br/>
        /// for endpoint and date range. Each record includes the request ID, timestamp,<br/>
        /// endpoint, output units billed, and a cost breakdown in USD (cost_subtotal,<br/>
        /// cost_discount, cost_total; cost_estimate_nano_usd carries cost_total in nano USD).<br/>
        /// **Key Features:**<br/>
        /// - Individual billing event records for each API request<br/>
        /// - Per-request cost breakdown before and after discounts<br/>
        /// - Flexible date range filtering<br/>
        /// - Optional endpoint filtering<br/>
        /// - Cursor-based pagination for efficient large dataset queries<br/>
        /// - Limited to 10000 records per page for performance<br/>
        /// - Date range capped at 90 days per request<br/>
        /// **Tagged billing events:** pass `source=tagged-billed` to read the tagged<br/>
        /// billing-event pivot instead of the default feed. Each row then carries a `tags`<br/>
        /// object built from the `X-Fal-Tags` tags set on that request, and<br/>
        /// `tag=key=value` filters narrow the results — repeating the parameter with<br/>
        /// different keys ANDs them, repeating one key matches any of its values. Requires<br/>
        /// tagged reporting to be enabled for the account; recent events are delayed<br/>
        /// relative to the default source.<br/>
        /// **Common Use Cases:**<br/>
        /// - Audit individual billing events<br/>
        /// - Track request patterns and volumes<br/>
        /// - Debug specific requests by ID<br/>
        /// - Monitor billing unit consumption per request<br/>
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
        /// <param name="source">
        /// Data source. 'billed' is the default billed-event feed. 'tagged-billed' reads the tagged billing-event pivot instead, populating each row's 'tags' and enabling the 'tag' filter; it requires tagged reporting to be enabled for the account, and recent events are delayed relative to 'billed'.<br/>
        /// Default Value: billed<br/>
        /// Example: billed
        /// </param>
        /// <param name="endpointId">
        /// Filter by specific endpoint ID(s). Accepts 1-50 endpoint IDs. Supports comma-separated values: ?endpoint_id=model1,model2 or array syntax: ?endpoint_id=model1&amp;endpoint_id=model2<br/>
        /// Example: [fal-ai/flux/dev]
        /// </param>
        /// <param name="requestId">
        /// Filter by specific request ID(s). Accepts 1-50 request IDs. Supports comma-separated values: ?request_id=req1,req2 or array syntax: ?request_id=req1&amp;request_id=req2<br/>
        /// Example: [req-abc123]
        /// </param>
        /// <param name="tag">
        /// Filter by X-Fal-Tags 'key=value' pairs. Accepts 1-10 filters: different keys are AND-combined (?tag=env=prod&amp;tag=team=design), and repeating a key matches any of its values. Use the value '(untagged)' to match requests that did not set the key.<br/>
        /// Example: [env=prod]
        /// </param>
        /// <param name="apiKeyId">
        /// Filter by specific API key ID(s). Accepts 1-50 key IDs. Supports comma-separated values: ?api_key_id=key1,key2 or array syntax: ?api_key_id=key1&amp;api_key_id=key2<br/>
        /// Example: [abc123]
        /// </param>
        /// <param name="loginUsername">
        /// Filter by team member login username(s) (nickname). Accepts 1-50 usernames. Supports comma-separated values: ?login_username=alice,bob or array syntax: ?login_username=alice&amp;login_username=bob<br/>
        /// Example: [alice]
        /// </param>
        /// <param name="expand">
        /// Data to include in the response. Use 'auth_method' for a formatted authentication method label, and 'auth_method_structured' for a machine-readable auth method object (detail, api_key_id, login_username).<br/>
        /// Example: auth_method
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.GetBillingEventsResponse> GetBillingEventsAsync(
            int? limit = default,
            string? cursor = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            global::Fal.GetBillingEventsSource? source = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? endpointId = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? requestId = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? tag = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? apiKeyId = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? loginUsername = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Billing Events<br/>
        /// Returns paginated individual billing event records with filters<br/>
        /// for endpoint and date range. Each record includes the request ID, timestamp,<br/>
        /// endpoint, output units billed, and a cost breakdown in USD (cost_subtotal,<br/>
        /// cost_discount, cost_total; cost_estimate_nano_usd carries cost_total in nano USD).<br/>
        /// **Key Features:**<br/>
        /// - Individual billing event records for each API request<br/>
        /// - Per-request cost breakdown before and after discounts<br/>
        /// - Flexible date range filtering<br/>
        /// - Optional endpoint filtering<br/>
        /// - Cursor-based pagination for efficient large dataset queries<br/>
        /// - Limited to 10000 records per page for performance<br/>
        /// - Date range capped at 90 days per request<br/>
        /// **Tagged billing events:** pass `source=tagged-billed` to read the tagged<br/>
        /// billing-event pivot instead of the default feed. Each row then carries a `tags`<br/>
        /// object built from the `X-Fal-Tags` tags set on that request, and<br/>
        /// `tag=key=value` filters narrow the results — repeating the parameter with<br/>
        /// different keys ANDs them, repeating one key matches any of its values. Requires<br/>
        /// tagged reporting to be enabled for the account; recent events are delayed<br/>
        /// relative to the default source.<br/>
        /// **Common Use Cases:**<br/>
        /// - Audit individual billing events<br/>
        /// - Track request patterns and volumes<br/>
        /// - Debug specific requests by ID<br/>
        /// - Monitor billing unit consumption per request<br/>
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
        /// <param name="source">
        /// Data source. 'billed' is the default billed-event feed. 'tagged-billed' reads the tagged billing-event pivot instead, populating each row's 'tags' and enabling the 'tag' filter; it requires tagged reporting to be enabled for the account, and recent events are delayed relative to 'billed'.<br/>
        /// Default Value: billed<br/>
        /// Example: billed
        /// </param>
        /// <param name="endpointId">
        /// Filter by specific endpoint ID(s). Accepts 1-50 endpoint IDs. Supports comma-separated values: ?endpoint_id=model1,model2 or array syntax: ?endpoint_id=model1&amp;endpoint_id=model2<br/>
        /// Example: [fal-ai/flux/dev]
        /// </param>
        /// <param name="requestId">
        /// Filter by specific request ID(s). Accepts 1-50 request IDs. Supports comma-separated values: ?request_id=req1,req2 or array syntax: ?request_id=req1&amp;request_id=req2<br/>
        /// Example: [req-abc123]
        /// </param>
        /// <param name="tag">
        /// Filter by X-Fal-Tags 'key=value' pairs. Accepts 1-10 filters: different keys are AND-combined (?tag=env=prod&amp;tag=team=design), and repeating a key matches any of its values. Use the value '(untagged)' to match requests that did not set the key.<br/>
        /// Example: [env=prod]
        /// </param>
        /// <param name="apiKeyId">
        /// Filter by specific API key ID(s). Accepts 1-50 key IDs. Supports comma-separated values: ?api_key_id=key1,key2 or array syntax: ?api_key_id=key1&amp;api_key_id=key2<br/>
        /// Example: [abc123]
        /// </param>
        /// <param name="loginUsername">
        /// Filter by team member login username(s) (nickname). Accepts 1-50 usernames. Supports comma-separated values: ?login_username=alice,bob or array syntax: ?login_username=alice&amp;login_username=bob<br/>
        /// Example: [alice]
        /// </param>
        /// <param name="expand">
        /// Data to include in the response. Use 'auth_method' for a formatted authentication method label, and 'auth_method_structured' for a machine-readable auth method object (detail, api_key_id, login_username).<br/>
        /// Example: auth_method
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.GetBillingEventsResponse>> GetBillingEventsAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            global::Fal.GetBillingEventsSource? source = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? endpointId = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? requestId = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? tag = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? apiKeyId = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? loginUsername = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
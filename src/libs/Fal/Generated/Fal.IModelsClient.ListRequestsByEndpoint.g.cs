#nullable enable

namespace Fal
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List requests by endpoint(s)<br/>
        /// Lists requests for one or more endpoints (same `endpoint_id` style as usage/explore:<br/>
        /// comma-separated or repeated query params, up to 50 IDs).<br/>
        /// **Authentication:** Requires API key (user or enterprise).<br/>
        /// **Filters:**<br/>
        /// - Time range via start / end. If `start` is omitted, defaults to the last 24 hours — unless `request_id` is provided, in which case the default start bound is widened to 90 days.<br/>
        /// - Status (success, error, user_error)<br/>
        /// - Request ID<br/>
        /// - Pagination via cursor/limit (limit defaults to 50, max 100)<br/>
        /// **Sorting:**<br/>
        /// - By end time (default) or duration<br/>
        /// **Expansions:**<br/>
        /// - Include payloads by adding expand=payloads
        /// </summary>
        /// <param name="limit">
        /// Number of items to return per page (max 100)<br/>
        /// Default Value: 50<br/>
        /// Example: 20
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor encoding the page number<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="endpointId">
        /// Filter by specific endpoint ID(s). Accepts 1-50 endpoint IDs. Supports comma-separated values: ?endpoint_id=model1,model2 or array syntax: ?endpoint_id=model1&amp;endpoint_id=model2<br/>
        /// Example: [fal-ai/flux/dev]
        /// </param>
        /// <param name="start">
        /// Start date in ISO8601 format (e.g., '2025-01-01T00:00:00Z' or '2025-01-01'). Defaults to 24 hours ago.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </param>
        /// <param name="end">
        /// End date in ISO8601 format, exclusive (e.g., '2025-02-01T00:00:00Z' or '2025-02-01'). Data up to but not including this timestamp is returned. Defaults to current time.<br/>
        /// Example: 2025-02-01T00:00:00Z
        /// </param>
        /// <param name="status">
        /// Filter by request status<br/>
        /// Example: success
        /// </param>
        /// <param name="requestId">
        /// Filter by specific request ID<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </param>
        /// <param name="expand">
        /// Fields to expand in the response. Use payloads to include input and output payloads.<br/>
        /// Example: [payloads]
        /// </param>
        /// <param name="sortBy">
        /// Sort results by end time or duration<br/>
        /// Default Value: ended_at<br/>
        /// Example: ended_at
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.ListRequestsByEndpointResponse> ListRequestsByEndpointAsync(
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>> endpointId,
            int? limit = default,
            string? cursor = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            global::Fal.ListRequestsByEndpointStatus? status = default,
            global::System.Guid? requestId = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::Fal.ListRequestsByEndpointSortBy? sortBy = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
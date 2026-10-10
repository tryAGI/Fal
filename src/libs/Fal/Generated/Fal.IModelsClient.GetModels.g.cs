#nullable enable

namespace Fal
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Model search<br/>
        /// Unified endpoint for discovering model endpoints. Supports three usage modes:<br/>
        /// **1. List Mode** (no parameters):<br/>
        /// Paginated list of all available model endpoints with minimal metadata.<br/>
        /// **2. Find Mode** (`endpoint_id` parameter):<br/>
        /// Retrieve specific model endpoint(s) by ID. Supports single or multiple IDs.<br/>
        /// **3. Search Mode** (search parameters):<br/>
        /// Filter models by free-text query, category, or status.<br/>
        /// **Ordering (list/search):**<br/>
        /// - `sort=relevant` uses Explore's shared Trending browse order without keywords and relevance order with keywords. Trending data can fall back to publication dates when unavailable.<br/>
        /// - `sort=recent` sorts the complete filtered set by publication date (creation date when the publication date is missing), before pagination.<br/>
        /// - An explicit sort is acknowledged by `ordering.sort`. Omitting sort preserves the default response. Find mode always preserves the supplied endpoint ID order and has no ordering acknowledgement.<br/>
        /// - Keep sort, filters and limit unchanged when following `next_cursor`; cursors are page positions, not snapshots, and catalog/ranking updates can change later pages.<br/>
        /// **Expansion:**<br/>
        /// Use `expand` to include additional data in each model object:<br/>
        /// - `openapi-3.0` — full OpenAPI 3.0 schema in the `openapi` field<br/>
        /// - `enterprise_status` — enterprise readiness status (`ready` or `pending`) in the `enterprise_status` field<br/>
        /// **Examples of `endpoint_id` values:**<br/>
        /// - `fal-ai/flux/dev`<br/>
        /// - `fal-ai/wan/v2.2-a14b/text-to-video`<br/>
        /// - `fal-ai/minimax/video-01/image-to-video`<br/>
        /// - `fal-ai/hunyuan3d-v21`<br/>
        /// See [fal.ai Model APIs](https://fal.ai/docs/documentation/model-apis/overview) for more details.<br/>
        /// **Authentication:** Optional. Providing an API key grants higher rate limits.<br/>
        /// **Common Use Cases:**<br/>
        /// - Browse available models for integration<br/>
        /// - Retrieve metadata for specific endpoints<br/>
        /// - Search for models by category or keywords<br/>
        /// - Get OpenAPI schemas for code generation<br/>
        /// - Build model selection interfaces<br/>
        ///     <br/>
        /// **Authentication:** not required.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="endpointId">
        /// Endpoint ID(s) to retrieve (e.g., 'fal-ai/flux/dev'). Can be a single value or multiple values (1-50 models). When combined with search params, narrows results to these IDs. Use array syntax: ?endpoint_id=model1&amp;endpoint_id=model2<br/>
        /// Example: [fal-ai/flux/dev, fal-ai/flux-pro]
        /// </param>
        /// <param name="q">
        /// Free-text search query to filter models by name, description, or category<br/>
        /// Example: text to image
        /// </param>
        /// <param name="category">
        /// Filter by category (e.g., 'text-to-image', 'image-to-video', 'training')<br/>
        /// Example: text-to-image
        /// </param>
        /// <param name="status">
        /// Filter models by status - omit to include all statuses<br/>
        /// Example: active
        /// </param>
        /// <param name="sort">
        /// List/search ordering: relevant uses Explore's shared Trending browse order or keyword relevance; recent sorts by publication date (creation date when the publication date is missing). Defaults to relevant. Ignored in endpoint_id find mode, which preserves input order. Keep sort, filters and limit unchanged when following a cursor.<br/>
        /// Example: recent
        /// </param>
        /// <param name="expand">
        /// Fields to expand in the response. Supported values: 'openapi-3.0' (includes full OpenAPI 3.0 schema in 'openapi' field), 'enterprise_status' (includes enterprise readiness status)<br/>
        /// Example: [openapi-3.0, enterprise_status]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.GetModelsResponse> GetModelsAsync(
            int? limit = default,
            string? cursor = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? endpointId = default,
            string? q = default,
            string? category = default,
            global::Fal.GetModelsStatus? status = default,
            global::Fal.GetModelsSort? sort = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Model search<br/>
        /// Unified endpoint for discovering model endpoints. Supports three usage modes:<br/>
        /// **1. List Mode** (no parameters):<br/>
        /// Paginated list of all available model endpoints with minimal metadata.<br/>
        /// **2. Find Mode** (`endpoint_id` parameter):<br/>
        /// Retrieve specific model endpoint(s) by ID. Supports single or multiple IDs.<br/>
        /// **3. Search Mode** (search parameters):<br/>
        /// Filter models by free-text query, category, or status.<br/>
        /// **Ordering (list/search):**<br/>
        /// - `sort=relevant` uses Explore's shared Trending browse order without keywords and relevance order with keywords. Trending data can fall back to publication dates when unavailable.<br/>
        /// - `sort=recent` sorts the complete filtered set by publication date (creation date when the publication date is missing), before pagination.<br/>
        /// - An explicit sort is acknowledged by `ordering.sort`. Omitting sort preserves the default response. Find mode always preserves the supplied endpoint ID order and has no ordering acknowledgement.<br/>
        /// - Keep sort, filters and limit unchanged when following `next_cursor`; cursors are page positions, not snapshots, and catalog/ranking updates can change later pages.<br/>
        /// **Expansion:**<br/>
        /// Use `expand` to include additional data in each model object:<br/>
        /// - `openapi-3.0` — full OpenAPI 3.0 schema in the `openapi` field<br/>
        /// - `enterprise_status` — enterprise readiness status (`ready` or `pending`) in the `enterprise_status` field<br/>
        /// **Examples of `endpoint_id` values:**<br/>
        /// - `fal-ai/flux/dev`<br/>
        /// - `fal-ai/wan/v2.2-a14b/text-to-video`<br/>
        /// - `fal-ai/minimax/video-01/image-to-video`<br/>
        /// - `fal-ai/hunyuan3d-v21`<br/>
        /// See [fal.ai Model APIs](https://fal.ai/docs/documentation/model-apis/overview) for more details.<br/>
        /// **Authentication:** Optional. Providing an API key grants higher rate limits.<br/>
        /// **Common Use Cases:**<br/>
        /// - Browse available models for integration<br/>
        /// - Retrieve metadata for specific endpoints<br/>
        /// - Search for models by category or keywords<br/>
        /// - Get OpenAPI schemas for code generation<br/>
        /// - Build model selection interfaces<br/>
        ///     <br/>
        /// **Authentication:** not required.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="endpointId">
        /// Endpoint ID(s) to retrieve (e.g., 'fal-ai/flux/dev'). Can be a single value or multiple values (1-50 models). When combined with search params, narrows results to these IDs. Use array syntax: ?endpoint_id=model1&amp;endpoint_id=model2<br/>
        /// Example: [fal-ai/flux/dev, fal-ai/flux-pro]
        /// </param>
        /// <param name="q">
        /// Free-text search query to filter models by name, description, or category<br/>
        /// Example: text to image
        /// </param>
        /// <param name="category">
        /// Filter by category (e.g., 'text-to-image', 'image-to-video', 'training')<br/>
        /// Example: text-to-image
        /// </param>
        /// <param name="status">
        /// Filter models by status - omit to include all statuses<br/>
        /// Example: active
        /// </param>
        /// <param name="sort">
        /// List/search ordering: relevant uses Explore's shared Trending browse order or keyword relevance; recent sorts by publication date (creation date when the publication date is missing). Defaults to relevant. Ignored in endpoint_id find mode, which preserves input order. Keep sort, filters and limit unchanged when following a cursor.<br/>
        /// Example: recent
        /// </param>
        /// <param name="expand">
        /// Fields to expand in the response. Supported values: 'openapi-3.0' (includes full OpenAPI 3.0 schema in 'openapi' field), 'enterprise_status' (includes enterprise readiness status)<br/>
        /// Example: [openapi-3.0, enterprise_status]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.GetModelsResponse>> GetModelsAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? endpointId = default,
            string? q = default,
            string? category = default,
            global::Fal.GetModelsStatus? status = default,
            global::Fal.GetModelsSort? sort = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
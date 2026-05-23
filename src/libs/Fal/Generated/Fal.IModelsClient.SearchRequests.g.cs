#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Fal
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Search Requests<br/>
        /// Search, filter, and browse your request history. Supports three modes:<br/>
        /// **1. Semantic Search** (`query`, `image_url`, or `video_url` parameter):<br/>
        /// Find visually or conceptually similar results using AI embeddings. Provide a text<br/>
        /// query for text-to-image search, an image URL for image-to-image similarity search,<br/>
        /// or a video URL for video-to-image similarity search.<br/>
        /// **2. Filtered Browse** (no `query`, `image_url`, or `video_url`):<br/>
        /// Browse request history with hard filters. Returns results ordered by creation date (newest first).<br/>
        /// **3. Semantic + Filters** (search params AND filter params):<br/>
        /// Combine semantic search with hard filters. Filters narrow the candidate set before<br/>
        /// ranking by similarity.<br/>
        /// **Filter Options:**<br/>
        /// - `endpoint_id`: Filter by one or more fal endpoints (comma-separated or repeated, up to 50 IDs)<br/>
        /// - `exclude_api_requests` / `only_api_requests`: Filter by request source<br/>
        /// **Examples:**<br/>
        /// - Semantic text search: `?query=sunset+landscape`<br/>
        /// - Image similarity: `?image_url=https://...&amp;min_similarity=0.5`<br/>
        /// - Filtered search: `?query=portrait&amp;endpoint_id=fal-ai/flux/dev`<br/>
        /// - Browse across multiple endpoints: `?endpoint_id=fal-ai/flux/dev,fal-ai/flux/schnell`
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="query">
        /// Text search query for semantic search. Mutually exclusive with image_url and video_url.<br/>
        /// Example: sunset landscape
        /// </param>
        /// <param name="imageUrl">
        /// Image URL for similarity search. Mutually exclusive with query and video_url.<br/>
        /// Example: https://v3.fal.media/files/abc123/output.png
        /// </param>
        /// <param name="videoUrl">
        /// Video URL for similarity search. Mutually exclusive with query and image_url.<br/>
        /// Example: https://v3.fal.media/files/abc123/output.mp4
        /// </param>
        /// <param name="endpointId">
        /// Filter by one or more fal endpoints to scope request history. Accepts comma-separated or repeated values (1-50 IDs).<br/>
        /// Example: [fal-ai/flux/dev]
        /// </param>
        /// <param name="endpoint">
        /// Deprecated: use `endpoint_id`. Single-endpoint filter retained for backward compatibility. If both are provided, `endpoint_id` wins.<br/>
        /// Example: fal-ai/flux/dev
        /// </param>
        /// <param name="excludeApiRequests">
        /// Exclude requests made via API keys (only show playground/UI requests). Mutually exclusive with only_api_requests.<br/>
        /// Example: true
        /// </param>
        /// <param name="onlyApiRequests">
        /// Only include requests made via API keys. Mutually exclusive with exclude_api_requests.<br/>
        /// Example: true
        /// </param>
        /// <param name="minSimilarity">
        /// Minimum similarity score (0-1) for semantic search results. Only applies when query or image_url is provided.<br/>
        /// Example: 0.3F
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.SearchRequestsResponse> SearchRequestsAsync(
            int? limit = default,
            string? cursor = default,
            string? query = default,
            string? imageUrl = default,
            string? videoUrl = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? endpointId = default,
            string? endpoint = default,
            bool? excludeApiRequests = default,
            bool? onlyApiRequests = default,
            double? minSimilarity = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Requests<br/>
        /// Search, filter, and browse your request history. Supports three modes:<br/>
        /// **1. Semantic Search** (`query`, `image_url`, or `video_url` parameter):<br/>
        /// Find visually or conceptually similar results using AI embeddings. Provide a text<br/>
        /// query for text-to-image search, an image URL for image-to-image similarity search,<br/>
        /// or a video URL for video-to-image similarity search.<br/>
        /// **2. Filtered Browse** (no `query`, `image_url`, or `video_url`):<br/>
        /// Browse request history with hard filters. Returns results ordered by creation date (newest first).<br/>
        /// **3. Semantic + Filters** (search params AND filter params):<br/>
        /// Combine semantic search with hard filters. Filters narrow the candidate set before<br/>
        /// ranking by similarity.<br/>
        /// **Filter Options:**<br/>
        /// - `endpoint_id`: Filter by one or more fal endpoints (comma-separated or repeated, up to 50 IDs)<br/>
        /// - `exclude_api_requests` / `only_api_requests`: Filter by request source<br/>
        /// **Examples:**<br/>
        /// - Semantic text search: `?query=sunset+landscape`<br/>
        /// - Image similarity: `?image_url=https://...&amp;min_similarity=0.5`<br/>
        /// - Filtered search: `?query=portrait&amp;endpoint_id=fal-ai/flux/dev`<br/>
        /// - Browse across multiple endpoints: `?endpoint_id=fal-ai/flux/dev,fal-ai/flux/schnell`
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="query">
        /// Text search query for semantic search. Mutually exclusive with image_url and video_url.<br/>
        /// Example: sunset landscape
        /// </param>
        /// <param name="imageUrl">
        /// Image URL for similarity search. Mutually exclusive with query and video_url.<br/>
        /// Example: https://v3.fal.media/files/abc123/output.png
        /// </param>
        /// <param name="videoUrl">
        /// Video URL for similarity search. Mutually exclusive with query and image_url.<br/>
        /// Example: https://v3.fal.media/files/abc123/output.mp4
        /// </param>
        /// <param name="endpointId">
        /// Filter by one or more fal endpoints to scope request history. Accepts comma-separated or repeated values (1-50 IDs).<br/>
        /// Example: [fal-ai/flux/dev]
        /// </param>
        /// <param name="endpoint">
        /// Deprecated: use `endpoint_id`. Single-endpoint filter retained for backward compatibility. If both are provided, `endpoint_id` wins.<br/>
        /// Example: fal-ai/flux/dev
        /// </param>
        /// <param name="excludeApiRequests">
        /// Exclude requests made via API keys (only show playground/UI requests). Mutually exclusive with only_api_requests.<br/>
        /// Example: true
        /// </param>
        /// <param name="onlyApiRequests">
        /// Only include requests made via API keys. Mutually exclusive with exclude_api_requests.<br/>
        /// Example: true
        /// </param>
        /// <param name="minSimilarity">
        /// Minimum similarity score (0-1) for semantic search results. Only applies when query or image_url is provided.<br/>
        /// Example: 0.3F
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.SearchRequestsResponse>> SearchRequestsAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            string? query = default,
            string? imageUrl = default,
            string? videoUrl = default,
            global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>? endpointId = default,
            string? endpoint = default,
            bool? excludeApiRequests = default,
            bool? onlyApiRequests = default,
            double? minSimilarity = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
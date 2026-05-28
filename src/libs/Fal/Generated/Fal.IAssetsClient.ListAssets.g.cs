#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Browse assets<br/>
        /// Browse and semantically search fal Assets across all media, uploads, favorites, collections, tags, and character references.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="q">
        /// Text query for hybrid semantic search<br/>
        /// Example: cinematic portrait
        /// </param>
        /// <param name="searchImageUrl">
        /// fal-hosted image URL to use for semantic image search<br/>
        /// Example: https://v3b.fal.media/files/b/0a9b4900/PDbTGyzqRh1aijW2WQiY9_opengraph-1%20%281%29.png
        /// </param>
        /// <param name="searchVideoUrl">
        /// fal-hosted video URL to use for semantic video search<br/>
        /// Example: https://fal.media/files/example.mp4
        /// </param>
        /// <param name="mediaType">
        /// Filter by one or more media types<br/>
        /// Default Value: []<br/>
        /// Example: [image, video]
        /// </param>
        /// <param name="source">
        /// Filter by one or more indexed sources<br/>
        /// Default Value: []<br/>
        /// Example: [upload, response]
        /// </param>
        /// <param name="section">
        /// Asset library section to browse<br/>
        /// Default Value: all-media<br/>
        /// Example: all-media
        /// </param>
        /// <param name="collectionId">
        /// Collection scope to browse<br/>
        /// Example: d8b6elcregj72v34jr8g
        /// </param>
        /// <param name="characterIdentifier">
        /// Character identifiers to use as @mention semantic filters<br/>
        /// Default Value: []<br/>
        /// Example: [alice]
        /// </param>
        /// <param name="tagId">
        /// Tag IDs to filter by<br/>
        /// Default Value: []<br/>
        /// Example: [43ce3411-1a25-4d14-875e-3562d341b090]
        /// </param>
        /// <param name="tagMode">
        /// Whether tag filters match any tag or all tags<br/>
        /// Default Value: any<br/>
        /// Example: any
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.ListAssetsResponse> ListAssetsAsync(
            int? limit = default,
            string? cursor = default,
            string? q = default,
            string? searchImageUrl = default,
            string? searchVideoUrl = default,
            global::System.Collections.Generic.IList<global::Fal.ListAssetsMediaTypeItem>? mediaType = default,
            global::System.Collections.Generic.IList<global::Fal.ListAssetsSourceItem>? source = default,
            global::Fal.ListAssetsSection? section = default,
            string? collectionId = default,
            global::System.Collections.Generic.IList<string>? characterIdentifier = default,
            global::System.Collections.Generic.IList<string>? tagId = default,
            global::Fal.ListAssetsTagMode? tagMode = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Browse assets<br/>
        /// Browse and semantically search fal Assets across all media, uploads, favorites, collections, tags, and character references.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="q">
        /// Text query for hybrid semantic search<br/>
        /// Example: cinematic portrait
        /// </param>
        /// <param name="searchImageUrl">
        /// fal-hosted image URL to use for semantic image search<br/>
        /// Example: https://v3b.fal.media/files/b/0a9b4900/PDbTGyzqRh1aijW2WQiY9_opengraph-1%20%281%29.png
        /// </param>
        /// <param name="searchVideoUrl">
        /// fal-hosted video URL to use for semantic video search<br/>
        /// Example: https://fal.media/files/example.mp4
        /// </param>
        /// <param name="mediaType">
        /// Filter by one or more media types<br/>
        /// Default Value: []<br/>
        /// Example: [image, video]
        /// </param>
        /// <param name="source">
        /// Filter by one or more indexed sources<br/>
        /// Default Value: []<br/>
        /// Example: [upload, response]
        /// </param>
        /// <param name="section">
        /// Asset library section to browse<br/>
        /// Default Value: all-media<br/>
        /// Example: all-media
        /// </param>
        /// <param name="collectionId">
        /// Collection scope to browse<br/>
        /// Example: d8b6elcregj72v34jr8g
        /// </param>
        /// <param name="characterIdentifier">
        /// Character identifiers to use as @mention semantic filters<br/>
        /// Default Value: []<br/>
        /// Example: [alice]
        /// </param>
        /// <param name="tagId">
        /// Tag IDs to filter by<br/>
        /// Default Value: []<br/>
        /// Example: [43ce3411-1a25-4d14-875e-3562d341b090]
        /// </param>
        /// <param name="tagMode">
        /// Whether tag filters match any tag or all tags<br/>
        /// Default Value: any<br/>
        /// Example: any
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.ListAssetsResponse>> ListAssetsAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            string? q = default,
            string? searchImageUrl = default,
            string? searchVideoUrl = default,
            global::System.Collections.Generic.IList<global::Fal.ListAssetsMediaTypeItem>? mediaType = default,
            global::System.Collections.Generic.IList<global::Fal.ListAssetsSourceItem>? source = default,
            global::Fal.ListAssetsSection? section = default,
            string? collectionId = default,
            global::System.Collections.Generic.IList<string>? characterIdentifier = default,
            global::System.Collections.Generic.IList<string>? tagId = default,
            global::Fal.ListAssetsTagMode? tagMode = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Browse assets in a collection<br/>
        /// Browse assets in a collection for the authenticated user's fal Assets library.
        /// </summary>
        /// <param name="collectionId">
        /// Collection ID<br/>
        /// Example: col_01hxyq3m9k6d2r7p8v4n5c1b2a
        /// </param>
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
        /// Example: https://fal.media/files/example.png
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
        /// <param name="characterIdentifier">
        /// Character identifiers to use as @mention semantic filters<br/>
        /// Default Value: []<br/>
        /// Example: [alice]
        /// </param>
        /// <param name="tagId">
        /// Tag IDs to filter by<br/>
        /// Default Value: []<br/>
        /// Example: [tag_01hxyq3m9k6d2r7p8v4n5c1b2a]
        /// </param>
        /// <param name="tagMode">
        /// Whether tag filters match any tag or all tags<br/>
        /// Default Value: any<br/>
        /// Example: any
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.ListAssetCollectionAssetsResponse> ListAssetCollectionAssetsAsync(
            string collectionId,
            int? limit = default,
            string? cursor = default,
            string? q = default,
            string? searchImageUrl = default,
            string? searchVideoUrl = default,
            global::System.Collections.Generic.IList<global::Fal.ListAssetCollectionAssetsMediaTypeItem>? mediaType = default,
            global::System.Collections.Generic.IList<global::Fal.ListAssetCollectionAssetsSourceItem>? source = default,
            global::Fal.ListAssetCollectionAssetsSection? section = default,
            global::System.Collections.Generic.IList<string>? characterIdentifier = default,
            global::System.Collections.Generic.IList<string>? tagId = default,
            global::Fal.ListAssetCollectionAssetsTagMode? tagMode = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Browse assets in a collection<br/>
        /// Browse assets in a collection for the authenticated user's fal Assets library.
        /// </summary>
        /// <param name="collectionId">
        /// Collection ID<br/>
        /// Example: col_01hxyq3m9k6d2r7p8v4n5c1b2a
        /// </param>
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
        /// Example: https://fal.media/files/example.png
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
        /// <param name="characterIdentifier">
        /// Character identifiers to use as @mention semantic filters<br/>
        /// Default Value: []<br/>
        /// Example: [alice]
        /// </param>
        /// <param name="tagId">
        /// Tag IDs to filter by<br/>
        /// Default Value: []<br/>
        /// Example: [tag_01hxyq3m9k6d2r7p8v4n5c1b2a]
        /// </param>
        /// <param name="tagMode">
        /// Whether tag filters match any tag or all tags<br/>
        /// Default Value: any<br/>
        /// Example: any
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.ListAssetCollectionAssetsResponse>> ListAssetCollectionAssetsAsResponseAsync(
            string collectionId,
            int? limit = default,
            string? cursor = default,
            string? q = default,
            string? searchImageUrl = default,
            string? searchVideoUrl = default,
            global::System.Collections.Generic.IList<global::Fal.ListAssetCollectionAssetsMediaTypeItem>? mediaType = default,
            global::System.Collections.Generic.IList<global::Fal.ListAssetCollectionAssetsSourceItem>? source = default,
            global::Fal.ListAssetCollectionAssetsSection? section = default,
            global::System.Collections.Generic.IList<string>? characterIdentifier = default,
            global::System.Collections.Generic.IList<string>? tagId = default,
            global::Fal.ListAssetCollectionAssetsTagMode? tagMode = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
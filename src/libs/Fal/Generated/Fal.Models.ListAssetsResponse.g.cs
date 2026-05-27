
#nullable enable

namespace Fal
{
    /// <summary>
    /// Paginated asset browse response
    /// </summary>
    public sealed partial class ListAssetsResponse
    {
        /// <summary>
        /// Asset results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.ListAssetsResponseAsset> Assets { get; set; }

        /// <summary>
        /// Cursor for the next page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether more results are available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Exact total when available; null when unavailable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public double? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAssetsResponse" /> class.
        /// </summary>
        /// <param name="assets">
        /// Asset results
        /// </param>
        /// <param name="hasMore">
        /// Whether more results are available
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page
        /// </param>
        /// <param name="totalCount">
        /// Exact total when available; null when unavailable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAssetsResponse(
            global::System.Collections.Generic.IList<global::Fal.ListAssetsResponseAsset> assets,
            bool hasMore,
            string? nextCursor,
            double? totalCount)
        {
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAssetsResponse" /> class.
        /// </summary>
        public ListAssetsResponse()
        {
        }

    }
}
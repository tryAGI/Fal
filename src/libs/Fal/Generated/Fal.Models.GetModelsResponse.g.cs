
#nullable enable

namespace Fal
{
    /// <summary>
    /// Response containing model data with pagination support
    /// </summary>
    public sealed partial class GetModelsResponse
    {
        /// <summary>
        /// Array of model information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.GetModelsResponseModel> Models { get; set; }

        /// <summary>
        /// Cursor for the next page of results, null if no more pages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Acknowledges an explicitly requested list/search sort. Absent on legacy default requests and endpoint_id find mode. Relevant is shared discovery ordering, not a quality or latency ranking; its Trending data can fall back to publication dates when unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ordering")]
        public global::Fal.GetModelsResponseOrdering? Ordering { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponse" /> class.
        /// </summary>
        /// <param name="models">
        /// Array of model information
        /// </param>
        /// <param name="hasMore">
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page of results, null if no more pages
        /// </param>
        /// <param name="ordering">
        /// Acknowledges an explicitly requested list/search sort. Absent on legacy default requests and endpoint_id find mode. Relevant is shared discovery ordering, not a quality or latency ranking; its Trending data can fall back to publication dates when unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelsResponse(
            global::System.Collections.Generic.IList<global::Fal.GetModelsResponseModel> models,
            bool hasMore,
            string? nextCursor,
            global::Fal.GetModelsResponseOrdering? ordering)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.Ordering = ordering;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponse" /> class.
        /// </summary>
        public GetModelsResponse()
        {
        }

    }
}
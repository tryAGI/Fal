
#nullable enable

namespace Fal
{
    /// <summary>
    /// Revision history for an application
    /// </summary>
    public sealed partial class ServerlessListAppRevisionsResponse
    {
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
        /// Canonical endpoint identifier ('&lt;owner&gt;/&lt;name&gt;')<br/>
        /// Example: user_123/my-app
        /// </summary>
        /// <example>user_123/my-app</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// Application revisions, newest first
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revisions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.ServerlessListAppRevisionsResponseRevision> Revisions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListAppRevisionsResponse" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </param>
        /// <param name="endpointId">
        /// Canonical endpoint identifier ('&lt;owner&gt;/&lt;name&gt;')<br/>
        /// Example: user_123/my-app
        /// </param>
        /// <param name="revisions">
        /// Application revisions, newest first
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page of results, null if no more pages
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerlessListAppRevisionsResponse(
            bool hasMore,
            string endpointId,
            global::System.Collections.Generic.IList<global::Fal.ServerlessListAppRevisionsResponseRevision> revisions,
            string? nextCursor)
        {
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.Revisions = revisions ?? throw new global::System.ArgumentNullException(nameof(revisions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListAppRevisionsResponse" /> class.
        /// </summary>
        public ServerlessListAppRevisionsResponse()
        {
        }

    }
}
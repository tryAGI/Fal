
#nullable enable

namespace Fal
{
    /// <summary>
    /// Response containing billing event data with pagination support
    /// </summary>
    public sealed partial class GetBillingEventsResponse
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
        /// List of billing event records
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.GetBillingEventsResponseBillingEvent> BillingEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBillingEventsResponse" /> class.
        /// </summary>
        /// <param name="nextCursor">
        /// Cursor for the next page of results, null if no more pages
        /// </param>
        /// <param name="hasMore">
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </param>
        /// <param name="billingEvents">
        /// List of billing event records
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBillingEventsResponse(
            bool hasMore,
            global::System.Collections.Generic.IList<global::Fal.GetBillingEventsResponseBillingEvent> billingEvents,
            string? nextCursor)
        {
            this.HasMore = hasMore;
            this.BillingEvents = billingEvents ?? throw new global::System.ArgumentNullException(nameof(billingEvents));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBillingEventsResponse" /> class.
        /// </summary>
        public GetBillingEventsResponse()
        {
        }
    }
}
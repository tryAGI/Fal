
#nullable enable

namespace Fal
{
    /// <summary>
    /// Acknowledges an explicitly requested list/search sort. Absent on legacy default requests and endpoint_id find mode. Relevant is shared discovery ordering, not a quality or latency ranking; its Trending data can fall back to publication dates when unavailable.
    /// </summary>
    public sealed partial class GetModelsResponseOrdering
    {
        /// <summary>
        /// List/search ordering applied to this response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.GetModelsResponseOrderingSortJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.GetModelsResponseOrderingSort Sort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseOrdering" /> class.
        /// </summary>
        /// <param name="sort">
        /// List/search ordering applied to this response
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelsResponseOrdering(
            global::Fal.GetModelsResponseOrderingSort sort)
        {
            this.Sort = sort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseOrdering" /> class.
        /// </summary>
        public GetModelsResponseOrdering()
        {
        }

    }
}
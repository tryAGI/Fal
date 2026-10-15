
#nullable enable

namespace Fal
{
    /// <summary>
    /// Activated X-Fal-Tags key/values represented by this row. Only populated when source=tagged-estimate; a key the row's requests did not set is omitted, so a row that set none reports {}. A key activated for all of its values keeps its 50 highest-cost values over the request window and reports the rest as '(other)'.
    /// </summary>
    public sealed partial class GetUsageResponseSummaryItemTags
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// Activated X-Fal-Tags key/values set on this request. Only populated when source=tagged-billed; a key the request did not set is omitted, so a request that set none reports {}.
    /// </summary>
    public sealed partial class GetBillingEventsResponseBillingEventTags
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
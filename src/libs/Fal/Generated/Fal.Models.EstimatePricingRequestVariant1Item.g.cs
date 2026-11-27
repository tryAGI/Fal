
#nullable enable

namespace Fal
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EstimatePricingRequestVariant1Item
    {
        /// <summary>
        /// The endpoint as you would call it, e.g. 'xai/tts/v1'. Aliases are priced under the name called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// The request body you would send to the endpoint. The endpoint's own estimate reads it to predict what the request uses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingRequestVariant1Item" /> class.
        /// </summary>
        /// <param name="endpointId">
        /// The endpoint as you would call it, e.g. 'xai/tts/v1'. Aliases are priced under the name called.
        /// </param>
        /// <param name="input">
        /// The request body you would send to the endpoint. The endpoint's own estimate reads it to predict what the request uses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimatePricingRequestVariant1Item(
            string endpointId,
            object input)
        {
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingRequestVariant1Item" /> class.
        /// </summary>
        public EstimatePricingRequestVariant1Item()
        {
        }

    }
}
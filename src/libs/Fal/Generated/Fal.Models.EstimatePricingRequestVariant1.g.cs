
#nullable enable

namespace Fal
{
    /// <summary>
    /// Historical API price estimate: Calculates cost based on historical pricing per API call. Useful for estimating costs based on actual usage patterns.
    /// </summary>
    public sealed partial class EstimatePricingRequestVariant1
    {
        /// <summary>
        /// Estimate type: historical API pricing based on past usage patterns
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimate_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.EstimatePricingRequestVariant1EstimateTypeJsonConverter))]
        public global::Fal.EstimatePricingRequestVariant1EstimateType EstimateType { get; set; }

        /// <summary>
        /// Map of endpoint IDs to call quantities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Fal.EstimatePricingRequestVariant1Endpoints2> Endpoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingRequestVariant1" /> class.
        /// </summary>
        /// <param name="estimateType">
        /// Estimate type: historical API pricing based on past usage patterns
        /// </param>
        /// <param name="endpoints">
        /// Map of endpoint IDs to call quantities
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimatePricingRequestVariant1(
            global::System.Collections.Generic.Dictionary<string, global::Fal.EstimatePricingRequestVariant1Endpoints2> endpoints,
            global::Fal.EstimatePricingRequestVariant1EstimateType estimateType)
        {
            this.Endpoints = endpoints ?? throw new global::System.ArgumentNullException(nameof(endpoints));
            this.EstimateType = estimateType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingRequestVariant1" /> class.
        /// </summary>
        public EstimatePricingRequestVariant1()
        {
        }
    }
}
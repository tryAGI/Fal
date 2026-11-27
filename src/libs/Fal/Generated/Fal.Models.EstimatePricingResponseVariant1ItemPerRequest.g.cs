
#nullable enable

namespace Fal
{
    /// <summary>
    /// One request's price; null when status is unavailable.
    /// </summary>
    public sealed partial class EstimatePricingResponseVariant1ItemPerRequest
    {
        /// <summary>
        /// What one request uses and what each part costs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("components")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.EstimatePricingResponseVariant1ItemPerRequestComponent> Components { get; set; }

        /// <summary>
        /// One request's known amounts summed, in USD as a decimal string with 9 places, before percentage discounts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rated_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RatedAmount { get; set; }

        /// <summary>
        /// 'minimum' or 'maximum' when that bound set rated_amount; null when neither did.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clamped")]
        public string? Clamped { get; set; }

        /// <summary>
        /// exact: decided by the input. statistical: predicted, the run may differ. unavailable: can't be known before the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.EstimatePricingResponseVariant1ItemPerRequestConfidenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.EstimatePricingResponseVariant1ItemPerRequestConfidence Confidence { get; set; }

        /// <summary>
        /// The confidence of the parts that are known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("known_confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.EstimatePricingResponseVariant1ItemPerRequestKnownConfidenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.EstimatePricingResponseVariant1ItemPerRequestKnownConfidence KnownConfidence { get; set; }

        /// <summary>
        /// The price's lower bound, if the pricing has one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum")]
        public string? Minimum { get; set; }

        /// <summary>
        /// The price's upper bound, if the pricing has one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum")]
        public string? Maximum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingResponseVariant1ItemPerRequest" /> class.
        /// </summary>
        /// <param name="components">
        /// What one request uses and what each part costs.
        /// </param>
        /// <param name="ratedAmount">
        /// One request's known amounts summed, in USD as a decimal string with 9 places, before percentage discounts.
        /// </param>
        /// <param name="confidence">
        /// exact: decided by the input. statistical: predicted, the run may differ. unavailable: can't be known before the run.
        /// </param>
        /// <param name="knownConfidence">
        /// The confidence of the parts that are known.
        /// </param>
        /// <param name="clamped">
        /// 'minimum' or 'maximum' when that bound set rated_amount; null when neither did.
        /// </param>
        /// <param name="minimum">
        /// The price's lower bound, if the pricing has one.
        /// </param>
        /// <param name="maximum">
        /// The price's upper bound, if the pricing has one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimatePricingResponseVariant1ItemPerRequest(
            global::System.Collections.Generic.IList<global::Fal.EstimatePricingResponseVariant1ItemPerRequestComponent> components,
            string ratedAmount,
            global::Fal.EstimatePricingResponseVariant1ItemPerRequestConfidence confidence,
            global::Fal.EstimatePricingResponseVariant1ItemPerRequestKnownConfidence knownConfidence,
            string? clamped,
            string? minimum,
            string? maximum)
        {
            this.Components = components ?? throw new global::System.ArgumentNullException(nameof(components));
            this.RatedAmount = ratedAmount ?? throw new global::System.ArgumentNullException(nameof(ratedAmount));
            this.Clamped = clamped;
            this.Confidence = confidence;
            this.KnownConfidence = knownConfidence;
            this.Minimum = minimum;
            this.Maximum = maximum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingResponseVariant1ItemPerRequest" /> class.
        /// </summary>
        public EstimatePricingResponseVariant1ItemPerRequest()
        {
        }

    }
}
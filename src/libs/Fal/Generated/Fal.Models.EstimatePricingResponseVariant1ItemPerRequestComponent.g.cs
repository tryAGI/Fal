
#nullable enable

namespace Fal
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EstimatePricingResponseVariant1ItemPerRequestComponent
    {
        /// <summary>
        /// Which of the formula's components this is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("component_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ComponentKey { get; set; }

        /// <summary>
        /// What is counted, e.g. 'characters'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Metric { get; set; }

        /// <summary>
        /// The unit the rate is per; null when unknown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_unit")]
        public global::Fal.EstimatePricingResponseVariant1ItemPerRequestComponentBillingUnit? BillingUnit { get; set; }

        /// <summary>
        /// Decimal string; null when it can't be predicted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public string? Quantity { get; set; }

        /// <summary>
        /// Decimal string; null when it can't be predicted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        public string? Rate { get; set; }

        /// <summary>
        /// Name and value pairs that select the rate, e.g. ['resolution', '2K'].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> Dimensions { get; set; }

        /// <summary>
        /// Decimal string; null when the quantity or rate is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public string? Amount { get; set; }

        /// <summary>
        /// exact: decided by the input. statistical: predicted, the run may differ. unavailable: can't be known before the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.EstimatePricingResponseVariant1ItemPerRequestComponentConfidenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.EstimatePricingResponseVariant1ItemPerRequestComponentConfidence Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingResponseVariant1ItemPerRequestComponent" /> class.
        /// </summary>
        /// <param name="componentKey">
        /// Which of the formula's components this is.
        /// </param>
        /// <param name="metric">
        /// What is counted, e.g. 'characters'.
        /// </param>
        /// <param name="dimensions">
        /// Name and value pairs that select the rate, e.g. ['resolution', '2K'].
        /// </param>
        /// <param name="confidence">
        /// exact: decided by the input. statistical: predicted, the run may differ. unavailable: can't be known before the run.
        /// </param>
        /// <param name="billingUnit">
        /// The unit the rate is per; null when unknown.
        /// </param>
        /// <param name="quantity">
        /// Decimal string; null when it can't be predicted.
        /// </param>
        /// <param name="rate">
        /// Decimal string; null when it can't be predicted.
        /// </param>
        /// <param name="amount">
        /// Decimal string; null when the quantity or rate is.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimatePricingResponseVariant1ItemPerRequestComponent(
            int componentKey,
            string metric,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> dimensions,
            global::Fal.EstimatePricingResponseVariant1ItemPerRequestComponentConfidence confidence,
            global::Fal.EstimatePricingResponseVariant1ItemPerRequestComponentBillingUnit? billingUnit,
            string? quantity,
            string? rate,
            string? amount)
        {
            this.ComponentKey = componentKey;
            this.Metric = metric ?? throw new global::System.ArgumentNullException(nameof(metric));
            this.BillingUnit = billingUnit;
            this.Quantity = quantity;
            this.Rate = rate;
            this.Dimensions = dimensions ?? throw new global::System.ArgumentNullException(nameof(dimensions));
            this.Amount = amount;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingResponseVariant1ItemPerRequestComponent" /> class.
        /// </summary>
        public EstimatePricingResponseVariant1ItemPerRequestComponent()
        {
        }

    }
}
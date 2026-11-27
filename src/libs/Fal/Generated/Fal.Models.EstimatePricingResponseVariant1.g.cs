
#nullable enable

namespace Fal
{
    /// <summary>
    /// Request-based estimate: what each request would cost if it succeeds, before percentage discounts. Advisory, not a price lock; estimating is never billed.
    /// </summary>
    public sealed partial class EstimatePricingResponseVariant1
    {
        /// <summary>
        /// Three-letter currency code (ISO 4217), 'USD'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// When the estimate was made (ISO 8601).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EstimatedAt { get; set; }

        /// <summary>
        /// complete only if every item is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.EstimatePricingResponseVariant1StatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.EstimatePricingResponseVariant1Status Status { get; set; }

        /// <summary>
        /// exact: decided by the input. statistical: predicted, the run may differ. unavailable: can't be known before the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.EstimatePricingResponseVariant1ConfidenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.EstimatePricingResponseVariant1Confidence Confidence { get; set; }

        /// <summary>
        /// The items' sum; null when any item is unavailable, in USD as a decimal string with 9 places, before percentage discounts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rated_amount")]
        public string? RatedAmount { get; set; }

        /// <summary>
        /// In request order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.EstimatePricingResponseVariant1Item> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingResponseVariant1" /> class.
        /// </summary>
        /// <param name="estimatedAt">
        /// When the estimate was made (ISO 8601).
        /// </param>
        /// <param name="status">
        /// complete only if every item is.
        /// </param>
        /// <param name="confidence">
        /// exact: decided by the input. statistical: predicted, the run may differ. unavailable: can't be known before the run.
        /// </param>
        /// <param name="items">
        /// In request order.
        /// </param>
        /// <param name="currency">
        /// Three-letter currency code (ISO 4217), 'USD'.
        /// </param>
        /// <param name="ratedAmount">
        /// The items' sum; null when any item is unavailable, in USD as a decimal string with 9 places, before percentage discounts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimatePricingResponseVariant1(
            string estimatedAt,
            global::Fal.EstimatePricingResponseVariant1Status status,
            global::Fal.EstimatePricingResponseVariant1Confidence confidence,
            global::System.Collections.Generic.IList<global::Fal.EstimatePricingResponseVariant1Item> items,
            string? currency,
            string? ratedAmount)
        {
            this.Currency = currency;
            this.EstimatedAt = estimatedAt ?? throw new global::System.ArgumentNullException(nameof(estimatedAt));
            this.Status = status;
            this.Confidence = confidence;
            this.RatedAmount = ratedAmount;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingResponseVariant1" /> class.
        /// </summary>
        public EstimatePricingResponseVariant1()
        {
        }

    }
}
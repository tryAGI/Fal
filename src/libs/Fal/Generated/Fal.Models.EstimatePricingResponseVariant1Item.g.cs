
#nullable enable

namespace Fal
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EstimatePricingResponseVariant1Item
    {
        /// <summary>
        /// The item's position in the request; endpoint IDs can repeat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The endpoint as sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// Requests priced; always 1 for now.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// What the item was priced from: 'input'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("basis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Basis { get; set; }

        /// <summary>
        /// complete: fully priced. partial: something can't be estimated, see warnings. unavailable: no quote, see error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.EstimatePricingResponseVariant1ItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.EstimatePricingResponseVariant1ItemStatus Status { get; set; }

        /// <summary>
        /// What couldn't be estimated, for a partial item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.EstimatePricingResponseVariant1ItemWarning> Warnings { get; set; }

        /// <summary>
        /// Why the item has no quote; null unless status is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Fal.EstimatePricingResponseVariant1ItemError? Error { get; set; }

        /// <summary>
        /// The request's price, in USD as a decimal string with 9 places, before percentage discounts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rated_amount")]
        public string? RatedAmount { get; set; }

        /// <summary>
        /// One request's price; null when status is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_request")]
        public global::Fal.EstimatePricingResponseVariant1ItemPerRequest? PerRequest { get; set; }

        /// <summary>
        /// The endpoint whose pricing priced the item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priced_as")]
        public string? PricedAs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingResponseVariant1Item" /> class.
        /// </summary>
        /// <param name="index">
        /// The item's position in the request; endpoint IDs can repeat.
        /// </param>
        /// <param name="endpointId">
        /// The endpoint as sent.
        /// </param>
        /// <param name="count">
        /// Requests priced; always 1 for now.
        /// </param>
        /// <param name="basis">
        /// What the item was priced from: 'input'.
        /// </param>
        /// <param name="status">
        /// complete: fully priced. partial: something can't be estimated, see warnings. unavailable: no quote, see error.
        /// </param>
        /// <param name="warnings">
        /// What couldn't be estimated, for a partial item.
        /// </param>
        /// <param name="error">
        /// Why the item has no quote; null unless status is unavailable.
        /// </param>
        /// <param name="ratedAmount">
        /// The request's price, in USD as a decimal string with 9 places, before percentage discounts.
        /// </param>
        /// <param name="perRequest">
        /// One request's price; null when status is unavailable.
        /// </param>
        /// <param name="pricedAs">
        /// The endpoint whose pricing priced the item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimatePricingResponseVariant1Item(
            int index,
            string endpointId,
            int count,
            string basis,
            global::Fal.EstimatePricingResponseVariant1ItemStatus status,
            global::System.Collections.Generic.IList<global::Fal.EstimatePricingResponseVariant1ItemWarning> warnings,
            global::Fal.EstimatePricingResponseVariant1ItemError? error,
            string? ratedAmount,
            global::Fal.EstimatePricingResponseVariant1ItemPerRequest? perRequest,
            string? pricedAs)
        {
            this.Index = index;
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.Count = count;
            this.Basis = basis ?? throw new global::System.ArgumentNullException(nameof(basis));
            this.Status = status;
            this.Warnings = warnings ?? throw new global::System.ArgumentNullException(nameof(warnings));
            this.Error = error;
            this.RatedAmount = ratedAmount;
            this.PerRequest = perRequest;
            this.PricedAs = pricedAs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingResponseVariant1Item" /> class.
        /// </summary>
        public EstimatePricingResponseVariant1Item()
        {
        }

    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Fal
{
    /// <summary>
    /// Individual billing event record with details
    /// </summary>
    public sealed partial class GetBillingEventsResponseBillingEvent
    {
        /// <summary>
        /// Unique identifier for the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Endpoint identifier that was used (e.g., 'fal-ai/flux/dev')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// Request timestamp in ISO8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Billable units consumed, in the unit named by `unit`. Same value as the deprecated `output_units`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// Deprecated: use quantity. Same value as quantity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_units")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? OutputUnits { get; set; }

        /// <summary>
        /// The billing unit these units are counted in (e.g. 'image', 'second', 'megapixel'). Null when the reporter recorded none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        public string? Unit { get; set; }

        /// <summary>
        /// Per-unit price this line is measured against: the list rate when a discount is reported in percent_discount, otherwise the negotiated rate after any price override and before percentage discounts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_price")]
        public double? UnitPrice { get; set; }

        /// <summary>
        /// Discount percentage applied to this request (e.g., 10 = 10% discount)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent_discount")]
        public double? PercentDiscount { get; set; }

        /// <summary>
        /// Cost before discounts in USD (output_units × unit_price)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_subtotal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CostSubtotal { get; set; }

        /// <summary>
        /// Discount applied to this request in USD (cost_subtotal − cost_total)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_discount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CostDiscount { get; set; }

        /// <summary>
        /// Amount charged after discounts in USD (cost_subtotal − cost_discount)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CostTotal { get; set; }

        /// <summary>
        /// Amount charged after discounts in nano USD. The precision-preserving representation of cost_total, not a legacy duplicate: an integer nano-USD amount avoids the float error that accumulates when summing sub-cent charges (1 USD = 1,000,000,000 nano USD).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_estimate_nano_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CostEstimateNanoUsd { get; set; }

        /// <summary>
        /// Authentication method label (e.g., 'Key 1', 'API Key', 'User token'). Only populated when 'auth_method' is included in expand parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_method")]
        public string? AuthMethod { get; set; }

        /// <summary>
        /// Structured authentication method identity. Only populated when 'auth_method_structured' is included in expand parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_method_structured")]
        public global::Fal.GetBillingEventsResponseBillingEventAuthMethodStructured? AuthMethodStructured { get; set; }

        /// <summary>
        /// Activated X-Fal-Tags key/values set on this request. Only populated when source=tagged-billed; a key the request did not set is omitted, so a request that set none reports {}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.Dictionary<string, string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBillingEventsResponseBillingEvent" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the request
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier that was used (e.g., 'fal-ai/flux/dev')
        /// </param>
        /// <param name="timestamp">
        /// Request timestamp in ISO8601 format
        /// </param>
        /// <param name="costSubtotal">
        /// Cost before discounts in USD (output_units × unit_price)
        /// </param>
        /// <param name="costDiscount">
        /// Discount applied to this request in USD (cost_subtotal − cost_total)
        /// </param>
        /// <param name="costTotal">
        /// Amount charged after discounts in USD (cost_subtotal − cost_discount)
        /// </param>
        /// <param name="costEstimateNanoUsd">
        /// Amount charged after discounts in nano USD. The precision-preserving representation of cost_total, not a legacy duplicate: an integer nano-USD amount avoids the float error that accumulates when summing sub-cent charges (1 USD = 1,000,000,000 nano USD).
        /// </param>
        /// <param name="quantity">
        /// Billable units consumed, in the unit named by `unit`. Same value as the deprecated `output_units`.
        /// </param>
        /// <param name="unit">
        /// The billing unit these units are counted in (e.g. 'image', 'second', 'megapixel'). Null when the reporter recorded none.
        /// </param>
        /// <param name="unitPrice">
        /// Per-unit price this line is measured against: the list rate when a discount is reported in percent_discount, otherwise the negotiated rate after any price override and before percentage discounts.
        /// </param>
        /// <param name="percentDiscount">
        /// Discount percentage applied to this request (e.g., 10 = 10% discount)
        /// </param>
        /// <param name="authMethod">
        /// Authentication method label (e.g., 'Key 1', 'API Key', 'User token'). Only populated when 'auth_method' is included in expand parameter.
        /// </param>
        /// <param name="authMethodStructured">
        /// Structured authentication method identity. Only populated when 'auth_method_structured' is included in expand parameter.
        /// </param>
        /// <param name="tags">
        /// Activated X-Fal-Tags key/values set on this request. Only populated when source=tagged-billed; a key the request did not set is omitted, so a request that set none reports {}.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBillingEventsResponseBillingEvent(
            string requestId,
            string endpointId,
            string timestamp,
            double costSubtotal,
            double costDiscount,
            double costTotal,
            double costEstimateNanoUsd,
            double? quantity,
            string? unit,
            double? unitPrice,
            double? percentDiscount,
            string? authMethod,
            global::Fal.GetBillingEventsResponseBillingEventAuthMethodStructured? authMethodStructured,
            global::System.Collections.Generic.Dictionary<string, string>? tags)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Quantity = quantity;
            this.Unit = unit;
            this.UnitPrice = unitPrice;
            this.PercentDiscount = percentDiscount;
            this.CostSubtotal = costSubtotal;
            this.CostDiscount = costDiscount;
            this.CostTotal = costTotal;
            this.CostEstimateNanoUsd = costEstimateNanoUsd;
            this.AuthMethod = authMethod;
            this.AuthMethodStructured = authMethodStructured;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBillingEventsResponseBillingEvent" /> class.
        /// </summary>
        public GetBillingEventsResponseBillingEvent()
        {
        }

    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Fal
{
    /// <summary>
    /// Aggregate usage statistics for the entire date range
    /// </summary>
    public sealed partial class ServerlessGetUsageResponseSummaryItem
    {
        /// <summary>
        /// Deployed serverless app name (the billing owner prefix is stripped, e.g. 'autohdr-raw-to-jpg-dev'). May include an environment/version suffix. Null for line items without an app attribution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public string? App { get; set; }

        /// <summary>
        /// Deployment environment of the app (e.g., 'production') when present on the billing line item, null otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Machine type the usage ran on (e.g., 'GPU-H100', 'L')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machine_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MachineType { get; set; }

        /// <summary>
        /// The billing unit — always 'second' (machine-seconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Unit { get; set; }

        /// <summary>
        /// Quantity of usage in the specified billing unit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Quantity { get; set; }

        /// <summary>
        /// Per-second price for this machine type before percentage discounts, including any customer-specific machine pricing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UnitPrice { get; set; }

        /// <summary>
        /// Percentage discount applied to this line item (e.g., 20 = 20% discount). Null when no percentage discount applies. Usage billed at different discount rates appears as separate rows, like unit_price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent_discount")]
        public double? PercentDiscount { get; set; }

        /// <summary>
        /// Cost before discounts (quantity × unit_price)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_subtotal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CostSubtotal { get; set; }

        /// <summary>
        /// Discount applied to this line item (cost_subtotal − cost_total)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_discount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CostDiscount { get; set; }

        /// <summary>
        /// Amount charged after discounts (cost_subtotal − cost_discount)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CostTotal { get; set; }

        /// <summary>
        /// Deprecated: use cost_total. Same value as cost_total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cost { get; set; }

        /// <summary>
        /// Three-letter currency code (ISO 4217, e.g., 'USD')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        /// Whether this usage was billed at surge pricing. Surge and non-surge usage of the same machine type appear as separate rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_surge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsSurge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessGetUsageResponseSummaryItem" /> class.
        /// </summary>
        /// <param name="machineType">
        /// Machine type the usage ran on (e.g., 'GPU-H100', 'L')
        /// </param>
        /// <param name="unit">
        /// The billing unit — always 'second' (machine-seconds)
        /// </param>
        /// <param name="quantity">
        /// Quantity of usage in the specified billing unit
        /// </param>
        /// <param name="unitPrice">
        /// Per-second price for this machine type before percentage discounts, including any customer-specific machine pricing
        /// </param>
        /// <param name="costSubtotal">
        /// Cost before discounts (quantity × unit_price)
        /// </param>
        /// <param name="costDiscount">
        /// Discount applied to this line item (cost_subtotal − cost_total)
        /// </param>
        /// <param name="costTotal">
        /// Amount charged after discounts (cost_subtotal − cost_discount)
        /// </param>
        /// <param name="cost">
        /// Deprecated: use cost_total. Same value as cost_total.
        /// </param>
        /// <param name="currency">
        /// Three-letter currency code (ISO 4217, e.g., 'USD')
        /// </param>
        /// <param name="isSurge">
        /// Whether this usage was billed at surge pricing. Surge and non-surge usage of the same machine type appear as separate rows.
        /// </param>
        /// <param name="app">
        /// Deployed serverless app name (the billing owner prefix is stripped, e.g. 'autohdr-raw-to-jpg-dev'). May include an environment/version suffix. Null for line items without an app attribution.
        /// </param>
        /// <param name="environment">
        /// Deployment environment of the app (e.g., 'production') when present on the billing line item, null otherwise.
        /// </param>
        /// <param name="percentDiscount">
        /// Percentage discount applied to this line item (e.g., 20 = 20% discount). Null when no percentage discount applies. Usage billed at different discount rates appears as separate rows, like unit_price.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerlessGetUsageResponseSummaryItem(
            string machineType,
            string unit,
            double quantity,
            double unitPrice,
            double costSubtotal,
            double costDiscount,
            double costTotal,
            double cost,
            string currency,
            bool isSurge,
            string? app,
            string? environment,
            double? percentDiscount)
        {
            this.App = app;
            this.Environment = environment;
            this.MachineType = machineType ?? throw new global::System.ArgumentNullException(nameof(machineType));
            this.Unit = unit ?? throw new global::System.ArgumentNullException(nameof(unit));
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.PercentDiscount = percentDiscount;
            this.CostSubtotal = costSubtotal;
            this.CostDiscount = costDiscount;
            this.CostTotal = costTotal;
            this.Cost = cost;
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
            this.IsSurge = isSurge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessGetUsageResponseSummaryItem" /> class.
        /// </summary>
        public ServerlessGetUsageResponseSummaryItem()
        {
        }

    }
}
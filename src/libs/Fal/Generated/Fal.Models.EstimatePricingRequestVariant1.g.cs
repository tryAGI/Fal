
#nullable enable

namespace Fal
{
    /// <summary>
    /// Request-based estimate: prices each request from its input, as its endpoint would bill it.
    /// </summary>
    public sealed partial class EstimatePricingRequestVariant1
    {
        /// <summary>
        /// The requests to price, 1 to 20. Each is priced on its own: one that can't be priced never fails the others.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.EstimatePricingRequestVariant1Item> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingRequestVariant1" /> class.
        /// </summary>
        /// <param name="items">
        /// The requests to price, 1 to 20. Each is priced on its own: one that can't be priced never fails the others.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimatePricingRequestVariant1(
            global::System.Collections.Generic.IList<global::Fal.EstimatePricingRequestVariant1Item> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingRequestVariant1" /> class.
        /// </summary>
        public EstimatePricingRequestVariant1()
        {
        }

    }
}
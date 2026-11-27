
#nullable enable

namespace Fal
{
    /// <summary>
    /// The unit the rate is per; null when unknown.
    /// </summary>
    public sealed partial class EstimatePricingResponseVariant1ItemPerRequestComponentBillingUnit
    {
        /// <summary>
        /// 'unit', or 'block' for a unit of several.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// The unit's name, e.g. 'character'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// For a block unit, how many of the quantity's units it holds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingResponseVariant1ItemPerRequestComponentBillingUnit" /> class.
        /// </summary>
        /// <param name="kind">
        /// 'unit', or 'block' for a unit of several.
        /// </param>
        /// <param name="name">
        /// The unit's name, e.g. 'character'.
        /// </param>
        /// <param name="size">
        /// For a block unit, how many of the quantity's units it holds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimatePricingResponseVariant1ItemPerRequestComponentBillingUnit(
            string kind,
            string name,
            string? size)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingResponseVariant1ItemPerRequestComponentBillingUnit" /> class.
        /// </summary>
        public EstimatePricingResponseVariant1ItemPerRequestComponentBillingUnit()
        {
        }

    }
}
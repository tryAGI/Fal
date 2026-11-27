
#nullable enable

namespace Fal
{
    /// <summary>
    /// Estimate type: unit price calculation based on billing units
    /// </summary>
    public enum EstimatePricingRequestVariant3EstimateType
    {
        /// <summary>
        ///
        /// </summary>
        UnitPrice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimatePricingRequestVariant3EstimateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingRequestVariant3EstimateType value)
        {
            return value switch
            {
                EstimatePricingRequestVariant3EstimateType.UnitPrice => "unit_price",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingRequestVariant3EstimateType? ToEnum(string value)
        {
            return value switch
            {
                "unit_price" => EstimatePricingRequestVariant3EstimateType.UnitPrice,
                _ => null,
            };
        }
    }
}
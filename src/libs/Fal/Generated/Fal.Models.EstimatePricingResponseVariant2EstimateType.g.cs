
#nullable enable

namespace Fal
{
    /// <summary>
    /// The type of estimate that was performed
    /// </summary>
    public enum EstimatePricingResponseVariant2EstimateType
    {
        /// <summary>
        ///
        /// </summary>
        HistoricalApiPrice,
        /// <summary>
        ///
        /// </summary>
        UnitPrice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimatePricingResponseVariant2EstimateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingResponseVariant2EstimateType value)
        {
            return value switch
            {
                EstimatePricingResponseVariant2EstimateType.HistoricalApiPrice => "historical_api_price",
                EstimatePricingResponseVariant2EstimateType.UnitPrice => "unit_price",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingResponseVariant2EstimateType? ToEnum(string value)
        {
            return value switch
            {
                "historical_api_price" => EstimatePricingResponseVariant2EstimateType.HistoricalApiPrice,
                "unit_price" => EstimatePricingResponseVariant2EstimateType.UnitPrice,
                _ => null,
            };
        }
    }
}
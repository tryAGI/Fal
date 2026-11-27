
#nullable enable

namespace Fal
{
    /// <summary>
    /// Estimate type: historical API pricing based on past usage patterns
    /// </summary>
    public enum EstimatePricingRequestVariant2EstimateType
    {
        /// <summary>
        ///
        /// </summary>
        HistoricalApiPrice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimatePricingRequestVariant2EstimateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingRequestVariant2EstimateType value)
        {
            return value switch
            {
                EstimatePricingRequestVariant2EstimateType.HistoricalApiPrice => "historical_api_price",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingRequestVariant2EstimateType? ToEnum(string value)
        {
            return value switch
            {
                "historical_api_price" => EstimatePricingRequestVariant2EstimateType.HistoricalApiPrice,
                _ => null,
            };
        }
    }
}
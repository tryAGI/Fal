
#nullable enable

namespace Fal
{
    /// <summary>
    /// complete: fully priced. partial: something can't be estimated, see warnings. unavailable: no quote, see error.
    /// </summary>
    public enum EstimatePricingResponseVariant1ItemStatus
    {
        /// <summary>
        /// fully priced. partial: something can't be estimated, see warnings. unavailable: no quote, see error.
        /// </summary>
        Complete,
        /// <summary>
        /// fully priced. partial: something can't be estimated, see warnings. unavailable: no quote, see error.
        /// </summary>
        Partial,
        /// <summary>
        /// fully priced. partial: something can't be estimated, see warnings. unavailable: no quote, see error.
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimatePricingResponseVariant1ItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingResponseVariant1ItemStatus value)
        {
            return value switch
            {
                EstimatePricingResponseVariant1ItemStatus.Complete => "complete",
                EstimatePricingResponseVariant1ItemStatus.Partial => "partial",
                EstimatePricingResponseVariant1ItemStatus.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingResponseVariant1ItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => EstimatePricingResponseVariant1ItemStatus.Complete,
                "partial" => EstimatePricingResponseVariant1ItemStatus.Partial,
                "unavailable" => EstimatePricingResponseVariant1ItemStatus.Unavailable,
                _ => null,
            };
        }
    }
}
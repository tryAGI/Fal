
#nullable enable

namespace Fal
{
    /// <summary>
    /// The confidence of the parts that are known.
    /// </summary>
    public enum EstimatePricingResponseVariant1ItemPerRequestKnownConfidence
    {
        /// <summary>
        ///
        /// </summary>
        Exact,
        /// <summary>
        ///
        /// </summary>
        Statistical,
        /// <summary>
        ///
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimatePricingResponseVariant1ItemPerRequestKnownConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingResponseVariant1ItemPerRequestKnownConfidence value)
        {
            return value switch
            {
                EstimatePricingResponseVariant1ItemPerRequestKnownConfidence.Exact => "exact",
                EstimatePricingResponseVariant1ItemPerRequestKnownConfidence.Statistical => "statistical",
                EstimatePricingResponseVariant1ItemPerRequestKnownConfidence.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingResponseVariant1ItemPerRequestKnownConfidence? ToEnum(string value)
        {
            return value switch
            {
                "exact" => EstimatePricingResponseVariant1ItemPerRequestKnownConfidence.Exact,
                "statistical" => EstimatePricingResponseVariant1ItemPerRequestKnownConfidence.Statistical,
                "unavailable" => EstimatePricingResponseVariant1ItemPerRequestKnownConfidence.Unavailable,
                _ => null,
            };
        }
    }
}
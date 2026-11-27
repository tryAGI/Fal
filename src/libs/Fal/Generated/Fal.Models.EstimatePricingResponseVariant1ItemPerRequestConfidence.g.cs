
#nullable enable

namespace Fal
{
    /// <summary>
    /// exact: decided by the input. statistical: predicted, the run may differ. unavailable: can't be known before the run.
    /// </summary>
    public enum EstimatePricingResponseVariant1ItemPerRequestConfidence
    {
        /// <summary>
        /// decided by the input. statistical: predicted, the run may differ. unavailable: can't be known before the run.
        /// </summary>
        Exact,
        /// <summary>
        /// decided by the input. statistical: predicted, the run may differ. unavailable: can't be known before the run.
        /// </summary>
        Statistical,
        /// <summary>
        /// decided by the input. statistical: predicted, the run may differ. unavailable: can't be known before the run.
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimatePricingResponseVariant1ItemPerRequestConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingResponseVariant1ItemPerRequestConfidence value)
        {
            return value switch
            {
                EstimatePricingResponseVariant1ItemPerRequestConfidence.Exact => "exact",
                EstimatePricingResponseVariant1ItemPerRequestConfidence.Statistical => "statistical",
                EstimatePricingResponseVariant1ItemPerRequestConfidence.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingResponseVariant1ItemPerRequestConfidence? ToEnum(string value)
        {
            return value switch
            {
                "exact" => EstimatePricingResponseVariant1ItemPerRequestConfidence.Exact,
                "statistical" => EstimatePricingResponseVariant1ItemPerRequestConfidence.Statistical,
                "unavailable" => EstimatePricingResponseVariant1ItemPerRequestConfidence.Unavailable,
                _ => null,
            };
        }
    }
}
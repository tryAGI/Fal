
#nullable enable

namespace Fal
{
    /// <summary>
    /// exact: decided by the input. statistical: predicted, the run may differ. unavailable: can't be known before the run.
    /// </summary>
    public enum EstimatePricingResponseVariant1ItemPerRequestComponentConfidence
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
    public static class EstimatePricingResponseVariant1ItemPerRequestComponentConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingResponseVariant1ItemPerRequestComponentConfidence value)
        {
            return value switch
            {
                EstimatePricingResponseVariant1ItemPerRequestComponentConfidence.Exact => "exact",
                EstimatePricingResponseVariant1ItemPerRequestComponentConfidence.Statistical => "statistical",
                EstimatePricingResponseVariant1ItemPerRequestComponentConfidence.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingResponseVariant1ItemPerRequestComponentConfidence? ToEnum(string value)
        {
            return value switch
            {
                "exact" => EstimatePricingResponseVariant1ItemPerRequestComponentConfidence.Exact,
                "statistical" => EstimatePricingResponseVariant1ItemPerRequestComponentConfidence.Statistical,
                "unavailable" => EstimatePricingResponseVariant1ItemPerRequestComponentConfidence.Unavailable,
                _ => null,
            };
        }
    }
}
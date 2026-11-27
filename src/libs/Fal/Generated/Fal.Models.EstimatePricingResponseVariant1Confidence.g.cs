
#nullable enable

namespace Fal
{
    /// <summary>
    /// exact: decided by the input. statistical: predicted, the run may differ. unavailable: can't be known before the run.
    /// </summary>
    public enum EstimatePricingResponseVariant1Confidence
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
    public static class EstimatePricingResponseVariant1ConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingResponseVariant1Confidence value)
        {
            return value switch
            {
                EstimatePricingResponseVariant1Confidence.Exact => "exact",
                EstimatePricingResponseVariant1Confidence.Statistical => "statistical",
                EstimatePricingResponseVariant1Confidence.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingResponseVariant1Confidence? ToEnum(string value)
        {
            return value switch
            {
                "exact" => EstimatePricingResponseVariant1Confidence.Exact,
                "statistical" => EstimatePricingResponseVariant1Confidence.Statistical,
                "unavailable" => EstimatePricingResponseVariant1Confidence.Unavailable,
                _ => null,
            };
        }
    }
}
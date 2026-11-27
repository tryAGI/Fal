
#nullable enable

namespace Fal
{
    /// <summary>
    /// complete only if every item is.
    /// </summary>
    public enum EstimatePricingResponseVariant1Status
    {
        /// <summary>
        ///
        /// </summary>
        Complete,
        /// <summary>
        ///
        /// </summary>
        Partial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EstimatePricingResponseVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingResponseVariant1Status value)
        {
            return value switch
            {
                EstimatePricingResponseVariant1Status.Complete => "complete",
                EstimatePricingResponseVariant1Status.Partial => "partial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingResponseVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "complete" => EstimatePricingResponseVariant1Status.Complete,
                "partial" => EstimatePricingResponseVariant1Status.Partial,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// Data source. 'estimate' is the default usage estimate. 'tagged-estimate' reads the tagged aggregate instead, populating each row's 'tags' and enabling the 'tag' filter; it requires tagged reporting to be enabled for the account, and recent usage is delayed relative to 'estimate'.<br/>
    /// Default Value: estimate<br/>
    /// Example: estimate
    /// </summary>
    public enum GetUsageSource
    {
        /// <summary>
        ///
        /// </summary>
        Estimate,
        /// <summary>
        ///
        /// </summary>
        TaggedEstimate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUsageSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsageSource value)
        {
            return value switch
            {
                GetUsageSource.Estimate => "estimate",
                GetUsageSource.TaggedEstimate => "tagged-estimate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsageSource? ToEnum(string value)
        {
            return value switch
            {
                "estimate" => GetUsageSource.Estimate,
                "tagged-estimate" => GetUsageSource.TaggedEstimate,
                _ => null,
            };
        }
    }
}
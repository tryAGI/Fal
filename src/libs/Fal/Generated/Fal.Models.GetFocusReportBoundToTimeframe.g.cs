
#nullable enable

namespace Fal
{
    /// <summary>
    /// Whether to adjust start/end dates to align with timeframe boundaries and use exclusive end. Defaults to true. When true, dates are aligned to the start of the timeframe period (e.g., start of day) and end is made exclusive (e.g., start of next day). When false, uses exact dates provided.<br/>
    /// Default Value: true<br/>
    /// Example: true
    /// </summary>
    public enum GetFocusReportBoundToTimeframe
    {
        /// <summary>
        /// 
        /// </summary>
        True,
        /// <summary>
        /// 
        /// </summary>
        False,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFocusReportBoundToTimeframeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFocusReportBoundToTimeframe value)
        {
            return value switch
            {
                GetFocusReportBoundToTimeframe.True => "true",
                GetFocusReportBoundToTimeframe.False => "false",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFocusReportBoundToTimeframe? ToEnum(string value)
        {
            return value switch
            {
                "true" => GetFocusReportBoundToTimeframe.True,
                "false" => GetFocusReportBoundToTimeframe.False,
                _ => null,
            };
        }
    }
}
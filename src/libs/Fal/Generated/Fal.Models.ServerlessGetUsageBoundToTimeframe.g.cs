
#nullable enable

namespace Fal
{
    /// <summary>
    /// Whether to adjust start/end dates to align with timeframe boundaries and use exclusive end. Defaults to true. When true, dates are aligned to the start of the timeframe period (e.g., start of day) and end is made exclusive (e.g., start of next day). When false, uses exact dates provided.<br/>
    /// Default Value: true<br/>
    /// Example: true
    /// </summary>
    public enum ServerlessGetUsageBoundToTimeframe
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessGetUsageBoundToTimeframeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetUsageBoundToTimeframe value)
        {
            return value switch
            {
                ServerlessGetUsageBoundToTimeframe.False => "false",
                ServerlessGetUsageBoundToTimeframe.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetUsageBoundToTimeframe? ToEnum(string value)
        {
            return value switch
            {
                "false" => ServerlessGetUsageBoundToTimeframe.False,
                "true" => ServerlessGetUsageBoundToTimeframe.True,
                _ => null,
            };
        }
    }
}
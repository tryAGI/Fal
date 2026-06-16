
#nullable enable

namespace Fal
{
    /// <summary>
    /// Aggregation timeframe for timeseries data (auto-detected from date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
    /// Example: day
    /// </summary>
    public enum ServerlessGetUsageTimeframe
    {
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        Day,
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        Hour,
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        Minute,
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        Month,
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        Week,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessGetUsageTimeframeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetUsageTimeframe value)
        {
            return value switch
            {
                ServerlessGetUsageTimeframe.Day => "day",
                ServerlessGetUsageTimeframe.Hour => "hour",
                ServerlessGetUsageTimeframe.Minute => "minute",
                ServerlessGetUsageTimeframe.Month => "month",
                ServerlessGetUsageTimeframe.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetUsageTimeframe? ToEnum(string value)
        {
            return value switch
            {
                "day" => ServerlessGetUsageTimeframe.Day,
                "hour" => ServerlessGetUsageTimeframe.Hour,
                "minute" => ServerlessGetUsageTimeframe.Minute,
                "month" => ServerlessGetUsageTimeframe.Month,
                "week" => ServerlessGetUsageTimeframe.Week,
                _ => null,
            };
        }
    }
}
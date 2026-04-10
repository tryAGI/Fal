
#nullable enable

namespace Fal
{
    /// <summary>
    /// Aggregation timeframe for timeseries data (auto-detected from date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
    /// Example: day
    /// </summary>
    public enum ServerlessGetAnalyticsTimeframe
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
    public static class ServerlessGetAnalyticsTimeframeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetAnalyticsTimeframe value)
        {
            return value switch
            {
                ServerlessGetAnalyticsTimeframe.Day => "day",
                ServerlessGetAnalyticsTimeframe.Hour => "hour",
                ServerlessGetAnalyticsTimeframe.Minute => "minute",
                ServerlessGetAnalyticsTimeframe.Month => "month",
                ServerlessGetAnalyticsTimeframe.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetAnalyticsTimeframe? ToEnum(string value)
        {
            return value switch
            {
                "day" => ServerlessGetAnalyticsTimeframe.Day,
                "hour" => ServerlessGetAnalyticsTimeframe.Hour,
                "minute" => ServerlessGetAnalyticsTimeframe.Minute,
                "month" => ServerlessGetAnalyticsTimeframe.Month,
                "week" => ServerlessGetAnalyticsTimeframe.Week,
                _ => null,
            };
        }
    }
}
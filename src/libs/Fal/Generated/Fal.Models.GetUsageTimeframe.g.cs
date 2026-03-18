
#nullable enable

namespace Fal
{
    /// <summary>
    /// Aggregation timeframe for timeseries data (auto-detected from date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
    /// Example: day
    /// </summary>
    public enum GetUsageTimeframe
    {
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        Minute,
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        Hour,
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        Day,
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        Week,
        /// <summary>
        /// minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).
        /// </summary>
        Month,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUsageTimeframeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsageTimeframe value)
        {
            return value switch
            {
                GetUsageTimeframe.Minute => "minute",
                GetUsageTimeframe.Hour => "hour",
                GetUsageTimeframe.Day => "day",
                GetUsageTimeframe.Week => "week",
                GetUsageTimeframe.Month => "month",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsageTimeframe? ToEnum(string value)
        {
            return value switch
            {
                "minute" => GetUsageTimeframe.Minute,
                "hour" => GetUsageTimeframe.Hour,
                "day" => GetUsageTimeframe.Day,
                "week" => GetUsageTimeframe.Week,
                "month" => GetUsageTimeframe.Month,
                _ => null,
            };
        }
    }
}
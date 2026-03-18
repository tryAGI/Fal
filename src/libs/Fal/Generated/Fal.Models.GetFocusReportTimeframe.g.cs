
#nullable enable

namespace Fal
{
    /// <summary>
    /// Aggregation timeframe for timeseries data (auto-detected from date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
    /// Example: day
    /// </summary>
    public enum GetFocusReportTimeframe
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
    public static class GetFocusReportTimeframeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFocusReportTimeframe value)
        {
            return value switch
            {
                GetFocusReportTimeframe.Minute => "minute",
                GetFocusReportTimeframe.Hour => "hour",
                GetFocusReportTimeframe.Day => "day",
                GetFocusReportTimeframe.Week => "week",
                GetFocusReportTimeframe.Month => "month",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFocusReportTimeframe? ToEnum(string value)
        {
            return value switch
            {
                "minute" => GetFocusReportTimeframe.Minute,
                "hour" => GetFocusReportTimeframe.Hour,
                "day" => GetFocusReportTimeframe.Day,
                "week" => GetFocusReportTimeframe.Week,
                "month" => GetFocusReportTimeframe.Month,
                _ => null,
            };
        }
    }
}
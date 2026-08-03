
#nullable enable

namespace Fal
{
    /// <summary>
    /// Aggregation timeframe for timeseries data (auto-detected from date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
    /// Example: day
    /// </summary>
    public enum GetOrganizationFocusReportTimeframe
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
    public static class GetOrganizationFocusReportTimeframeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationFocusReportTimeframe value)
        {
            return value switch
            {
                GetOrganizationFocusReportTimeframe.Day => "day",
                GetOrganizationFocusReportTimeframe.Hour => "hour",
                GetOrganizationFocusReportTimeframe.Minute => "minute",
                GetOrganizationFocusReportTimeframe.Month => "month",
                GetOrganizationFocusReportTimeframe.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationFocusReportTimeframe? ToEnum(string value)
        {
            return value switch
            {
                "day" => GetOrganizationFocusReportTimeframe.Day,
                "hour" => GetOrganizationFocusReportTimeframe.Hour,
                "minute" => GetOrganizationFocusReportTimeframe.Minute,
                "month" => GetOrganizationFocusReportTimeframe.Month,
                "week" => GetOrganizationFocusReportTimeframe.Week,
                _ => null,
            };
        }
    }
}
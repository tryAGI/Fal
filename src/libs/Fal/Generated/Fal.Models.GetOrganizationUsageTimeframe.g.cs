
#nullable enable

namespace Fal
{
    /// <summary>
    /// Aggregation timeframe for timeseries data (auto-detected from date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
    /// Example: day
    /// </summary>
    public enum GetOrganizationUsageTimeframe
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
    public static class GetOrganizationUsageTimeframeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationUsageTimeframe value)
        {
            return value switch
            {
                GetOrganizationUsageTimeframe.Day => "day",
                GetOrganizationUsageTimeframe.Hour => "hour",
                GetOrganizationUsageTimeframe.Minute => "minute",
                GetOrganizationUsageTimeframe.Month => "month",
                GetOrganizationUsageTimeframe.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationUsageTimeframe? ToEnum(string value)
        {
            return value switch
            {
                "day" => GetOrganizationUsageTimeframe.Day,
                "hour" => GetOrganizationUsageTimeframe.Hour,
                "minute" => GetOrganizationUsageTimeframe.Minute,
                "month" => GetOrganizationUsageTimeframe.Month,
                "week" => GetOrganizationUsageTimeframe.Week,
                _ => null,
            };
        }
    }
}
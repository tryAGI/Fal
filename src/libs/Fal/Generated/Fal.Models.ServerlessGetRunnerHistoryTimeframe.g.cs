
#nullable enable

namespace Fal
{
    /// <summary>
    /// Bucket size for the time series (auto-detected from the date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
    /// Example: day
    /// </summary>
    public enum ServerlessGetRunnerHistoryTimeframe
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
    public static class ServerlessGetRunnerHistoryTimeframeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetRunnerHistoryTimeframe value)
        {
            return value switch
            {
                ServerlessGetRunnerHistoryTimeframe.Day => "day",
                ServerlessGetRunnerHistoryTimeframe.Hour => "hour",
                ServerlessGetRunnerHistoryTimeframe.Minute => "minute",
                ServerlessGetRunnerHistoryTimeframe.Month => "month",
                ServerlessGetRunnerHistoryTimeframe.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetRunnerHistoryTimeframe? ToEnum(string value)
        {
            return value switch
            {
                "day" => ServerlessGetRunnerHistoryTimeframe.Day,
                "hour" => ServerlessGetRunnerHistoryTimeframe.Hour,
                "minute" => ServerlessGetRunnerHistoryTimeframe.Minute,
                "month" => ServerlessGetRunnerHistoryTimeframe.Month,
                "week" => ServerlessGetRunnerHistoryTimeframe.Week,
                _ => null,
            };
        }
    }
}
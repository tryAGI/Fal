
#nullable enable

namespace Fal
{
    /// <summary>
    /// Bucket size used for the series (resolved if auto-detected)<br/>
    /// Example: day
    /// </summary>
    public enum ServerlessGetRunnerHistoryResponseTimeframe
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Hour,
        /// <summary>
        /// 
        /// </summary>
        Minute,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        Week,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessGetRunnerHistoryResponseTimeframeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetRunnerHistoryResponseTimeframe value)
        {
            return value switch
            {
                ServerlessGetRunnerHistoryResponseTimeframe.Day => "day",
                ServerlessGetRunnerHistoryResponseTimeframe.Hour => "hour",
                ServerlessGetRunnerHistoryResponseTimeframe.Minute => "minute",
                ServerlessGetRunnerHistoryResponseTimeframe.Month => "month",
                ServerlessGetRunnerHistoryResponseTimeframe.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetRunnerHistoryResponseTimeframe? ToEnum(string value)
        {
            return value switch
            {
                "day" => ServerlessGetRunnerHistoryResponseTimeframe.Day,
                "hour" => ServerlessGetRunnerHistoryResponseTimeframe.Hour,
                "minute" => ServerlessGetRunnerHistoryResponseTimeframe.Minute,
                "month" => ServerlessGetRunnerHistoryResponseTimeframe.Month,
                "week" => ServerlessGetRunnerHistoryResponseTimeframe.Week,
                _ => null,
            };
        }
    }
}
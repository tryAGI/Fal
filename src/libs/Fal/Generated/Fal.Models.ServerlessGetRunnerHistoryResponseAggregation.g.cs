
#nullable enable

namespace Fal
{
    /// <summary>
    /// Aggregation applied within each bucket<br/>
    /// Example: max
    /// </summary>
    public enum ServerlessGetRunnerHistoryResponseAggregation
    {
        /// <summary>
        /// 
        /// </summary>
        Avg,
        /// <summary>
        /// 
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessGetRunnerHistoryResponseAggregationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetRunnerHistoryResponseAggregation value)
        {
            return value switch
            {
                ServerlessGetRunnerHistoryResponseAggregation.Avg => "avg",
                ServerlessGetRunnerHistoryResponseAggregation.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetRunnerHistoryResponseAggregation? ToEnum(string value)
        {
            return value switch
            {
                "avg" => ServerlessGetRunnerHistoryResponseAggregation.Avg,
                "max" => ServerlessGetRunnerHistoryResponseAggregation.Max,
                _ => null,
            };
        }
    }
}
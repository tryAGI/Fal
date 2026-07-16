
#nullable enable

namespace Fal
{
    /// <summary>
    /// How runner counts are aggregated within each bucket: 'max' shows peak concurrency (capacity analysis), 'avg' shows mean concurrency (utilization analysis).<br/>
    /// Default Value: max<br/>
    /// Example: max
    /// </summary>
    public enum ServerlessGetRunnerHistoryAggregation
    {
        /// <summary>
        /// 'max' shows peak concurrency (capacity analysis), 'avg' shows mean concurrency (utilization analysis).
        /// </summary>
        Avg,
        /// <summary>
        /// 'max' shows peak concurrency (capacity analysis), 'avg' shows mean concurrency (utilization analysis).
        /// </summary>
        Max,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessGetRunnerHistoryAggregationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetRunnerHistoryAggregation value)
        {
            return value switch
            {
                ServerlessGetRunnerHistoryAggregation.Avg => "avg",
                ServerlessGetRunnerHistoryAggregation.Max => "max",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetRunnerHistoryAggregation? ToEnum(string value)
        {
            return value switch
            {
                "avg" => ServerlessGetRunnerHistoryAggregation.Avg,
                "max" => ServerlessGetRunnerHistoryAggregation.Max,
                _ => null,
            };
        }
    }
}
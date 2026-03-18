
#nullable enable

namespace Fal
{
    /// <summary>
    /// Filter by run source<br/>
    /// Example: grpc-run
    /// </summary>
    public enum ServerlessLogsHistoryRunSource
    {
        /// <summary>
        /// 
        /// </summary>
        GrpcRun,
        /// <summary>
        /// 
        /// </summary>
        GrpcRegister,
        /// <summary>
        /// 
        /// </summary>
        Gateway,
        /// <summary>
        /// 
        /// </summary>
        Cron,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessLogsHistoryRunSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessLogsHistoryRunSource value)
        {
            return value switch
            {
                ServerlessLogsHistoryRunSource.GrpcRun => "grpc-run",
                ServerlessLogsHistoryRunSource.GrpcRegister => "grpc-register",
                ServerlessLogsHistoryRunSource.Gateway => "gateway",
                ServerlessLogsHistoryRunSource.Cron => "cron",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessLogsHistoryRunSource? ToEnum(string value)
        {
            return value switch
            {
                "grpc-run" => ServerlessLogsHistoryRunSource.GrpcRun,
                "grpc-register" => ServerlessLogsHistoryRunSource.GrpcRegister,
                "gateway" => ServerlessLogsHistoryRunSource.Gateway,
                "cron" => ServerlessLogsHistoryRunSource.Cron,
                _ => null,
            };
        }
    }
}
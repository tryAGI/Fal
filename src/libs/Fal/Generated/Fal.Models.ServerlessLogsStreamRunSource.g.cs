
#nullable enable

namespace Fal
{
    /// <summary>
    /// Filter by run source<br/>
    /// Example: grpc-run
    /// </summary>
    public enum ServerlessLogsStreamRunSource
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
    public static class ServerlessLogsStreamRunSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessLogsStreamRunSource value)
        {
            return value switch
            {
                ServerlessLogsStreamRunSource.GrpcRun => "grpc-run",
                ServerlessLogsStreamRunSource.GrpcRegister => "grpc-register",
                ServerlessLogsStreamRunSource.Gateway => "gateway",
                ServerlessLogsStreamRunSource.Cron => "cron",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessLogsStreamRunSource? ToEnum(string value)
        {
            return value switch
            {
                "grpc-run" => ServerlessLogsStreamRunSource.GrpcRun,
                "grpc-register" => ServerlessLogsStreamRunSource.GrpcRegister,
                "gateway" => ServerlessLogsStreamRunSource.Gateway,
                "cron" => ServerlessLogsStreamRunSource.Cron,
                _ => null,
            };
        }
    }
}
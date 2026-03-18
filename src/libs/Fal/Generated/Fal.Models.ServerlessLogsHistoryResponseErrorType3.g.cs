
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessLogsHistoryResponseErrorType3
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorizationError,
        /// <summary>
        /// 
        /// </summary>
        ValidationError,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        RateLimited,
        /// <summary>
        /// 
        /// </summary>
        ServerError,
        /// <summary>
        /// 
        /// </summary>
        NotImplemented,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessLogsHistoryResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessLogsHistoryResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessLogsHistoryResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessLogsHistoryResponseErrorType3.ValidationError => "validation_error",
                ServerlessLogsHistoryResponseErrorType3.NotFound => "not_found",
                ServerlessLogsHistoryResponseErrorType3.RateLimited => "rate_limited",
                ServerlessLogsHistoryResponseErrorType3.ServerError => "server_error",
                ServerlessLogsHistoryResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessLogsHistoryResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessLogsHistoryResponseErrorType3.AuthorizationError,
                "validation_error" => ServerlessLogsHistoryResponseErrorType3.ValidationError,
                "not_found" => ServerlessLogsHistoryResponseErrorType3.NotFound,
                "rate_limited" => ServerlessLogsHistoryResponseErrorType3.RateLimited,
                "server_error" => ServerlessLogsHistoryResponseErrorType3.ServerError,
                "not_implemented" => ServerlessLogsHistoryResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}
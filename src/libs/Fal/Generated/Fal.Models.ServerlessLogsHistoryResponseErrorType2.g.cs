
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessLogsHistoryResponseErrorType2
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
    public static class ServerlessLogsHistoryResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessLogsHistoryResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessLogsHistoryResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessLogsHistoryResponseErrorType2.ValidationError => "validation_error",
                ServerlessLogsHistoryResponseErrorType2.NotFound => "not_found",
                ServerlessLogsHistoryResponseErrorType2.RateLimited => "rate_limited",
                ServerlessLogsHistoryResponseErrorType2.ServerError => "server_error",
                ServerlessLogsHistoryResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessLogsHistoryResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessLogsHistoryResponseErrorType2.AuthorizationError,
                "validation_error" => ServerlessLogsHistoryResponseErrorType2.ValidationError,
                "not_found" => ServerlessLogsHistoryResponseErrorType2.NotFound,
                "rate_limited" => ServerlessLogsHistoryResponseErrorType2.RateLimited,
                "server_error" => ServerlessLogsHistoryResponseErrorType2.ServerError,
                "not_implemented" => ServerlessLogsHistoryResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}
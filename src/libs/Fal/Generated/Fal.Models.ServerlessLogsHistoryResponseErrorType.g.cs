
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessLogsHistoryResponseErrorType
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
    public static class ServerlessLogsHistoryResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessLogsHistoryResponseErrorType value)
        {
            return value switch
            {
                ServerlessLogsHistoryResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessLogsHistoryResponseErrorType.ValidationError => "validation_error",
                ServerlessLogsHistoryResponseErrorType.NotFound => "not_found",
                ServerlessLogsHistoryResponseErrorType.RateLimited => "rate_limited",
                ServerlessLogsHistoryResponseErrorType.ServerError => "server_error",
                ServerlessLogsHistoryResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessLogsHistoryResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessLogsHistoryResponseErrorType.AuthorizationError,
                "validation_error" => ServerlessLogsHistoryResponseErrorType.ValidationError,
                "not_found" => ServerlessLogsHistoryResponseErrorType.NotFound,
                "rate_limited" => ServerlessLogsHistoryResponseErrorType.RateLimited,
                "server_error" => ServerlessLogsHistoryResponseErrorType.ServerError,
                "not_implemented" => ServerlessLogsHistoryResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}
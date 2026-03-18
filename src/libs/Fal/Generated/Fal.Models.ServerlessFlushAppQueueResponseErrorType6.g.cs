
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessFlushAppQueueResponseErrorType6
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
    public static class ServerlessFlushAppQueueResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessFlushAppQueueResponseErrorType6 value)
        {
            return value switch
            {
                ServerlessFlushAppQueueResponseErrorType6.AuthorizationError => "authorization_error",
                ServerlessFlushAppQueueResponseErrorType6.ValidationError => "validation_error",
                ServerlessFlushAppQueueResponseErrorType6.NotFound => "not_found",
                ServerlessFlushAppQueueResponseErrorType6.RateLimited => "rate_limited",
                ServerlessFlushAppQueueResponseErrorType6.ServerError => "server_error",
                ServerlessFlushAppQueueResponseErrorType6.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessFlushAppQueueResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessFlushAppQueueResponseErrorType6.AuthorizationError,
                "validation_error" => ServerlessFlushAppQueueResponseErrorType6.ValidationError,
                "not_found" => ServerlessFlushAppQueueResponseErrorType6.NotFound,
                "rate_limited" => ServerlessFlushAppQueueResponseErrorType6.RateLimited,
                "server_error" => ServerlessFlushAppQueueResponseErrorType6.ServerError,
                "not_implemented" => ServerlessFlushAppQueueResponseErrorType6.NotImplemented,
                _ => null,
            };
        }
    }
}
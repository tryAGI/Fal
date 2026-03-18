
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessFlushAppQueueResponseErrorType4
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
    public static class ServerlessFlushAppQueueResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessFlushAppQueueResponseErrorType4 value)
        {
            return value switch
            {
                ServerlessFlushAppQueueResponseErrorType4.AuthorizationError => "authorization_error",
                ServerlessFlushAppQueueResponseErrorType4.ValidationError => "validation_error",
                ServerlessFlushAppQueueResponseErrorType4.NotFound => "not_found",
                ServerlessFlushAppQueueResponseErrorType4.RateLimited => "rate_limited",
                ServerlessFlushAppQueueResponseErrorType4.ServerError => "server_error",
                ServerlessFlushAppQueueResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessFlushAppQueueResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessFlushAppQueueResponseErrorType4.AuthorizationError,
                "validation_error" => ServerlessFlushAppQueueResponseErrorType4.ValidationError,
                "not_found" => ServerlessFlushAppQueueResponseErrorType4.NotFound,
                "rate_limited" => ServerlessFlushAppQueueResponseErrorType4.RateLimited,
                "server_error" => ServerlessFlushAppQueueResponseErrorType4.ServerError,
                "not_implemented" => ServerlessFlushAppQueueResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}
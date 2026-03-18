
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessFlushAppQueueResponseErrorType
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
    public static class ServerlessFlushAppQueueResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessFlushAppQueueResponseErrorType value)
        {
            return value switch
            {
                ServerlessFlushAppQueueResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessFlushAppQueueResponseErrorType.ValidationError => "validation_error",
                ServerlessFlushAppQueueResponseErrorType.NotFound => "not_found",
                ServerlessFlushAppQueueResponseErrorType.RateLimited => "rate_limited",
                ServerlessFlushAppQueueResponseErrorType.ServerError => "server_error",
                ServerlessFlushAppQueueResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessFlushAppQueueResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessFlushAppQueueResponseErrorType.AuthorizationError,
                "validation_error" => ServerlessFlushAppQueueResponseErrorType.ValidationError,
                "not_found" => ServerlessFlushAppQueueResponseErrorType.NotFound,
                "rate_limited" => ServerlessFlushAppQueueResponseErrorType.RateLimited,
                "server_error" => ServerlessFlushAppQueueResponseErrorType.ServerError,
                "not_implemented" => ServerlessFlushAppQueueResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}
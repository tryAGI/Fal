
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessFlushAppQueueResponseErrorType3
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
    public static class ServerlessFlushAppQueueResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessFlushAppQueueResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessFlushAppQueueResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessFlushAppQueueResponseErrorType3.ValidationError => "validation_error",
                ServerlessFlushAppQueueResponseErrorType3.NotFound => "not_found",
                ServerlessFlushAppQueueResponseErrorType3.RateLimited => "rate_limited",
                ServerlessFlushAppQueueResponseErrorType3.ServerError => "server_error",
                ServerlessFlushAppQueueResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessFlushAppQueueResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessFlushAppQueueResponseErrorType3.AuthorizationError,
                "validation_error" => ServerlessFlushAppQueueResponseErrorType3.ValidationError,
                "not_found" => ServerlessFlushAppQueueResponseErrorType3.NotFound,
                "rate_limited" => ServerlessFlushAppQueueResponseErrorType3.RateLimited,
                "server_error" => ServerlessFlushAppQueueResponseErrorType3.ServerError,
                "not_implemented" => ServerlessFlushAppQueueResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}
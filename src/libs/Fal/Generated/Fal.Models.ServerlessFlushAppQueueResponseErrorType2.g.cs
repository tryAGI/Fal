
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessFlushAppQueueResponseErrorType2
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
    public static class ServerlessFlushAppQueueResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessFlushAppQueueResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessFlushAppQueueResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessFlushAppQueueResponseErrorType2.ValidationError => "validation_error",
                ServerlessFlushAppQueueResponseErrorType2.NotFound => "not_found",
                ServerlessFlushAppQueueResponseErrorType2.RateLimited => "rate_limited",
                ServerlessFlushAppQueueResponseErrorType2.ServerError => "server_error",
                ServerlessFlushAppQueueResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessFlushAppQueueResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessFlushAppQueueResponseErrorType2.AuthorizationError,
                "validation_error" => ServerlessFlushAppQueueResponseErrorType2.ValidationError,
                "not_found" => ServerlessFlushAppQueueResponseErrorType2.NotFound,
                "rate_limited" => ServerlessFlushAppQueueResponseErrorType2.RateLimited,
                "server_error" => ServerlessFlushAppQueueResponseErrorType2.ServerError,
                "not_implemented" => ServerlessFlushAppQueueResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}
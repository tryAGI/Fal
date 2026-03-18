
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessLogsStreamResponseErrorType
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
    public static class ServerlessLogsStreamResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessLogsStreamResponseErrorType value)
        {
            return value switch
            {
                ServerlessLogsStreamResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessLogsStreamResponseErrorType.ValidationError => "validation_error",
                ServerlessLogsStreamResponseErrorType.NotFound => "not_found",
                ServerlessLogsStreamResponseErrorType.RateLimited => "rate_limited",
                ServerlessLogsStreamResponseErrorType.ServerError => "server_error",
                ServerlessLogsStreamResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessLogsStreamResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessLogsStreamResponseErrorType.AuthorizationError,
                "validation_error" => ServerlessLogsStreamResponseErrorType.ValidationError,
                "not_found" => ServerlessLogsStreamResponseErrorType.NotFound,
                "rate_limited" => ServerlessLogsStreamResponseErrorType.RateLimited,
                "server_error" => ServerlessLogsStreamResponseErrorType.ServerError,
                "not_implemented" => ServerlessLogsStreamResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}
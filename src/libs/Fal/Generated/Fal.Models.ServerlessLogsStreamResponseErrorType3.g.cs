
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessLogsStreamResponseErrorType3
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
    public static class ServerlessLogsStreamResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessLogsStreamResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessLogsStreamResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessLogsStreamResponseErrorType3.ValidationError => "validation_error",
                ServerlessLogsStreamResponseErrorType3.NotFound => "not_found",
                ServerlessLogsStreamResponseErrorType3.RateLimited => "rate_limited",
                ServerlessLogsStreamResponseErrorType3.ServerError => "server_error",
                ServerlessLogsStreamResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessLogsStreamResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessLogsStreamResponseErrorType3.AuthorizationError,
                "validation_error" => ServerlessLogsStreamResponseErrorType3.ValidationError,
                "not_found" => ServerlessLogsStreamResponseErrorType3.NotFound,
                "rate_limited" => ServerlessLogsStreamResponseErrorType3.RateLimited,
                "server_error" => ServerlessLogsStreamResponseErrorType3.ServerError,
                "not_implemented" => ServerlessLogsStreamResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}
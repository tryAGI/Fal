
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListAppEventsResponseErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorizationError,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        NotImplemented,
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
        ValidationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessListAppEventsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppEventsResponseErrorType value)
        {
            return value switch
            {
                ServerlessListAppEventsResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessListAppEventsResponseErrorType.NotFound => "not_found",
                ServerlessListAppEventsResponseErrorType.NotImplemented => "not_implemented",
                ServerlessListAppEventsResponseErrorType.RateLimited => "rate_limited",
                ServerlessListAppEventsResponseErrorType.ServerError => "server_error",
                ServerlessListAppEventsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppEventsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListAppEventsResponseErrorType.AuthorizationError,
                "not_found" => ServerlessListAppEventsResponseErrorType.NotFound,
                "not_implemented" => ServerlessListAppEventsResponseErrorType.NotImplemented,
                "rate_limited" => ServerlessListAppEventsResponseErrorType.RateLimited,
                "server_error" => ServerlessListAppEventsResponseErrorType.ServerError,
                "validation_error" => ServerlessListAppEventsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
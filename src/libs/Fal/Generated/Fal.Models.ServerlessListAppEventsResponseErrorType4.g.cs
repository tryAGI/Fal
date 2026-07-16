
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListAppEventsResponseErrorType4
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
    public static class ServerlessListAppEventsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppEventsResponseErrorType4 value)
        {
            return value switch
            {
                ServerlessListAppEventsResponseErrorType4.AuthorizationError => "authorization_error",
                ServerlessListAppEventsResponseErrorType4.NotFound => "not_found",
                ServerlessListAppEventsResponseErrorType4.NotImplemented => "not_implemented",
                ServerlessListAppEventsResponseErrorType4.RateLimited => "rate_limited",
                ServerlessListAppEventsResponseErrorType4.ServerError => "server_error",
                ServerlessListAppEventsResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppEventsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListAppEventsResponseErrorType4.AuthorizationError,
                "not_found" => ServerlessListAppEventsResponseErrorType4.NotFound,
                "not_implemented" => ServerlessListAppEventsResponseErrorType4.NotImplemented,
                "rate_limited" => ServerlessListAppEventsResponseErrorType4.RateLimited,
                "server_error" => ServerlessListAppEventsResponseErrorType4.ServerError,
                "validation_error" => ServerlessListAppEventsResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
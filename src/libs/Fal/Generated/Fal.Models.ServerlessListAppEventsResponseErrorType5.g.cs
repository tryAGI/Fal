
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListAppEventsResponseErrorType5
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
    public static class ServerlessListAppEventsResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppEventsResponseErrorType5 value)
        {
            return value switch
            {
                ServerlessListAppEventsResponseErrorType5.AuthorizationError => "authorization_error",
                ServerlessListAppEventsResponseErrorType5.NotFound => "not_found",
                ServerlessListAppEventsResponseErrorType5.NotImplemented => "not_implemented",
                ServerlessListAppEventsResponseErrorType5.RateLimited => "rate_limited",
                ServerlessListAppEventsResponseErrorType5.ServerError => "server_error",
                ServerlessListAppEventsResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppEventsResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListAppEventsResponseErrorType5.AuthorizationError,
                "not_found" => ServerlessListAppEventsResponseErrorType5.NotFound,
                "not_implemented" => ServerlessListAppEventsResponseErrorType5.NotImplemented,
                "rate_limited" => ServerlessListAppEventsResponseErrorType5.RateLimited,
                "server_error" => ServerlessListAppEventsResponseErrorType5.ServerError,
                "validation_error" => ServerlessListAppEventsResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListAppEventsResponseErrorType3
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
    public static class ServerlessListAppEventsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppEventsResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessListAppEventsResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessListAppEventsResponseErrorType3.NotFound => "not_found",
                ServerlessListAppEventsResponseErrorType3.NotImplemented => "not_implemented",
                ServerlessListAppEventsResponseErrorType3.RateLimited => "rate_limited",
                ServerlessListAppEventsResponseErrorType3.ServerError => "server_error",
                ServerlessListAppEventsResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppEventsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListAppEventsResponseErrorType3.AuthorizationError,
                "not_found" => ServerlessListAppEventsResponseErrorType3.NotFound,
                "not_implemented" => ServerlessListAppEventsResponseErrorType3.NotImplemented,
                "rate_limited" => ServerlessListAppEventsResponseErrorType3.RateLimited,
                "server_error" => ServerlessListAppEventsResponseErrorType3.ServerError,
                "validation_error" => ServerlessListAppEventsResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
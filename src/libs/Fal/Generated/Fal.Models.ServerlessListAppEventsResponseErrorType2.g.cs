
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListAppEventsResponseErrorType2
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
    public static class ServerlessListAppEventsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppEventsResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessListAppEventsResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessListAppEventsResponseErrorType2.NotFound => "not_found",
                ServerlessListAppEventsResponseErrorType2.NotImplemented => "not_implemented",
                ServerlessListAppEventsResponseErrorType2.RateLimited => "rate_limited",
                ServerlessListAppEventsResponseErrorType2.ServerError => "server_error",
                ServerlessListAppEventsResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppEventsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListAppEventsResponseErrorType2.AuthorizationError,
                "not_found" => ServerlessListAppEventsResponseErrorType2.NotFound,
                "not_implemented" => ServerlessListAppEventsResponseErrorType2.NotImplemented,
                "rate_limited" => ServerlessListAppEventsResponseErrorType2.RateLimited,
                "server_error" => ServerlessListAppEventsResponseErrorType2.ServerError,
                "validation_error" => ServerlessListAppEventsResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
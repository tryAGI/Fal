
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListRootResponseErrorType2
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
    public static class ServerlessListRootResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListRootResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessListRootResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessListRootResponseErrorType2.ValidationError => "validation_error",
                ServerlessListRootResponseErrorType2.NotFound => "not_found",
                ServerlessListRootResponseErrorType2.RateLimited => "rate_limited",
                ServerlessListRootResponseErrorType2.ServerError => "server_error",
                ServerlessListRootResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListRootResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListRootResponseErrorType2.AuthorizationError,
                "validation_error" => ServerlessListRootResponseErrorType2.ValidationError,
                "not_found" => ServerlessListRootResponseErrorType2.NotFound,
                "rate_limited" => ServerlessListRootResponseErrorType2.RateLimited,
                "server_error" => ServerlessListRootResponseErrorType2.ServerError,
                "not_implemented" => ServerlessListRootResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}
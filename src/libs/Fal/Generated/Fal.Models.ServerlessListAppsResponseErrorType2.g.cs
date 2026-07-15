
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListAppsResponseErrorType2
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
    public static class ServerlessListAppsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppsResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessListAppsResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessListAppsResponseErrorType2.NotFound => "not_found",
                ServerlessListAppsResponseErrorType2.NotImplemented => "not_implemented",
                ServerlessListAppsResponseErrorType2.RateLimited => "rate_limited",
                ServerlessListAppsResponseErrorType2.ServerError => "server_error",
                ServerlessListAppsResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListAppsResponseErrorType2.AuthorizationError,
                "not_found" => ServerlessListAppsResponseErrorType2.NotFound,
                "not_implemented" => ServerlessListAppsResponseErrorType2.NotImplemented,
                "rate_limited" => ServerlessListAppsResponseErrorType2.RateLimited,
                "server_error" => ServerlessListAppsResponseErrorType2.ServerError,
                "validation_error" => ServerlessListAppsResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
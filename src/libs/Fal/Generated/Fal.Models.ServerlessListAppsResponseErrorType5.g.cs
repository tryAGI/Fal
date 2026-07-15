
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListAppsResponseErrorType5
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
    public static class ServerlessListAppsResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppsResponseErrorType5 value)
        {
            return value switch
            {
                ServerlessListAppsResponseErrorType5.AuthorizationError => "authorization_error",
                ServerlessListAppsResponseErrorType5.NotFound => "not_found",
                ServerlessListAppsResponseErrorType5.NotImplemented => "not_implemented",
                ServerlessListAppsResponseErrorType5.RateLimited => "rate_limited",
                ServerlessListAppsResponseErrorType5.ServerError => "server_error",
                ServerlessListAppsResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppsResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListAppsResponseErrorType5.AuthorizationError,
                "not_found" => ServerlessListAppsResponseErrorType5.NotFound,
                "not_implemented" => ServerlessListAppsResponseErrorType5.NotImplemented,
                "rate_limited" => ServerlessListAppsResponseErrorType5.RateLimited,
                "server_error" => ServerlessListAppsResponseErrorType5.ServerError,
                "validation_error" => ServerlessListAppsResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
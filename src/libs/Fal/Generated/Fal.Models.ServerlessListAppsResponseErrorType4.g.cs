
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListAppsResponseErrorType4
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
    public static class ServerlessListAppsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppsResponseErrorType4 value)
        {
            return value switch
            {
                ServerlessListAppsResponseErrorType4.AuthorizationError => "authorization_error",
                ServerlessListAppsResponseErrorType4.NotFound => "not_found",
                ServerlessListAppsResponseErrorType4.NotImplemented => "not_implemented",
                ServerlessListAppsResponseErrorType4.RateLimited => "rate_limited",
                ServerlessListAppsResponseErrorType4.ServerError => "server_error",
                ServerlessListAppsResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListAppsResponseErrorType4.AuthorizationError,
                "not_found" => ServerlessListAppsResponseErrorType4.NotFound,
                "not_implemented" => ServerlessListAppsResponseErrorType4.NotImplemented,
                "rate_limited" => ServerlessListAppsResponseErrorType4.RateLimited,
                "server_error" => ServerlessListAppsResponseErrorType4.ServerError,
                "validation_error" => ServerlessListAppsResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
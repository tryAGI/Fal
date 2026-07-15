
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListAppsResponseErrorType3
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
    public static class ServerlessListAppsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppsResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessListAppsResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessListAppsResponseErrorType3.NotFound => "not_found",
                ServerlessListAppsResponseErrorType3.NotImplemented => "not_implemented",
                ServerlessListAppsResponseErrorType3.RateLimited => "rate_limited",
                ServerlessListAppsResponseErrorType3.ServerError => "server_error",
                ServerlessListAppsResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListAppsResponseErrorType3.AuthorizationError,
                "not_found" => ServerlessListAppsResponseErrorType3.NotFound,
                "not_implemented" => ServerlessListAppsResponseErrorType3.NotImplemented,
                "rate_limited" => ServerlessListAppsResponseErrorType3.RateLimited,
                "server_error" => ServerlessListAppsResponseErrorType3.ServerError,
                "validation_error" => ServerlessListAppsResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
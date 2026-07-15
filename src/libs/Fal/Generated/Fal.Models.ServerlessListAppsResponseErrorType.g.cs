
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListAppsResponseErrorType
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
    public static class ServerlessListAppsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppsResponseErrorType value)
        {
            return value switch
            {
                ServerlessListAppsResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessListAppsResponseErrorType.NotFound => "not_found",
                ServerlessListAppsResponseErrorType.NotImplemented => "not_implemented",
                ServerlessListAppsResponseErrorType.RateLimited => "rate_limited",
                ServerlessListAppsResponseErrorType.ServerError => "server_error",
                ServerlessListAppsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListAppsResponseErrorType.AuthorizationError,
                "not_found" => ServerlessListAppsResponseErrorType.NotFound,
                "not_implemented" => ServerlessListAppsResponseErrorType.NotImplemented,
                "rate_limited" => ServerlessListAppsResponseErrorType.RateLimited,
                "server_error" => ServerlessListAppsResponseErrorType.ServerError,
                "validation_error" => ServerlessListAppsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
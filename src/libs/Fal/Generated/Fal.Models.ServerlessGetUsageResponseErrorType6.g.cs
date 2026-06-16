
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetUsageResponseErrorType6
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
    public static class ServerlessGetUsageResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetUsageResponseErrorType6 value)
        {
            return value switch
            {
                ServerlessGetUsageResponseErrorType6.AuthorizationError => "authorization_error",
                ServerlessGetUsageResponseErrorType6.NotFound => "not_found",
                ServerlessGetUsageResponseErrorType6.NotImplemented => "not_implemented",
                ServerlessGetUsageResponseErrorType6.RateLimited => "rate_limited",
                ServerlessGetUsageResponseErrorType6.ServerError => "server_error",
                ServerlessGetUsageResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetUsageResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetUsageResponseErrorType6.AuthorizationError,
                "not_found" => ServerlessGetUsageResponseErrorType6.NotFound,
                "not_implemented" => ServerlessGetUsageResponseErrorType6.NotImplemented,
                "rate_limited" => ServerlessGetUsageResponseErrorType6.RateLimited,
                "server_error" => ServerlessGetUsageResponseErrorType6.ServerError,
                "validation_error" => ServerlessGetUsageResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
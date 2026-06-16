
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetUsageResponseErrorType5
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
    public static class ServerlessGetUsageResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetUsageResponseErrorType5 value)
        {
            return value switch
            {
                ServerlessGetUsageResponseErrorType5.AuthorizationError => "authorization_error",
                ServerlessGetUsageResponseErrorType5.NotFound => "not_found",
                ServerlessGetUsageResponseErrorType5.NotImplemented => "not_implemented",
                ServerlessGetUsageResponseErrorType5.RateLimited => "rate_limited",
                ServerlessGetUsageResponseErrorType5.ServerError => "server_error",
                ServerlessGetUsageResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetUsageResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetUsageResponseErrorType5.AuthorizationError,
                "not_found" => ServerlessGetUsageResponseErrorType5.NotFound,
                "not_implemented" => ServerlessGetUsageResponseErrorType5.NotImplemented,
                "rate_limited" => ServerlessGetUsageResponseErrorType5.RateLimited,
                "server_error" => ServerlessGetUsageResponseErrorType5.ServerError,
                "validation_error" => ServerlessGetUsageResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
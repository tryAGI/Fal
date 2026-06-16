
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetUsageResponseErrorType3
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
    public static class ServerlessGetUsageResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetUsageResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessGetUsageResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessGetUsageResponseErrorType3.NotFound => "not_found",
                ServerlessGetUsageResponseErrorType3.NotImplemented => "not_implemented",
                ServerlessGetUsageResponseErrorType3.RateLimited => "rate_limited",
                ServerlessGetUsageResponseErrorType3.ServerError => "server_error",
                ServerlessGetUsageResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetUsageResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetUsageResponseErrorType3.AuthorizationError,
                "not_found" => ServerlessGetUsageResponseErrorType3.NotFound,
                "not_implemented" => ServerlessGetUsageResponseErrorType3.NotImplemented,
                "rate_limited" => ServerlessGetUsageResponseErrorType3.RateLimited,
                "server_error" => ServerlessGetUsageResponseErrorType3.ServerError,
                "validation_error" => ServerlessGetUsageResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
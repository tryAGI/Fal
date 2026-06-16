
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetUsageResponseErrorType4
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
    public static class ServerlessGetUsageResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetUsageResponseErrorType4 value)
        {
            return value switch
            {
                ServerlessGetUsageResponseErrorType4.AuthorizationError => "authorization_error",
                ServerlessGetUsageResponseErrorType4.NotFound => "not_found",
                ServerlessGetUsageResponseErrorType4.NotImplemented => "not_implemented",
                ServerlessGetUsageResponseErrorType4.RateLimited => "rate_limited",
                ServerlessGetUsageResponseErrorType4.ServerError => "server_error",
                ServerlessGetUsageResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetUsageResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetUsageResponseErrorType4.AuthorizationError,
                "not_found" => ServerlessGetUsageResponseErrorType4.NotFound,
                "not_implemented" => ServerlessGetUsageResponseErrorType4.NotImplemented,
                "rate_limited" => ServerlessGetUsageResponseErrorType4.RateLimited,
                "server_error" => ServerlessGetUsageResponseErrorType4.ServerError,
                "validation_error" => ServerlessGetUsageResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
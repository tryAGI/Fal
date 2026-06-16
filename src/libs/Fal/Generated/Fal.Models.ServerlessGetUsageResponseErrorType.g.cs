
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetUsageResponseErrorType
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
    public static class ServerlessGetUsageResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetUsageResponseErrorType value)
        {
            return value switch
            {
                ServerlessGetUsageResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessGetUsageResponseErrorType.NotFound => "not_found",
                ServerlessGetUsageResponseErrorType.NotImplemented => "not_implemented",
                ServerlessGetUsageResponseErrorType.RateLimited => "rate_limited",
                ServerlessGetUsageResponseErrorType.ServerError => "server_error",
                ServerlessGetUsageResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetUsageResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetUsageResponseErrorType.AuthorizationError,
                "not_found" => ServerlessGetUsageResponseErrorType.NotFound,
                "not_implemented" => ServerlessGetUsageResponseErrorType.NotImplemented,
                "rate_limited" => ServerlessGetUsageResponseErrorType.RateLimited,
                "server_error" => ServerlessGetUsageResponseErrorType.ServerError,
                "validation_error" => ServerlessGetUsageResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
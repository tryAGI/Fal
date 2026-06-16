
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetUsageResponseErrorType2
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
    public static class ServerlessGetUsageResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetUsageResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessGetUsageResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessGetUsageResponseErrorType2.NotFound => "not_found",
                ServerlessGetUsageResponseErrorType2.NotImplemented => "not_implemented",
                ServerlessGetUsageResponseErrorType2.RateLimited => "rate_limited",
                ServerlessGetUsageResponseErrorType2.ServerError => "server_error",
                ServerlessGetUsageResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetUsageResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetUsageResponseErrorType2.AuthorizationError,
                "not_found" => ServerlessGetUsageResponseErrorType2.NotFound,
                "not_implemented" => ServerlessGetUsageResponseErrorType2.NotImplemented,
                "rate_limited" => ServerlessGetUsageResponseErrorType2.RateLimited,
                "server_error" => ServerlessGetUsageResponseErrorType2.ServerError,
                "validation_error" => ServerlessGetUsageResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
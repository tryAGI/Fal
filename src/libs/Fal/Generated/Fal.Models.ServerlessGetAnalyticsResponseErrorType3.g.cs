
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetAnalyticsResponseErrorType3
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
    public static class ServerlessGetAnalyticsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetAnalyticsResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessGetAnalyticsResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessGetAnalyticsResponseErrorType3.NotFound => "not_found",
                ServerlessGetAnalyticsResponseErrorType3.NotImplemented => "not_implemented",
                ServerlessGetAnalyticsResponseErrorType3.RateLimited => "rate_limited",
                ServerlessGetAnalyticsResponseErrorType3.ServerError => "server_error",
                ServerlessGetAnalyticsResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetAnalyticsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetAnalyticsResponseErrorType3.AuthorizationError,
                "not_found" => ServerlessGetAnalyticsResponseErrorType3.NotFound,
                "not_implemented" => ServerlessGetAnalyticsResponseErrorType3.NotImplemented,
                "rate_limited" => ServerlessGetAnalyticsResponseErrorType3.RateLimited,
                "server_error" => ServerlessGetAnalyticsResponseErrorType3.ServerError,
                "validation_error" => ServerlessGetAnalyticsResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
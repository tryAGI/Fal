
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetAnalyticsResponseErrorType6
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
    public static class ServerlessGetAnalyticsResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetAnalyticsResponseErrorType6 value)
        {
            return value switch
            {
                ServerlessGetAnalyticsResponseErrorType6.AuthorizationError => "authorization_error",
                ServerlessGetAnalyticsResponseErrorType6.NotFound => "not_found",
                ServerlessGetAnalyticsResponseErrorType6.NotImplemented => "not_implemented",
                ServerlessGetAnalyticsResponseErrorType6.RateLimited => "rate_limited",
                ServerlessGetAnalyticsResponseErrorType6.ServerError => "server_error",
                ServerlessGetAnalyticsResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetAnalyticsResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetAnalyticsResponseErrorType6.AuthorizationError,
                "not_found" => ServerlessGetAnalyticsResponseErrorType6.NotFound,
                "not_implemented" => ServerlessGetAnalyticsResponseErrorType6.NotImplemented,
                "rate_limited" => ServerlessGetAnalyticsResponseErrorType6.RateLimited,
                "server_error" => ServerlessGetAnalyticsResponseErrorType6.ServerError,
                "validation_error" => ServerlessGetAnalyticsResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
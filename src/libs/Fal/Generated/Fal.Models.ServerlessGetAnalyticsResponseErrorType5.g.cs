
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetAnalyticsResponseErrorType5
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
    public static class ServerlessGetAnalyticsResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetAnalyticsResponseErrorType5 value)
        {
            return value switch
            {
                ServerlessGetAnalyticsResponseErrorType5.AuthorizationError => "authorization_error",
                ServerlessGetAnalyticsResponseErrorType5.NotFound => "not_found",
                ServerlessGetAnalyticsResponseErrorType5.NotImplemented => "not_implemented",
                ServerlessGetAnalyticsResponseErrorType5.RateLimited => "rate_limited",
                ServerlessGetAnalyticsResponseErrorType5.ServerError => "server_error",
                ServerlessGetAnalyticsResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetAnalyticsResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetAnalyticsResponseErrorType5.AuthorizationError,
                "not_found" => ServerlessGetAnalyticsResponseErrorType5.NotFound,
                "not_implemented" => ServerlessGetAnalyticsResponseErrorType5.NotImplemented,
                "rate_limited" => ServerlessGetAnalyticsResponseErrorType5.RateLimited,
                "server_error" => ServerlessGetAnalyticsResponseErrorType5.ServerError,
                "validation_error" => ServerlessGetAnalyticsResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
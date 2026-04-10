
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetAnalyticsResponseErrorType2
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
    public static class ServerlessGetAnalyticsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetAnalyticsResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessGetAnalyticsResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessGetAnalyticsResponseErrorType2.NotFound => "not_found",
                ServerlessGetAnalyticsResponseErrorType2.NotImplemented => "not_implemented",
                ServerlessGetAnalyticsResponseErrorType2.RateLimited => "rate_limited",
                ServerlessGetAnalyticsResponseErrorType2.ServerError => "server_error",
                ServerlessGetAnalyticsResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetAnalyticsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetAnalyticsResponseErrorType2.AuthorizationError,
                "not_found" => ServerlessGetAnalyticsResponseErrorType2.NotFound,
                "not_implemented" => ServerlessGetAnalyticsResponseErrorType2.NotImplemented,
                "rate_limited" => ServerlessGetAnalyticsResponseErrorType2.RateLimited,
                "server_error" => ServerlessGetAnalyticsResponseErrorType2.ServerError,
                "validation_error" => ServerlessGetAnalyticsResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
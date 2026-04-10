
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetAnalyticsResponseErrorType
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
    public static class ServerlessGetAnalyticsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetAnalyticsResponseErrorType value)
        {
            return value switch
            {
                ServerlessGetAnalyticsResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessGetAnalyticsResponseErrorType.NotFound => "not_found",
                ServerlessGetAnalyticsResponseErrorType.NotImplemented => "not_implemented",
                ServerlessGetAnalyticsResponseErrorType.RateLimited => "rate_limited",
                ServerlessGetAnalyticsResponseErrorType.ServerError => "server_error",
                ServerlessGetAnalyticsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetAnalyticsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetAnalyticsResponseErrorType.AuthorizationError,
                "not_found" => ServerlessGetAnalyticsResponseErrorType.NotFound,
                "not_implemented" => ServerlessGetAnalyticsResponseErrorType.NotImplemented,
                "rate_limited" => ServerlessGetAnalyticsResponseErrorType.RateLimited,
                "server_error" => ServerlessGetAnalyticsResponseErrorType.ServerError,
                "validation_error" => ServerlessGetAnalyticsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
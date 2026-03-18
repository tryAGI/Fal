
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetMetricsResponseErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorizationError,
        /// <summary>
        /// 
        /// </summary>
        ValidationError,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
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
        NotImplemented,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessGetMetricsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetMetricsResponseErrorType value)
        {
            return value switch
            {
                ServerlessGetMetricsResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessGetMetricsResponseErrorType.ValidationError => "validation_error",
                ServerlessGetMetricsResponseErrorType.NotFound => "not_found",
                ServerlessGetMetricsResponseErrorType.RateLimited => "rate_limited",
                ServerlessGetMetricsResponseErrorType.ServerError => "server_error",
                ServerlessGetMetricsResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetMetricsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetMetricsResponseErrorType.AuthorizationError,
                "validation_error" => ServerlessGetMetricsResponseErrorType.ValidationError,
                "not_found" => ServerlessGetMetricsResponseErrorType.NotFound,
                "rate_limited" => ServerlessGetMetricsResponseErrorType.RateLimited,
                "server_error" => ServerlessGetMetricsResponseErrorType.ServerError,
                "not_implemented" => ServerlessGetMetricsResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}
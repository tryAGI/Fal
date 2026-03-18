
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetMetricsResponseErrorType2
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
    public static class ServerlessGetMetricsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetMetricsResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessGetMetricsResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessGetMetricsResponseErrorType2.ValidationError => "validation_error",
                ServerlessGetMetricsResponseErrorType2.NotFound => "not_found",
                ServerlessGetMetricsResponseErrorType2.RateLimited => "rate_limited",
                ServerlessGetMetricsResponseErrorType2.ServerError => "server_error",
                ServerlessGetMetricsResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetMetricsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetMetricsResponseErrorType2.AuthorizationError,
                "validation_error" => ServerlessGetMetricsResponseErrorType2.ValidationError,
                "not_found" => ServerlessGetMetricsResponseErrorType2.NotFound,
                "rate_limited" => ServerlessGetMetricsResponseErrorType2.RateLimited,
                "server_error" => ServerlessGetMetricsResponseErrorType2.ServerError,
                "not_implemented" => ServerlessGetMetricsResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}
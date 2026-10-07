
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetComputeMetricsResponseErrorType6
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
    public static class GetComputeMetricsResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeMetricsResponseErrorType6 value)
        {
            return value switch
            {
                GetComputeMetricsResponseErrorType6.AuthorizationError => "authorization_error",
                GetComputeMetricsResponseErrorType6.NotFound => "not_found",
                GetComputeMetricsResponseErrorType6.NotImplemented => "not_implemented",
                GetComputeMetricsResponseErrorType6.RateLimited => "rate_limited",
                GetComputeMetricsResponseErrorType6.ServerError => "server_error",
                GetComputeMetricsResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeMetricsResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetComputeMetricsResponseErrorType6.AuthorizationError,
                "not_found" => GetComputeMetricsResponseErrorType6.NotFound,
                "not_implemented" => GetComputeMetricsResponseErrorType6.NotImplemented,
                "rate_limited" => GetComputeMetricsResponseErrorType6.RateLimited,
                "server_error" => GetComputeMetricsResponseErrorType6.ServerError,
                "validation_error" => GetComputeMetricsResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
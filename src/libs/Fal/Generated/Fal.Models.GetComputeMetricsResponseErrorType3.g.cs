
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetComputeMetricsResponseErrorType3
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
    public static class GetComputeMetricsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeMetricsResponseErrorType3 value)
        {
            return value switch
            {
                GetComputeMetricsResponseErrorType3.AuthorizationError => "authorization_error",
                GetComputeMetricsResponseErrorType3.NotFound => "not_found",
                GetComputeMetricsResponseErrorType3.NotImplemented => "not_implemented",
                GetComputeMetricsResponseErrorType3.RateLimited => "rate_limited",
                GetComputeMetricsResponseErrorType3.ServerError => "server_error",
                GetComputeMetricsResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeMetricsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetComputeMetricsResponseErrorType3.AuthorizationError,
                "not_found" => GetComputeMetricsResponseErrorType3.NotFound,
                "not_implemented" => GetComputeMetricsResponseErrorType3.NotImplemented,
                "rate_limited" => GetComputeMetricsResponseErrorType3.RateLimited,
                "server_error" => GetComputeMetricsResponseErrorType3.ServerError,
                "validation_error" => GetComputeMetricsResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
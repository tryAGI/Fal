
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetComputeMetricsResponseErrorType5
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
    public static class GetComputeMetricsResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeMetricsResponseErrorType5 value)
        {
            return value switch
            {
                GetComputeMetricsResponseErrorType5.AuthorizationError => "authorization_error",
                GetComputeMetricsResponseErrorType5.NotFound => "not_found",
                GetComputeMetricsResponseErrorType5.NotImplemented => "not_implemented",
                GetComputeMetricsResponseErrorType5.RateLimited => "rate_limited",
                GetComputeMetricsResponseErrorType5.ServerError => "server_error",
                GetComputeMetricsResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeMetricsResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetComputeMetricsResponseErrorType5.AuthorizationError,
                "not_found" => GetComputeMetricsResponseErrorType5.NotFound,
                "not_implemented" => GetComputeMetricsResponseErrorType5.NotImplemented,
                "rate_limited" => GetComputeMetricsResponseErrorType5.RateLimited,
                "server_error" => GetComputeMetricsResponseErrorType5.ServerError,
                "validation_error" => GetComputeMetricsResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
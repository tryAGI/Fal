
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetComputeMetricsResponseErrorType
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
    public static class GetComputeMetricsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeMetricsResponseErrorType value)
        {
            return value switch
            {
                GetComputeMetricsResponseErrorType.AuthorizationError => "authorization_error",
                GetComputeMetricsResponseErrorType.NotFound => "not_found",
                GetComputeMetricsResponseErrorType.NotImplemented => "not_implemented",
                GetComputeMetricsResponseErrorType.RateLimited => "rate_limited",
                GetComputeMetricsResponseErrorType.ServerError => "server_error",
                GetComputeMetricsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeMetricsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetComputeMetricsResponseErrorType.AuthorizationError,
                "not_found" => GetComputeMetricsResponseErrorType.NotFound,
                "not_implemented" => GetComputeMetricsResponseErrorType.NotImplemented,
                "rate_limited" => GetComputeMetricsResponseErrorType.RateLimited,
                "server_error" => GetComputeMetricsResponseErrorType.ServerError,
                "validation_error" => GetComputeMetricsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
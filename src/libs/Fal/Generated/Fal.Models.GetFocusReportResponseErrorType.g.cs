
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetFocusReportResponseErrorType
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
    public static class GetFocusReportResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFocusReportResponseErrorType value)
        {
            return value switch
            {
                GetFocusReportResponseErrorType.AuthorizationError => "authorization_error",
                GetFocusReportResponseErrorType.ValidationError => "validation_error",
                GetFocusReportResponseErrorType.NotFound => "not_found",
                GetFocusReportResponseErrorType.RateLimited => "rate_limited",
                GetFocusReportResponseErrorType.ServerError => "server_error",
                GetFocusReportResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFocusReportResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetFocusReportResponseErrorType.AuthorizationError,
                "validation_error" => GetFocusReportResponseErrorType.ValidationError,
                "not_found" => GetFocusReportResponseErrorType.NotFound,
                "rate_limited" => GetFocusReportResponseErrorType.RateLimited,
                "server_error" => GetFocusReportResponseErrorType.ServerError,
                "not_implemented" => GetFocusReportResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}
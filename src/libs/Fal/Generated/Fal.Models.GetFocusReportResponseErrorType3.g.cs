
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetFocusReportResponseErrorType3
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
    public static class GetFocusReportResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFocusReportResponseErrorType3 value)
        {
            return value switch
            {
                GetFocusReportResponseErrorType3.AuthorizationError => "authorization_error",
                GetFocusReportResponseErrorType3.ValidationError => "validation_error",
                GetFocusReportResponseErrorType3.NotFound => "not_found",
                GetFocusReportResponseErrorType3.RateLimited => "rate_limited",
                GetFocusReportResponseErrorType3.ServerError => "server_error",
                GetFocusReportResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFocusReportResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetFocusReportResponseErrorType3.AuthorizationError,
                "validation_error" => GetFocusReportResponseErrorType3.ValidationError,
                "not_found" => GetFocusReportResponseErrorType3.NotFound,
                "rate_limited" => GetFocusReportResponseErrorType3.RateLimited,
                "server_error" => GetFocusReportResponseErrorType3.ServerError,
                "not_implemented" => GetFocusReportResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}
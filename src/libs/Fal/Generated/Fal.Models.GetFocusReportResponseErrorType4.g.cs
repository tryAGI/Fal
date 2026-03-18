
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetFocusReportResponseErrorType4
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
    public static class GetFocusReportResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFocusReportResponseErrorType4 value)
        {
            return value switch
            {
                GetFocusReportResponseErrorType4.AuthorizationError => "authorization_error",
                GetFocusReportResponseErrorType4.ValidationError => "validation_error",
                GetFocusReportResponseErrorType4.NotFound => "not_found",
                GetFocusReportResponseErrorType4.RateLimited => "rate_limited",
                GetFocusReportResponseErrorType4.ServerError => "server_error",
                GetFocusReportResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFocusReportResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetFocusReportResponseErrorType4.AuthorizationError,
                "validation_error" => GetFocusReportResponseErrorType4.ValidationError,
                "not_found" => GetFocusReportResponseErrorType4.NotFound,
                "rate_limited" => GetFocusReportResponseErrorType4.RateLimited,
                "server_error" => GetFocusReportResponseErrorType4.ServerError,
                "not_implemented" => GetFocusReportResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}
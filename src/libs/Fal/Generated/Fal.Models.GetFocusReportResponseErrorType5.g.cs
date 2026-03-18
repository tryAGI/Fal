
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetFocusReportResponseErrorType5
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
    public static class GetFocusReportResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFocusReportResponseErrorType5 value)
        {
            return value switch
            {
                GetFocusReportResponseErrorType5.AuthorizationError => "authorization_error",
                GetFocusReportResponseErrorType5.ValidationError => "validation_error",
                GetFocusReportResponseErrorType5.NotFound => "not_found",
                GetFocusReportResponseErrorType5.RateLimited => "rate_limited",
                GetFocusReportResponseErrorType5.ServerError => "server_error",
                GetFocusReportResponseErrorType5.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFocusReportResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetFocusReportResponseErrorType5.AuthorizationError,
                "validation_error" => GetFocusReportResponseErrorType5.ValidationError,
                "not_found" => GetFocusReportResponseErrorType5.NotFound,
                "rate_limited" => GetFocusReportResponseErrorType5.RateLimited,
                "server_error" => GetFocusReportResponseErrorType5.ServerError,
                "not_implemented" => GetFocusReportResponseErrorType5.NotImplemented,
                _ => null,
            };
        }
    }
}
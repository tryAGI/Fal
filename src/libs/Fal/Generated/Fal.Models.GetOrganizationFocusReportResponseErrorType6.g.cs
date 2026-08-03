
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationFocusReportResponseErrorType6
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
    public static class GetOrganizationFocusReportResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationFocusReportResponseErrorType6 value)
        {
            return value switch
            {
                GetOrganizationFocusReportResponseErrorType6.AuthorizationError => "authorization_error",
                GetOrganizationFocusReportResponseErrorType6.NotFound => "not_found",
                GetOrganizationFocusReportResponseErrorType6.NotImplemented => "not_implemented",
                GetOrganizationFocusReportResponseErrorType6.RateLimited => "rate_limited",
                GetOrganizationFocusReportResponseErrorType6.ServerError => "server_error",
                GetOrganizationFocusReportResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationFocusReportResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationFocusReportResponseErrorType6.AuthorizationError,
                "not_found" => GetOrganizationFocusReportResponseErrorType6.NotFound,
                "not_implemented" => GetOrganizationFocusReportResponseErrorType6.NotImplemented,
                "rate_limited" => GetOrganizationFocusReportResponseErrorType6.RateLimited,
                "server_error" => GetOrganizationFocusReportResponseErrorType6.ServerError,
                "validation_error" => GetOrganizationFocusReportResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
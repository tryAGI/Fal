
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationFocusReportResponseErrorType4
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
    public static class GetOrganizationFocusReportResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationFocusReportResponseErrorType4 value)
        {
            return value switch
            {
                GetOrganizationFocusReportResponseErrorType4.AuthorizationError => "authorization_error",
                GetOrganizationFocusReportResponseErrorType4.NotFound => "not_found",
                GetOrganizationFocusReportResponseErrorType4.NotImplemented => "not_implemented",
                GetOrganizationFocusReportResponseErrorType4.RateLimited => "rate_limited",
                GetOrganizationFocusReportResponseErrorType4.ServerError => "server_error",
                GetOrganizationFocusReportResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationFocusReportResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationFocusReportResponseErrorType4.AuthorizationError,
                "not_found" => GetOrganizationFocusReportResponseErrorType4.NotFound,
                "not_implemented" => GetOrganizationFocusReportResponseErrorType4.NotImplemented,
                "rate_limited" => GetOrganizationFocusReportResponseErrorType4.RateLimited,
                "server_error" => GetOrganizationFocusReportResponseErrorType4.ServerError,
                "validation_error" => GetOrganizationFocusReportResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
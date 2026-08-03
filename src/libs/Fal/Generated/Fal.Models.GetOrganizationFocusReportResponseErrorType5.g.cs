
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationFocusReportResponseErrorType5
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
    public static class GetOrganizationFocusReportResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationFocusReportResponseErrorType5 value)
        {
            return value switch
            {
                GetOrganizationFocusReportResponseErrorType5.AuthorizationError => "authorization_error",
                GetOrganizationFocusReportResponseErrorType5.NotFound => "not_found",
                GetOrganizationFocusReportResponseErrorType5.NotImplemented => "not_implemented",
                GetOrganizationFocusReportResponseErrorType5.RateLimited => "rate_limited",
                GetOrganizationFocusReportResponseErrorType5.ServerError => "server_error",
                GetOrganizationFocusReportResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationFocusReportResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationFocusReportResponseErrorType5.AuthorizationError,
                "not_found" => GetOrganizationFocusReportResponseErrorType5.NotFound,
                "not_implemented" => GetOrganizationFocusReportResponseErrorType5.NotImplemented,
                "rate_limited" => GetOrganizationFocusReportResponseErrorType5.RateLimited,
                "server_error" => GetOrganizationFocusReportResponseErrorType5.ServerError,
                "validation_error" => GetOrganizationFocusReportResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
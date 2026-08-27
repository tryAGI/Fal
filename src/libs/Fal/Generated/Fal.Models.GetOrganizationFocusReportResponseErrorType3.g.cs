
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationFocusReportResponseErrorType3
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
    public static class GetOrganizationFocusReportResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationFocusReportResponseErrorType3 value)
        {
            return value switch
            {
                GetOrganizationFocusReportResponseErrorType3.AuthorizationError => "authorization_error",
                GetOrganizationFocusReportResponseErrorType3.NotFound => "not_found",
                GetOrganizationFocusReportResponseErrorType3.NotImplemented => "not_implemented",
                GetOrganizationFocusReportResponseErrorType3.RateLimited => "rate_limited",
                GetOrganizationFocusReportResponseErrorType3.ServerError => "server_error",
                GetOrganizationFocusReportResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationFocusReportResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationFocusReportResponseErrorType3.AuthorizationError,
                "not_found" => GetOrganizationFocusReportResponseErrorType3.NotFound,
                "not_implemented" => GetOrganizationFocusReportResponseErrorType3.NotImplemented,
                "rate_limited" => GetOrganizationFocusReportResponseErrorType3.RateLimited,
                "server_error" => GetOrganizationFocusReportResponseErrorType3.ServerError,
                "validation_error" => GetOrganizationFocusReportResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
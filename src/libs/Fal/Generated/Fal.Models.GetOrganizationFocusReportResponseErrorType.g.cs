
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationFocusReportResponseErrorType
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
    public static class GetOrganizationFocusReportResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationFocusReportResponseErrorType value)
        {
            return value switch
            {
                GetOrganizationFocusReportResponseErrorType.AuthorizationError => "authorization_error",
                GetOrganizationFocusReportResponseErrorType.NotFound => "not_found",
                GetOrganizationFocusReportResponseErrorType.NotImplemented => "not_implemented",
                GetOrganizationFocusReportResponseErrorType.RateLimited => "rate_limited",
                GetOrganizationFocusReportResponseErrorType.ServerError => "server_error",
                GetOrganizationFocusReportResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationFocusReportResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationFocusReportResponseErrorType.AuthorizationError,
                "not_found" => GetOrganizationFocusReportResponseErrorType.NotFound,
                "not_implemented" => GetOrganizationFocusReportResponseErrorType.NotImplemented,
                "rate_limited" => GetOrganizationFocusReportResponseErrorType.RateLimited,
                "server_error" => GetOrganizationFocusReportResponseErrorType.ServerError,
                "validation_error" => GetOrganizationFocusReportResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
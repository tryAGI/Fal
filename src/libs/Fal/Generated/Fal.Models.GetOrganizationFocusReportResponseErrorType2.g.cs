
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationFocusReportResponseErrorType2
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
    public static class GetOrganizationFocusReportResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationFocusReportResponseErrorType2 value)
        {
            return value switch
            {
                GetOrganizationFocusReportResponseErrorType2.AuthorizationError => "authorization_error",
                GetOrganizationFocusReportResponseErrorType2.NotFound => "not_found",
                GetOrganizationFocusReportResponseErrorType2.NotImplemented => "not_implemented",
                GetOrganizationFocusReportResponseErrorType2.RateLimited => "rate_limited",
                GetOrganizationFocusReportResponseErrorType2.ServerError => "server_error",
                GetOrganizationFocusReportResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationFocusReportResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationFocusReportResponseErrorType2.AuthorizationError,
                "not_found" => GetOrganizationFocusReportResponseErrorType2.NotFound,
                "not_implemented" => GetOrganizationFocusReportResponseErrorType2.NotImplemented,
                "rate_limited" => GetOrganizationFocusReportResponseErrorType2.RateLimited,
                "server_error" => GetOrganizationFocusReportResponseErrorType2.ServerError,
                "validation_error" => GetOrganizationFocusReportResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
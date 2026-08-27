
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationBillingEventsResponseErrorType4
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
    public static class GetOrganizationBillingEventsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationBillingEventsResponseErrorType4 value)
        {
            return value switch
            {
                GetOrganizationBillingEventsResponseErrorType4.AuthorizationError => "authorization_error",
                GetOrganizationBillingEventsResponseErrorType4.NotFound => "not_found",
                GetOrganizationBillingEventsResponseErrorType4.NotImplemented => "not_implemented",
                GetOrganizationBillingEventsResponseErrorType4.RateLimited => "rate_limited",
                GetOrganizationBillingEventsResponseErrorType4.ServerError => "server_error",
                GetOrganizationBillingEventsResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationBillingEventsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationBillingEventsResponseErrorType4.AuthorizationError,
                "not_found" => GetOrganizationBillingEventsResponseErrorType4.NotFound,
                "not_implemented" => GetOrganizationBillingEventsResponseErrorType4.NotImplemented,
                "rate_limited" => GetOrganizationBillingEventsResponseErrorType4.RateLimited,
                "server_error" => GetOrganizationBillingEventsResponseErrorType4.ServerError,
                "validation_error" => GetOrganizationBillingEventsResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
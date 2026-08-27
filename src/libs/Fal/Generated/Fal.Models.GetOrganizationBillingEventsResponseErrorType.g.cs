
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationBillingEventsResponseErrorType
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
    public static class GetOrganizationBillingEventsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationBillingEventsResponseErrorType value)
        {
            return value switch
            {
                GetOrganizationBillingEventsResponseErrorType.AuthorizationError => "authorization_error",
                GetOrganizationBillingEventsResponseErrorType.NotFound => "not_found",
                GetOrganizationBillingEventsResponseErrorType.NotImplemented => "not_implemented",
                GetOrganizationBillingEventsResponseErrorType.RateLimited => "rate_limited",
                GetOrganizationBillingEventsResponseErrorType.ServerError => "server_error",
                GetOrganizationBillingEventsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationBillingEventsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationBillingEventsResponseErrorType.AuthorizationError,
                "not_found" => GetOrganizationBillingEventsResponseErrorType.NotFound,
                "not_implemented" => GetOrganizationBillingEventsResponseErrorType.NotImplemented,
                "rate_limited" => GetOrganizationBillingEventsResponseErrorType.RateLimited,
                "server_error" => GetOrganizationBillingEventsResponseErrorType.ServerError,
                "validation_error" => GetOrganizationBillingEventsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationBillingEventsResponseErrorType5
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
    public static class GetOrganizationBillingEventsResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationBillingEventsResponseErrorType5 value)
        {
            return value switch
            {
                GetOrganizationBillingEventsResponseErrorType5.AuthorizationError => "authorization_error",
                GetOrganizationBillingEventsResponseErrorType5.NotFound => "not_found",
                GetOrganizationBillingEventsResponseErrorType5.NotImplemented => "not_implemented",
                GetOrganizationBillingEventsResponseErrorType5.RateLimited => "rate_limited",
                GetOrganizationBillingEventsResponseErrorType5.ServerError => "server_error",
                GetOrganizationBillingEventsResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationBillingEventsResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationBillingEventsResponseErrorType5.AuthorizationError,
                "not_found" => GetOrganizationBillingEventsResponseErrorType5.NotFound,
                "not_implemented" => GetOrganizationBillingEventsResponseErrorType5.NotImplemented,
                "rate_limited" => GetOrganizationBillingEventsResponseErrorType5.RateLimited,
                "server_error" => GetOrganizationBillingEventsResponseErrorType5.ServerError,
                "validation_error" => GetOrganizationBillingEventsResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetBillingEventsResponseErrorType4
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
    public static class GetBillingEventsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBillingEventsResponseErrorType4 value)
        {
            return value switch
            {
                GetBillingEventsResponseErrorType4.AuthorizationError => "authorization_error",
                GetBillingEventsResponseErrorType4.ValidationError => "validation_error",
                GetBillingEventsResponseErrorType4.NotFound => "not_found",
                GetBillingEventsResponseErrorType4.RateLimited => "rate_limited",
                GetBillingEventsResponseErrorType4.ServerError => "server_error",
                GetBillingEventsResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBillingEventsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetBillingEventsResponseErrorType4.AuthorizationError,
                "validation_error" => GetBillingEventsResponseErrorType4.ValidationError,
                "not_found" => GetBillingEventsResponseErrorType4.NotFound,
                "rate_limited" => GetBillingEventsResponseErrorType4.RateLimited,
                "server_error" => GetBillingEventsResponseErrorType4.ServerError,
                "not_implemented" => GetBillingEventsResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}
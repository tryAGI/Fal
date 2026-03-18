
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetBillingEventsResponseErrorType3
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
    public static class GetBillingEventsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBillingEventsResponseErrorType3 value)
        {
            return value switch
            {
                GetBillingEventsResponseErrorType3.AuthorizationError => "authorization_error",
                GetBillingEventsResponseErrorType3.ValidationError => "validation_error",
                GetBillingEventsResponseErrorType3.NotFound => "not_found",
                GetBillingEventsResponseErrorType3.RateLimited => "rate_limited",
                GetBillingEventsResponseErrorType3.ServerError => "server_error",
                GetBillingEventsResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBillingEventsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetBillingEventsResponseErrorType3.AuthorizationError,
                "validation_error" => GetBillingEventsResponseErrorType3.ValidationError,
                "not_found" => GetBillingEventsResponseErrorType3.NotFound,
                "rate_limited" => GetBillingEventsResponseErrorType3.RateLimited,
                "server_error" => GetBillingEventsResponseErrorType3.ServerError,
                "not_implemented" => GetBillingEventsResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}
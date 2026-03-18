
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetBillingEventsResponseErrorType2
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
    public static class GetBillingEventsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBillingEventsResponseErrorType2 value)
        {
            return value switch
            {
                GetBillingEventsResponseErrorType2.AuthorizationError => "authorization_error",
                GetBillingEventsResponseErrorType2.ValidationError => "validation_error",
                GetBillingEventsResponseErrorType2.NotFound => "not_found",
                GetBillingEventsResponseErrorType2.RateLimited => "rate_limited",
                GetBillingEventsResponseErrorType2.ServerError => "server_error",
                GetBillingEventsResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBillingEventsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetBillingEventsResponseErrorType2.AuthorizationError,
                "validation_error" => GetBillingEventsResponseErrorType2.ValidationError,
                "not_found" => GetBillingEventsResponseErrorType2.NotFound,
                "rate_limited" => GetBillingEventsResponseErrorType2.RateLimited,
                "server_error" => GetBillingEventsResponseErrorType2.ServerError,
                "not_implemented" => GetBillingEventsResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}
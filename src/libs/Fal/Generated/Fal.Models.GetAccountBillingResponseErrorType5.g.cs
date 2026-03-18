
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAccountBillingResponseErrorType5
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
    public static class GetAccountBillingResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAccountBillingResponseErrorType5 value)
        {
            return value switch
            {
                GetAccountBillingResponseErrorType5.AuthorizationError => "authorization_error",
                GetAccountBillingResponseErrorType5.ValidationError => "validation_error",
                GetAccountBillingResponseErrorType5.NotFound => "not_found",
                GetAccountBillingResponseErrorType5.RateLimited => "rate_limited",
                GetAccountBillingResponseErrorType5.ServerError => "server_error",
                GetAccountBillingResponseErrorType5.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAccountBillingResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAccountBillingResponseErrorType5.AuthorizationError,
                "validation_error" => GetAccountBillingResponseErrorType5.ValidationError,
                "not_found" => GetAccountBillingResponseErrorType5.NotFound,
                "rate_limited" => GetAccountBillingResponseErrorType5.RateLimited,
                "server_error" => GetAccountBillingResponseErrorType5.ServerError,
                "not_implemented" => GetAccountBillingResponseErrorType5.NotImplemented,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAccountBillingResponseErrorType4
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
    public static class GetAccountBillingResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAccountBillingResponseErrorType4 value)
        {
            return value switch
            {
                GetAccountBillingResponseErrorType4.AuthorizationError => "authorization_error",
                GetAccountBillingResponseErrorType4.ValidationError => "validation_error",
                GetAccountBillingResponseErrorType4.NotFound => "not_found",
                GetAccountBillingResponseErrorType4.RateLimited => "rate_limited",
                GetAccountBillingResponseErrorType4.ServerError => "server_error",
                GetAccountBillingResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAccountBillingResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAccountBillingResponseErrorType4.AuthorizationError,
                "validation_error" => GetAccountBillingResponseErrorType4.ValidationError,
                "not_found" => GetAccountBillingResponseErrorType4.NotFound,
                "rate_limited" => GetAccountBillingResponseErrorType4.RateLimited,
                "server_error" => GetAccountBillingResponseErrorType4.ServerError,
                "not_implemented" => GetAccountBillingResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}
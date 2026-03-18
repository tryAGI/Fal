
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAccountBillingResponseErrorType
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
    public static class GetAccountBillingResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAccountBillingResponseErrorType value)
        {
            return value switch
            {
                GetAccountBillingResponseErrorType.AuthorizationError => "authorization_error",
                GetAccountBillingResponseErrorType.ValidationError => "validation_error",
                GetAccountBillingResponseErrorType.NotFound => "not_found",
                GetAccountBillingResponseErrorType.RateLimited => "rate_limited",
                GetAccountBillingResponseErrorType.ServerError => "server_error",
                GetAccountBillingResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAccountBillingResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAccountBillingResponseErrorType.AuthorizationError,
                "validation_error" => GetAccountBillingResponseErrorType.ValidationError,
                "not_found" => GetAccountBillingResponseErrorType.NotFound,
                "rate_limited" => GetAccountBillingResponseErrorType.RateLimited,
                "server_error" => GetAccountBillingResponseErrorType.ServerError,
                "not_implemented" => GetAccountBillingResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}
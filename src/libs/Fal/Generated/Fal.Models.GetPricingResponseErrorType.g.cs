
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetPricingResponseErrorType
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
    public static class GetPricingResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPricingResponseErrorType value)
        {
            return value switch
            {
                GetPricingResponseErrorType.AuthorizationError => "authorization_error",
                GetPricingResponseErrorType.ValidationError => "validation_error",
                GetPricingResponseErrorType.NotFound => "not_found",
                GetPricingResponseErrorType.RateLimited => "rate_limited",
                GetPricingResponseErrorType.ServerError => "server_error",
                GetPricingResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPricingResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetPricingResponseErrorType.AuthorizationError,
                "validation_error" => GetPricingResponseErrorType.ValidationError,
                "not_found" => GetPricingResponseErrorType.NotFound,
                "rate_limited" => GetPricingResponseErrorType.RateLimited,
                "server_error" => GetPricingResponseErrorType.ServerError,
                "not_implemented" => GetPricingResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}
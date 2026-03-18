
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetPricingResponseErrorType4
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
    public static class GetPricingResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPricingResponseErrorType4 value)
        {
            return value switch
            {
                GetPricingResponseErrorType4.AuthorizationError => "authorization_error",
                GetPricingResponseErrorType4.ValidationError => "validation_error",
                GetPricingResponseErrorType4.NotFound => "not_found",
                GetPricingResponseErrorType4.RateLimited => "rate_limited",
                GetPricingResponseErrorType4.ServerError => "server_error",
                GetPricingResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPricingResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetPricingResponseErrorType4.AuthorizationError,
                "validation_error" => GetPricingResponseErrorType4.ValidationError,
                "not_found" => GetPricingResponseErrorType4.NotFound,
                "rate_limited" => GetPricingResponseErrorType4.RateLimited,
                "server_error" => GetPricingResponseErrorType4.ServerError,
                "not_implemented" => GetPricingResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}
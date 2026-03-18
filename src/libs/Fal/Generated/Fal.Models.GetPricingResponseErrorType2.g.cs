
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetPricingResponseErrorType2
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
    public static class GetPricingResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPricingResponseErrorType2 value)
        {
            return value switch
            {
                GetPricingResponseErrorType2.AuthorizationError => "authorization_error",
                GetPricingResponseErrorType2.ValidationError => "validation_error",
                GetPricingResponseErrorType2.NotFound => "not_found",
                GetPricingResponseErrorType2.RateLimited => "rate_limited",
                GetPricingResponseErrorType2.ServerError => "server_error",
                GetPricingResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPricingResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetPricingResponseErrorType2.AuthorizationError,
                "validation_error" => GetPricingResponseErrorType2.ValidationError,
                "not_found" => GetPricingResponseErrorType2.NotFound,
                "rate_limited" => GetPricingResponseErrorType2.RateLimited,
                "server_error" => GetPricingResponseErrorType2.ServerError,
                "not_implemented" => GetPricingResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetPricingResponseErrorType3
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
    public static class GetPricingResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPricingResponseErrorType3 value)
        {
            return value switch
            {
                GetPricingResponseErrorType3.AuthorizationError => "authorization_error",
                GetPricingResponseErrorType3.ValidationError => "validation_error",
                GetPricingResponseErrorType3.NotFound => "not_found",
                GetPricingResponseErrorType3.RateLimited => "rate_limited",
                GetPricingResponseErrorType3.ServerError => "server_error",
                GetPricingResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPricingResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetPricingResponseErrorType3.AuthorizationError,
                "validation_error" => GetPricingResponseErrorType3.ValidationError,
                "not_found" => GetPricingResponseErrorType3.NotFound,
                "rate_limited" => GetPricingResponseErrorType3.RateLimited,
                "server_error" => GetPricingResponseErrorType3.ServerError,
                "not_implemented" => GetPricingResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}
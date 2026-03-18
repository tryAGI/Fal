
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum EstimatePricingResponseErrorType4
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
    public static class EstimatePricingResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingResponseErrorType4 value)
        {
            return value switch
            {
                EstimatePricingResponseErrorType4.AuthorizationError => "authorization_error",
                EstimatePricingResponseErrorType4.ValidationError => "validation_error",
                EstimatePricingResponseErrorType4.NotFound => "not_found",
                EstimatePricingResponseErrorType4.RateLimited => "rate_limited",
                EstimatePricingResponseErrorType4.ServerError => "server_error",
                EstimatePricingResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => EstimatePricingResponseErrorType4.AuthorizationError,
                "validation_error" => EstimatePricingResponseErrorType4.ValidationError,
                "not_found" => EstimatePricingResponseErrorType4.NotFound,
                "rate_limited" => EstimatePricingResponseErrorType4.RateLimited,
                "server_error" => EstimatePricingResponseErrorType4.ServerError,
                "not_implemented" => EstimatePricingResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}
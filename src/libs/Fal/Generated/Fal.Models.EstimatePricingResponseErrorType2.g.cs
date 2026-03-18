
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum EstimatePricingResponseErrorType2
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
    public static class EstimatePricingResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingResponseErrorType2 value)
        {
            return value switch
            {
                EstimatePricingResponseErrorType2.AuthorizationError => "authorization_error",
                EstimatePricingResponseErrorType2.ValidationError => "validation_error",
                EstimatePricingResponseErrorType2.NotFound => "not_found",
                EstimatePricingResponseErrorType2.RateLimited => "rate_limited",
                EstimatePricingResponseErrorType2.ServerError => "server_error",
                EstimatePricingResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => EstimatePricingResponseErrorType2.AuthorizationError,
                "validation_error" => EstimatePricingResponseErrorType2.ValidationError,
                "not_found" => EstimatePricingResponseErrorType2.NotFound,
                "rate_limited" => EstimatePricingResponseErrorType2.RateLimited,
                "server_error" => EstimatePricingResponseErrorType2.ServerError,
                "not_implemented" => EstimatePricingResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}
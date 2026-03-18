
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum EstimatePricingResponseErrorType
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
    public static class EstimatePricingResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EstimatePricingResponseErrorType value)
        {
            return value switch
            {
                EstimatePricingResponseErrorType.AuthorizationError => "authorization_error",
                EstimatePricingResponseErrorType.ValidationError => "validation_error",
                EstimatePricingResponseErrorType.NotFound => "not_found",
                EstimatePricingResponseErrorType.RateLimited => "rate_limited",
                EstimatePricingResponseErrorType.ServerError => "server_error",
                EstimatePricingResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EstimatePricingResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => EstimatePricingResponseErrorType.AuthorizationError,
                "validation_error" => EstimatePricingResponseErrorType.ValidationError,
                "not_found" => EstimatePricingResponseErrorType.NotFound,
                "rate_limited" => EstimatePricingResponseErrorType.RateLimited,
                "server_error" => EstimatePricingResponseErrorType.ServerError,
                "not_implemented" => EstimatePricingResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}
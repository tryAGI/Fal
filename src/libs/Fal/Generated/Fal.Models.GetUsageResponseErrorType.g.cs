
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetUsageResponseErrorType
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
    public static class GetUsageResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsageResponseErrorType value)
        {
            return value switch
            {
                GetUsageResponseErrorType.AuthorizationError => "authorization_error",
                GetUsageResponseErrorType.ValidationError => "validation_error",
                GetUsageResponseErrorType.NotFound => "not_found",
                GetUsageResponseErrorType.RateLimited => "rate_limited",
                GetUsageResponseErrorType.ServerError => "server_error",
                GetUsageResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsageResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetUsageResponseErrorType.AuthorizationError,
                "validation_error" => GetUsageResponseErrorType.ValidationError,
                "not_found" => GetUsageResponseErrorType.NotFound,
                "rate_limited" => GetUsageResponseErrorType.RateLimited,
                "server_error" => GetUsageResponseErrorType.ServerError,
                "not_implemented" => GetUsageResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}
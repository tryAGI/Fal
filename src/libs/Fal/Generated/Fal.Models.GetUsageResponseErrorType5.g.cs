
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetUsageResponseErrorType5
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
    public static class GetUsageResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsageResponseErrorType5 value)
        {
            return value switch
            {
                GetUsageResponseErrorType5.AuthorizationError => "authorization_error",
                GetUsageResponseErrorType5.ValidationError => "validation_error",
                GetUsageResponseErrorType5.NotFound => "not_found",
                GetUsageResponseErrorType5.RateLimited => "rate_limited",
                GetUsageResponseErrorType5.ServerError => "server_error",
                GetUsageResponseErrorType5.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsageResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetUsageResponseErrorType5.AuthorizationError,
                "validation_error" => GetUsageResponseErrorType5.ValidationError,
                "not_found" => GetUsageResponseErrorType5.NotFound,
                "rate_limited" => GetUsageResponseErrorType5.RateLimited,
                "server_error" => GetUsageResponseErrorType5.ServerError,
                "not_implemented" => GetUsageResponseErrorType5.NotImplemented,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetUsageResponseErrorType4
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
    public static class GetUsageResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUsageResponseErrorType4 value)
        {
            return value switch
            {
                GetUsageResponseErrorType4.AuthorizationError => "authorization_error",
                GetUsageResponseErrorType4.ValidationError => "validation_error",
                GetUsageResponseErrorType4.NotFound => "not_found",
                GetUsageResponseErrorType4.RateLimited => "rate_limited",
                GetUsageResponseErrorType4.ServerError => "server_error",
                GetUsageResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUsageResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetUsageResponseErrorType4.AuthorizationError,
                "validation_error" => GetUsageResponseErrorType4.ValidationError,
                "not_found" => GetUsageResponseErrorType4.NotFound,
                "rate_limited" => GetUsageResponseErrorType4.RateLimited,
                "server_error" => GetUsageResponseErrorType4.ServerError,
                "not_implemented" => GetUsageResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}
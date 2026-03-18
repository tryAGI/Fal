
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAnalyticsResponseErrorType3
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
    public static class GetAnalyticsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsResponseErrorType3 value)
        {
            return value switch
            {
                GetAnalyticsResponseErrorType3.AuthorizationError => "authorization_error",
                GetAnalyticsResponseErrorType3.ValidationError => "validation_error",
                GetAnalyticsResponseErrorType3.NotFound => "not_found",
                GetAnalyticsResponseErrorType3.RateLimited => "rate_limited",
                GetAnalyticsResponseErrorType3.ServerError => "server_error",
                GetAnalyticsResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAnalyticsResponseErrorType3.AuthorizationError,
                "validation_error" => GetAnalyticsResponseErrorType3.ValidationError,
                "not_found" => GetAnalyticsResponseErrorType3.NotFound,
                "rate_limited" => GetAnalyticsResponseErrorType3.RateLimited,
                "server_error" => GetAnalyticsResponseErrorType3.ServerError,
                "not_implemented" => GetAnalyticsResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}
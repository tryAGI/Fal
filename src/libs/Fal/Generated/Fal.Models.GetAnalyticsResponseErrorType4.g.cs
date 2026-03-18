
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAnalyticsResponseErrorType4
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
    public static class GetAnalyticsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsResponseErrorType4 value)
        {
            return value switch
            {
                GetAnalyticsResponseErrorType4.AuthorizationError => "authorization_error",
                GetAnalyticsResponseErrorType4.ValidationError => "validation_error",
                GetAnalyticsResponseErrorType4.NotFound => "not_found",
                GetAnalyticsResponseErrorType4.RateLimited => "rate_limited",
                GetAnalyticsResponseErrorType4.ServerError => "server_error",
                GetAnalyticsResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAnalyticsResponseErrorType4.AuthorizationError,
                "validation_error" => GetAnalyticsResponseErrorType4.ValidationError,
                "not_found" => GetAnalyticsResponseErrorType4.NotFound,
                "rate_limited" => GetAnalyticsResponseErrorType4.RateLimited,
                "server_error" => GetAnalyticsResponseErrorType4.ServerError,
                "not_implemented" => GetAnalyticsResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}
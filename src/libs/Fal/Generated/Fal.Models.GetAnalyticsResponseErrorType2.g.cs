
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAnalyticsResponseErrorType2
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
    public static class GetAnalyticsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsResponseErrorType2 value)
        {
            return value switch
            {
                GetAnalyticsResponseErrorType2.AuthorizationError => "authorization_error",
                GetAnalyticsResponseErrorType2.ValidationError => "validation_error",
                GetAnalyticsResponseErrorType2.NotFound => "not_found",
                GetAnalyticsResponseErrorType2.RateLimited => "rate_limited",
                GetAnalyticsResponseErrorType2.ServerError => "server_error",
                GetAnalyticsResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAnalyticsResponseErrorType2.AuthorizationError,
                "validation_error" => GetAnalyticsResponseErrorType2.ValidationError,
                "not_found" => GetAnalyticsResponseErrorType2.NotFound,
                "rate_limited" => GetAnalyticsResponseErrorType2.RateLimited,
                "server_error" => GetAnalyticsResponseErrorType2.ServerError,
                "not_implemented" => GetAnalyticsResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}
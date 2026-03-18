
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAnalyticsResponseErrorType
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
    public static class GetAnalyticsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnalyticsResponseErrorType value)
        {
            return value switch
            {
                GetAnalyticsResponseErrorType.AuthorizationError => "authorization_error",
                GetAnalyticsResponseErrorType.ValidationError => "validation_error",
                GetAnalyticsResponseErrorType.NotFound => "not_found",
                GetAnalyticsResponseErrorType.RateLimited => "rate_limited",
                GetAnalyticsResponseErrorType.ServerError => "server_error",
                GetAnalyticsResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnalyticsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAnalyticsResponseErrorType.AuthorizationError,
                "validation_error" => GetAnalyticsResponseErrorType.ValidationError,
                "not_found" => GetAnalyticsResponseErrorType.NotFound,
                "rate_limited" => GetAnalyticsResponseErrorType.RateLimited,
                "server_error" => GetAnalyticsResponseErrorType.ServerError,
                "not_implemented" => GetAnalyticsResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}
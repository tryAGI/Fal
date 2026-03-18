
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SearchRequestsResponseErrorType
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
    public static class SearchRequestsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestsResponseErrorType value)
        {
            return value switch
            {
                SearchRequestsResponseErrorType.AuthorizationError => "authorization_error",
                SearchRequestsResponseErrorType.ValidationError => "validation_error",
                SearchRequestsResponseErrorType.NotFound => "not_found",
                SearchRequestsResponseErrorType.RateLimited => "rate_limited",
                SearchRequestsResponseErrorType.ServerError => "server_error",
                SearchRequestsResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SearchRequestsResponseErrorType.AuthorizationError,
                "validation_error" => SearchRequestsResponseErrorType.ValidationError,
                "not_found" => SearchRequestsResponseErrorType.NotFound,
                "rate_limited" => SearchRequestsResponseErrorType.RateLimited,
                "server_error" => SearchRequestsResponseErrorType.ServerError,
                "not_implemented" => SearchRequestsResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}
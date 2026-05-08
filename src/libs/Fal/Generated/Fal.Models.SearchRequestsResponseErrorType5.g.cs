
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SearchRequestsResponseErrorType5
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorizationError,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        NotImplemented,
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
        ValidationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRequestsResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestsResponseErrorType5 value)
        {
            return value switch
            {
                SearchRequestsResponseErrorType5.AuthorizationError => "authorization_error",
                SearchRequestsResponseErrorType5.NotFound => "not_found",
                SearchRequestsResponseErrorType5.NotImplemented => "not_implemented",
                SearchRequestsResponseErrorType5.RateLimited => "rate_limited",
                SearchRequestsResponseErrorType5.ServerError => "server_error",
                SearchRequestsResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestsResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SearchRequestsResponseErrorType5.AuthorizationError,
                "not_found" => SearchRequestsResponseErrorType5.NotFound,
                "not_implemented" => SearchRequestsResponseErrorType5.NotImplemented,
                "rate_limited" => SearchRequestsResponseErrorType5.RateLimited,
                "server_error" => SearchRequestsResponseErrorType5.ServerError,
                "validation_error" => SearchRequestsResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
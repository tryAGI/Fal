
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetsResponseErrorType7
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
    public static class ListAssetsResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetsResponseErrorType7 value)
        {
            return value switch
            {
                ListAssetsResponseErrorType7.AuthorizationError => "authorization_error",
                ListAssetsResponseErrorType7.NotFound => "not_found",
                ListAssetsResponseErrorType7.NotImplemented => "not_implemented",
                ListAssetsResponseErrorType7.RateLimited => "rate_limited",
                ListAssetsResponseErrorType7.ServerError => "server_error",
                ListAssetsResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetsResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetsResponseErrorType7.AuthorizationError,
                "not_found" => ListAssetsResponseErrorType7.NotFound,
                "not_implemented" => ListAssetsResponseErrorType7.NotImplemented,
                "rate_limited" => ListAssetsResponseErrorType7.RateLimited,
                "server_error" => ListAssetsResponseErrorType7.ServerError,
                "validation_error" => ListAssetsResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}
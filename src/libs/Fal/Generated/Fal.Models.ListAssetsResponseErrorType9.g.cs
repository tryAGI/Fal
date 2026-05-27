
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetsResponseErrorType9
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
    public static class ListAssetsResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetsResponseErrorType9 value)
        {
            return value switch
            {
                ListAssetsResponseErrorType9.AuthorizationError => "authorization_error",
                ListAssetsResponseErrorType9.NotFound => "not_found",
                ListAssetsResponseErrorType9.NotImplemented => "not_implemented",
                ListAssetsResponseErrorType9.RateLimited => "rate_limited",
                ListAssetsResponseErrorType9.ServerError => "server_error",
                ListAssetsResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetsResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetsResponseErrorType9.AuthorizationError,
                "not_found" => ListAssetsResponseErrorType9.NotFound,
                "not_implemented" => ListAssetsResponseErrorType9.NotImplemented,
                "rate_limited" => ListAssetsResponseErrorType9.RateLimited,
                "server_error" => ListAssetsResponseErrorType9.ServerError,
                "validation_error" => ListAssetsResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}
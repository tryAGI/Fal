
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetsResponseErrorType6
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
    public static class ListAssetsResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetsResponseErrorType6 value)
        {
            return value switch
            {
                ListAssetsResponseErrorType6.AuthorizationError => "authorization_error",
                ListAssetsResponseErrorType6.NotFound => "not_found",
                ListAssetsResponseErrorType6.NotImplemented => "not_implemented",
                ListAssetsResponseErrorType6.RateLimited => "rate_limited",
                ListAssetsResponseErrorType6.ServerError => "server_error",
                ListAssetsResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetsResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetsResponseErrorType6.AuthorizationError,
                "not_found" => ListAssetsResponseErrorType6.NotFound,
                "not_implemented" => ListAssetsResponseErrorType6.NotImplemented,
                "rate_limited" => ListAssetsResponseErrorType6.RateLimited,
                "server_error" => ListAssetsResponseErrorType6.ServerError,
                "validation_error" => ListAssetsResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
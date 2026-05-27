
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetsResponseErrorType4
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
    public static class ListAssetsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetsResponseErrorType4 value)
        {
            return value switch
            {
                ListAssetsResponseErrorType4.AuthorizationError => "authorization_error",
                ListAssetsResponseErrorType4.NotFound => "not_found",
                ListAssetsResponseErrorType4.NotImplemented => "not_implemented",
                ListAssetsResponseErrorType4.RateLimited => "rate_limited",
                ListAssetsResponseErrorType4.ServerError => "server_error",
                ListAssetsResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetsResponseErrorType4.AuthorizationError,
                "not_found" => ListAssetsResponseErrorType4.NotFound,
                "not_implemented" => ListAssetsResponseErrorType4.NotImplemented,
                "rate_limited" => ListAssetsResponseErrorType4.RateLimited,
                "server_error" => ListAssetsResponseErrorType4.ServerError,
                "validation_error" => ListAssetsResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetsResponseErrorType2
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
    public static class ListAssetsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetsResponseErrorType2 value)
        {
            return value switch
            {
                ListAssetsResponseErrorType2.AuthorizationError => "authorization_error",
                ListAssetsResponseErrorType2.NotFound => "not_found",
                ListAssetsResponseErrorType2.NotImplemented => "not_implemented",
                ListAssetsResponseErrorType2.RateLimited => "rate_limited",
                ListAssetsResponseErrorType2.ServerError => "server_error",
                ListAssetsResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetsResponseErrorType2.AuthorizationError,
                "not_found" => ListAssetsResponseErrorType2.NotFound,
                "not_implemented" => ListAssetsResponseErrorType2.NotImplemented,
                "rate_limited" => ListAssetsResponseErrorType2.RateLimited,
                "server_error" => ListAssetsResponseErrorType2.ServerError,
                "validation_error" => ListAssetsResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetsResponseErrorType5
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
    public static class ListAssetsResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetsResponseErrorType5 value)
        {
            return value switch
            {
                ListAssetsResponseErrorType5.AuthorizationError => "authorization_error",
                ListAssetsResponseErrorType5.NotFound => "not_found",
                ListAssetsResponseErrorType5.NotImplemented => "not_implemented",
                ListAssetsResponseErrorType5.RateLimited => "rate_limited",
                ListAssetsResponseErrorType5.ServerError => "server_error",
                ListAssetsResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetsResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetsResponseErrorType5.AuthorizationError,
                "not_found" => ListAssetsResponseErrorType5.NotFound,
                "not_implemented" => ListAssetsResponseErrorType5.NotImplemented,
                "rate_limited" => ListAssetsResponseErrorType5.RateLimited,
                "server_error" => ListAssetsResponseErrorType5.ServerError,
                "validation_error" => ListAssetsResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
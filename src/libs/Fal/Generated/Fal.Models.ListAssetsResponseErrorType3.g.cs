
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetsResponseErrorType3
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
    public static class ListAssetsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetsResponseErrorType3 value)
        {
            return value switch
            {
                ListAssetsResponseErrorType3.AuthorizationError => "authorization_error",
                ListAssetsResponseErrorType3.NotFound => "not_found",
                ListAssetsResponseErrorType3.NotImplemented => "not_implemented",
                ListAssetsResponseErrorType3.RateLimited => "rate_limited",
                ListAssetsResponseErrorType3.ServerError => "server_error",
                ListAssetsResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetsResponseErrorType3.AuthorizationError,
                "not_found" => ListAssetsResponseErrorType3.NotFound,
                "not_implemented" => ListAssetsResponseErrorType3.NotImplemented,
                "rate_limited" => ListAssetsResponseErrorType3.RateLimited,
                "server_error" => ListAssetsResponseErrorType3.ServerError,
                "validation_error" => ListAssetsResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetsResponseErrorType
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
    public static class ListAssetsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetsResponseErrorType value)
        {
            return value switch
            {
                ListAssetsResponseErrorType.AuthorizationError => "authorization_error",
                ListAssetsResponseErrorType.NotFound => "not_found",
                ListAssetsResponseErrorType.NotImplemented => "not_implemented",
                ListAssetsResponseErrorType.RateLimited => "rate_limited",
                ListAssetsResponseErrorType.ServerError => "server_error",
                ListAssetsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetsResponseErrorType.AuthorizationError,
                "not_found" => ListAssetsResponseErrorType.NotFound,
                "not_implemented" => ListAssetsResponseErrorType.NotImplemented,
                "rate_limited" => ListAssetsResponseErrorType.RateLimited,
                "server_error" => ListAssetsResponseErrorType.ServerError,
                "validation_error" => ListAssetsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
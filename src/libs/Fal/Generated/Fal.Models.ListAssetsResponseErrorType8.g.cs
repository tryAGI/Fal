
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetsResponseErrorType8
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
    public static class ListAssetsResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetsResponseErrorType8 value)
        {
            return value switch
            {
                ListAssetsResponseErrorType8.AuthorizationError => "authorization_error",
                ListAssetsResponseErrorType8.NotFound => "not_found",
                ListAssetsResponseErrorType8.NotImplemented => "not_implemented",
                ListAssetsResponseErrorType8.RateLimited => "rate_limited",
                ListAssetsResponseErrorType8.ServerError => "server_error",
                ListAssetsResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetsResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetsResponseErrorType8.AuthorizationError,
                "not_found" => ListAssetsResponseErrorType8.NotFound,
                "not_implemented" => ListAssetsResponseErrorType8.NotImplemented,
                "rate_limited" => ListAssetsResponseErrorType8.RateLimited,
                "server_error" => ListAssetsResponseErrorType8.ServerError,
                "validation_error" => ListAssetsResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
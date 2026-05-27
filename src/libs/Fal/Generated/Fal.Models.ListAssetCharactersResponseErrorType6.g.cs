
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCharactersResponseErrorType6
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
    public static class ListAssetCharactersResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCharactersResponseErrorType6 value)
        {
            return value switch
            {
                ListAssetCharactersResponseErrorType6.AuthorizationError => "authorization_error",
                ListAssetCharactersResponseErrorType6.NotFound => "not_found",
                ListAssetCharactersResponseErrorType6.NotImplemented => "not_implemented",
                ListAssetCharactersResponseErrorType6.RateLimited => "rate_limited",
                ListAssetCharactersResponseErrorType6.ServerError => "server_error",
                ListAssetCharactersResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCharactersResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCharactersResponseErrorType6.AuthorizationError,
                "not_found" => ListAssetCharactersResponseErrorType6.NotFound,
                "not_implemented" => ListAssetCharactersResponseErrorType6.NotImplemented,
                "rate_limited" => ListAssetCharactersResponseErrorType6.RateLimited,
                "server_error" => ListAssetCharactersResponseErrorType6.ServerError,
                "validation_error" => ListAssetCharactersResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
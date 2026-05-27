
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCharactersResponseErrorType9
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
    public static class ListAssetCharactersResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCharactersResponseErrorType9 value)
        {
            return value switch
            {
                ListAssetCharactersResponseErrorType9.AuthorizationError => "authorization_error",
                ListAssetCharactersResponseErrorType9.NotFound => "not_found",
                ListAssetCharactersResponseErrorType9.NotImplemented => "not_implemented",
                ListAssetCharactersResponseErrorType9.RateLimited => "rate_limited",
                ListAssetCharactersResponseErrorType9.ServerError => "server_error",
                ListAssetCharactersResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCharactersResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCharactersResponseErrorType9.AuthorizationError,
                "not_found" => ListAssetCharactersResponseErrorType9.NotFound,
                "not_implemented" => ListAssetCharactersResponseErrorType9.NotImplemented,
                "rate_limited" => ListAssetCharactersResponseErrorType9.RateLimited,
                "server_error" => ListAssetCharactersResponseErrorType9.ServerError,
                "validation_error" => ListAssetCharactersResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCharactersResponseErrorType4
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
    public static class ListAssetCharactersResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCharactersResponseErrorType4 value)
        {
            return value switch
            {
                ListAssetCharactersResponseErrorType4.AuthorizationError => "authorization_error",
                ListAssetCharactersResponseErrorType4.NotFound => "not_found",
                ListAssetCharactersResponseErrorType4.NotImplemented => "not_implemented",
                ListAssetCharactersResponseErrorType4.RateLimited => "rate_limited",
                ListAssetCharactersResponseErrorType4.ServerError => "server_error",
                ListAssetCharactersResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCharactersResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCharactersResponseErrorType4.AuthorizationError,
                "not_found" => ListAssetCharactersResponseErrorType4.NotFound,
                "not_implemented" => ListAssetCharactersResponseErrorType4.NotImplemented,
                "rate_limited" => ListAssetCharactersResponseErrorType4.RateLimited,
                "server_error" => ListAssetCharactersResponseErrorType4.ServerError,
                "validation_error" => ListAssetCharactersResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
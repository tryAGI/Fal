
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCharactersResponseErrorType7
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
    public static class ListAssetCharactersResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCharactersResponseErrorType7 value)
        {
            return value switch
            {
                ListAssetCharactersResponseErrorType7.AuthorizationError => "authorization_error",
                ListAssetCharactersResponseErrorType7.NotFound => "not_found",
                ListAssetCharactersResponseErrorType7.NotImplemented => "not_implemented",
                ListAssetCharactersResponseErrorType7.RateLimited => "rate_limited",
                ListAssetCharactersResponseErrorType7.ServerError => "server_error",
                ListAssetCharactersResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCharactersResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCharactersResponseErrorType7.AuthorizationError,
                "not_found" => ListAssetCharactersResponseErrorType7.NotFound,
                "not_implemented" => ListAssetCharactersResponseErrorType7.NotImplemented,
                "rate_limited" => ListAssetCharactersResponseErrorType7.RateLimited,
                "server_error" => ListAssetCharactersResponseErrorType7.ServerError,
                "validation_error" => ListAssetCharactersResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}
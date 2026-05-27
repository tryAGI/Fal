
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCharactersResponseErrorType5
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
    public static class ListAssetCharactersResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCharactersResponseErrorType5 value)
        {
            return value switch
            {
                ListAssetCharactersResponseErrorType5.AuthorizationError => "authorization_error",
                ListAssetCharactersResponseErrorType5.NotFound => "not_found",
                ListAssetCharactersResponseErrorType5.NotImplemented => "not_implemented",
                ListAssetCharactersResponseErrorType5.RateLimited => "rate_limited",
                ListAssetCharactersResponseErrorType5.ServerError => "server_error",
                ListAssetCharactersResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCharactersResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCharactersResponseErrorType5.AuthorizationError,
                "not_found" => ListAssetCharactersResponseErrorType5.NotFound,
                "not_implemented" => ListAssetCharactersResponseErrorType5.NotImplemented,
                "rate_limited" => ListAssetCharactersResponseErrorType5.RateLimited,
                "server_error" => ListAssetCharactersResponseErrorType5.ServerError,
                "validation_error" => ListAssetCharactersResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
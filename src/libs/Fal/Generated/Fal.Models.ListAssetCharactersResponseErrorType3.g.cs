
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCharactersResponseErrorType3
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
    public static class ListAssetCharactersResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCharactersResponseErrorType3 value)
        {
            return value switch
            {
                ListAssetCharactersResponseErrorType3.AuthorizationError => "authorization_error",
                ListAssetCharactersResponseErrorType3.NotFound => "not_found",
                ListAssetCharactersResponseErrorType3.NotImplemented => "not_implemented",
                ListAssetCharactersResponseErrorType3.RateLimited => "rate_limited",
                ListAssetCharactersResponseErrorType3.ServerError => "server_error",
                ListAssetCharactersResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCharactersResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCharactersResponseErrorType3.AuthorizationError,
                "not_found" => ListAssetCharactersResponseErrorType3.NotFound,
                "not_implemented" => ListAssetCharactersResponseErrorType3.NotImplemented,
                "rate_limited" => ListAssetCharactersResponseErrorType3.RateLimited,
                "server_error" => ListAssetCharactersResponseErrorType3.ServerError,
                "validation_error" => ListAssetCharactersResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
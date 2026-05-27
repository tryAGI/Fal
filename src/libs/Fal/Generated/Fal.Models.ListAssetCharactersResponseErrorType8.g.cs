
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCharactersResponseErrorType8
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
    public static class ListAssetCharactersResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCharactersResponseErrorType8 value)
        {
            return value switch
            {
                ListAssetCharactersResponseErrorType8.AuthorizationError => "authorization_error",
                ListAssetCharactersResponseErrorType8.NotFound => "not_found",
                ListAssetCharactersResponseErrorType8.NotImplemented => "not_implemented",
                ListAssetCharactersResponseErrorType8.RateLimited => "rate_limited",
                ListAssetCharactersResponseErrorType8.ServerError => "server_error",
                ListAssetCharactersResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCharactersResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCharactersResponseErrorType8.AuthorizationError,
                "not_found" => ListAssetCharactersResponseErrorType8.NotFound,
                "not_implemented" => ListAssetCharactersResponseErrorType8.NotImplemented,
                "rate_limited" => ListAssetCharactersResponseErrorType8.RateLimited,
                "server_error" => ListAssetCharactersResponseErrorType8.ServerError,
                "validation_error" => ListAssetCharactersResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
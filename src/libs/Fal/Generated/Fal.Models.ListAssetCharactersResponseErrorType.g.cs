
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCharactersResponseErrorType
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
    public static class ListAssetCharactersResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCharactersResponseErrorType value)
        {
            return value switch
            {
                ListAssetCharactersResponseErrorType.AuthorizationError => "authorization_error",
                ListAssetCharactersResponseErrorType.NotFound => "not_found",
                ListAssetCharactersResponseErrorType.NotImplemented => "not_implemented",
                ListAssetCharactersResponseErrorType.RateLimited => "rate_limited",
                ListAssetCharactersResponseErrorType.ServerError => "server_error",
                ListAssetCharactersResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCharactersResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCharactersResponseErrorType.AuthorizationError,
                "not_found" => ListAssetCharactersResponseErrorType.NotFound,
                "not_implemented" => ListAssetCharactersResponseErrorType.NotImplemented,
                "rate_limited" => ListAssetCharactersResponseErrorType.RateLimited,
                "server_error" => ListAssetCharactersResponseErrorType.ServerError,
                "validation_error" => ListAssetCharactersResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
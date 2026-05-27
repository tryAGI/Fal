
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetCharacterResponseErrorType6
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
    public static class FavoriteAssetCharacterResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetCharacterResponseErrorType6 value)
        {
            return value switch
            {
                FavoriteAssetCharacterResponseErrorType6.AuthorizationError => "authorization_error",
                FavoriteAssetCharacterResponseErrorType6.NotFound => "not_found",
                FavoriteAssetCharacterResponseErrorType6.NotImplemented => "not_implemented",
                FavoriteAssetCharacterResponseErrorType6.RateLimited => "rate_limited",
                FavoriteAssetCharacterResponseErrorType6.ServerError => "server_error",
                FavoriteAssetCharacterResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetCharacterResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetCharacterResponseErrorType6.AuthorizationError,
                "not_found" => FavoriteAssetCharacterResponseErrorType6.NotFound,
                "not_implemented" => FavoriteAssetCharacterResponseErrorType6.NotImplemented,
                "rate_limited" => FavoriteAssetCharacterResponseErrorType6.RateLimited,
                "server_error" => FavoriteAssetCharacterResponseErrorType6.ServerError,
                "validation_error" => FavoriteAssetCharacterResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetCharacterResponseErrorType9
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
    public static class FavoriteAssetCharacterResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetCharacterResponseErrorType9 value)
        {
            return value switch
            {
                FavoriteAssetCharacterResponseErrorType9.AuthorizationError => "authorization_error",
                FavoriteAssetCharacterResponseErrorType9.NotFound => "not_found",
                FavoriteAssetCharacterResponseErrorType9.NotImplemented => "not_implemented",
                FavoriteAssetCharacterResponseErrorType9.RateLimited => "rate_limited",
                FavoriteAssetCharacterResponseErrorType9.ServerError => "server_error",
                FavoriteAssetCharacterResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetCharacterResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetCharacterResponseErrorType9.AuthorizationError,
                "not_found" => FavoriteAssetCharacterResponseErrorType9.NotFound,
                "not_implemented" => FavoriteAssetCharacterResponseErrorType9.NotImplemented,
                "rate_limited" => FavoriteAssetCharacterResponseErrorType9.RateLimited,
                "server_error" => FavoriteAssetCharacterResponseErrorType9.ServerError,
                "validation_error" => FavoriteAssetCharacterResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}
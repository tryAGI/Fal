
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetCharacterResponseErrorType2
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
    public static class FavoriteAssetCharacterResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetCharacterResponseErrorType2 value)
        {
            return value switch
            {
                FavoriteAssetCharacterResponseErrorType2.AuthorizationError => "authorization_error",
                FavoriteAssetCharacterResponseErrorType2.NotFound => "not_found",
                FavoriteAssetCharacterResponseErrorType2.NotImplemented => "not_implemented",
                FavoriteAssetCharacterResponseErrorType2.RateLimited => "rate_limited",
                FavoriteAssetCharacterResponseErrorType2.ServerError => "server_error",
                FavoriteAssetCharacterResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetCharacterResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetCharacterResponseErrorType2.AuthorizationError,
                "not_found" => FavoriteAssetCharacterResponseErrorType2.NotFound,
                "not_implemented" => FavoriteAssetCharacterResponseErrorType2.NotImplemented,
                "rate_limited" => FavoriteAssetCharacterResponseErrorType2.RateLimited,
                "server_error" => FavoriteAssetCharacterResponseErrorType2.ServerError,
                "validation_error" => FavoriteAssetCharacterResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
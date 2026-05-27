
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetCharacterResponseErrorType7
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
    public static class FavoriteAssetCharacterResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetCharacterResponseErrorType7 value)
        {
            return value switch
            {
                FavoriteAssetCharacterResponseErrorType7.AuthorizationError => "authorization_error",
                FavoriteAssetCharacterResponseErrorType7.NotFound => "not_found",
                FavoriteAssetCharacterResponseErrorType7.NotImplemented => "not_implemented",
                FavoriteAssetCharacterResponseErrorType7.RateLimited => "rate_limited",
                FavoriteAssetCharacterResponseErrorType7.ServerError => "server_error",
                FavoriteAssetCharacterResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetCharacterResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetCharacterResponseErrorType7.AuthorizationError,
                "not_found" => FavoriteAssetCharacterResponseErrorType7.NotFound,
                "not_implemented" => FavoriteAssetCharacterResponseErrorType7.NotImplemented,
                "rate_limited" => FavoriteAssetCharacterResponseErrorType7.RateLimited,
                "server_error" => FavoriteAssetCharacterResponseErrorType7.ServerError,
                "validation_error" => FavoriteAssetCharacterResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}
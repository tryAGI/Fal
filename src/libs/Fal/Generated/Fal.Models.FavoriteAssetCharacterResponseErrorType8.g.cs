
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetCharacterResponseErrorType8
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
    public static class FavoriteAssetCharacterResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetCharacterResponseErrorType8 value)
        {
            return value switch
            {
                FavoriteAssetCharacterResponseErrorType8.AuthorizationError => "authorization_error",
                FavoriteAssetCharacterResponseErrorType8.NotFound => "not_found",
                FavoriteAssetCharacterResponseErrorType8.NotImplemented => "not_implemented",
                FavoriteAssetCharacterResponseErrorType8.RateLimited => "rate_limited",
                FavoriteAssetCharacterResponseErrorType8.ServerError => "server_error",
                FavoriteAssetCharacterResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetCharacterResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetCharacterResponseErrorType8.AuthorizationError,
                "not_found" => FavoriteAssetCharacterResponseErrorType8.NotFound,
                "not_implemented" => FavoriteAssetCharacterResponseErrorType8.NotImplemented,
                "rate_limited" => FavoriteAssetCharacterResponseErrorType8.RateLimited,
                "server_error" => FavoriteAssetCharacterResponseErrorType8.ServerError,
                "validation_error" => FavoriteAssetCharacterResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
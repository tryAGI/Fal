
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetCharacterResponseErrorType
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
    public static class FavoriteAssetCharacterResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetCharacterResponseErrorType value)
        {
            return value switch
            {
                FavoriteAssetCharacterResponseErrorType.AuthorizationError => "authorization_error",
                FavoriteAssetCharacterResponseErrorType.NotFound => "not_found",
                FavoriteAssetCharacterResponseErrorType.NotImplemented => "not_implemented",
                FavoriteAssetCharacterResponseErrorType.RateLimited => "rate_limited",
                FavoriteAssetCharacterResponseErrorType.ServerError => "server_error",
                FavoriteAssetCharacterResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetCharacterResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetCharacterResponseErrorType.AuthorizationError,
                "not_found" => FavoriteAssetCharacterResponseErrorType.NotFound,
                "not_implemented" => FavoriteAssetCharacterResponseErrorType.NotImplemented,
                "rate_limited" => FavoriteAssetCharacterResponseErrorType.RateLimited,
                "server_error" => FavoriteAssetCharacterResponseErrorType.ServerError,
                "validation_error" => FavoriteAssetCharacterResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
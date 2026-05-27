
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetCollectionResponseErrorType2
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
    public static class FavoriteAssetCollectionResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetCollectionResponseErrorType2 value)
        {
            return value switch
            {
                FavoriteAssetCollectionResponseErrorType2.AuthorizationError => "authorization_error",
                FavoriteAssetCollectionResponseErrorType2.NotFound => "not_found",
                FavoriteAssetCollectionResponseErrorType2.NotImplemented => "not_implemented",
                FavoriteAssetCollectionResponseErrorType2.RateLimited => "rate_limited",
                FavoriteAssetCollectionResponseErrorType2.ServerError => "server_error",
                FavoriteAssetCollectionResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetCollectionResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetCollectionResponseErrorType2.AuthorizationError,
                "not_found" => FavoriteAssetCollectionResponseErrorType2.NotFound,
                "not_implemented" => FavoriteAssetCollectionResponseErrorType2.NotImplemented,
                "rate_limited" => FavoriteAssetCollectionResponseErrorType2.RateLimited,
                "server_error" => FavoriteAssetCollectionResponseErrorType2.ServerError,
                "validation_error" => FavoriteAssetCollectionResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
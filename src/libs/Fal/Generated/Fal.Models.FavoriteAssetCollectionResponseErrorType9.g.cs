
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetCollectionResponseErrorType9
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
    public static class FavoriteAssetCollectionResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetCollectionResponseErrorType9 value)
        {
            return value switch
            {
                FavoriteAssetCollectionResponseErrorType9.AuthorizationError => "authorization_error",
                FavoriteAssetCollectionResponseErrorType9.NotFound => "not_found",
                FavoriteAssetCollectionResponseErrorType9.NotImplemented => "not_implemented",
                FavoriteAssetCollectionResponseErrorType9.RateLimited => "rate_limited",
                FavoriteAssetCollectionResponseErrorType9.ServerError => "server_error",
                FavoriteAssetCollectionResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetCollectionResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetCollectionResponseErrorType9.AuthorizationError,
                "not_found" => FavoriteAssetCollectionResponseErrorType9.NotFound,
                "not_implemented" => FavoriteAssetCollectionResponseErrorType9.NotImplemented,
                "rate_limited" => FavoriteAssetCollectionResponseErrorType9.RateLimited,
                "server_error" => FavoriteAssetCollectionResponseErrorType9.ServerError,
                "validation_error" => FavoriteAssetCollectionResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}
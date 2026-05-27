
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetCollectionResponseErrorType6
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
    public static class FavoriteAssetCollectionResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetCollectionResponseErrorType6 value)
        {
            return value switch
            {
                FavoriteAssetCollectionResponseErrorType6.AuthorizationError => "authorization_error",
                FavoriteAssetCollectionResponseErrorType6.NotFound => "not_found",
                FavoriteAssetCollectionResponseErrorType6.NotImplemented => "not_implemented",
                FavoriteAssetCollectionResponseErrorType6.RateLimited => "rate_limited",
                FavoriteAssetCollectionResponseErrorType6.ServerError => "server_error",
                FavoriteAssetCollectionResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetCollectionResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetCollectionResponseErrorType6.AuthorizationError,
                "not_found" => FavoriteAssetCollectionResponseErrorType6.NotFound,
                "not_implemented" => FavoriteAssetCollectionResponseErrorType6.NotImplemented,
                "rate_limited" => FavoriteAssetCollectionResponseErrorType6.RateLimited,
                "server_error" => FavoriteAssetCollectionResponseErrorType6.ServerError,
                "validation_error" => FavoriteAssetCollectionResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
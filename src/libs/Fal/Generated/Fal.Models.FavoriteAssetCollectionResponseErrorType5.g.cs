
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetCollectionResponseErrorType5
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
    public static class FavoriteAssetCollectionResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetCollectionResponseErrorType5 value)
        {
            return value switch
            {
                FavoriteAssetCollectionResponseErrorType5.AuthorizationError => "authorization_error",
                FavoriteAssetCollectionResponseErrorType5.NotFound => "not_found",
                FavoriteAssetCollectionResponseErrorType5.NotImplemented => "not_implemented",
                FavoriteAssetCollectionResponseErrorType5.RateLimited => "rate_limited",
                FavoriteAssetCollectionResponseErrorType5.ServerError => "server_error",
                FavoriteAssetCollectionResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetCollectionResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetCollectionResponseErrorType5.AuthorizationError,
                "not_found" => FavoriteAssetCollectionResponseErrorType5.NotFound,
                "not_implemented" => FavoriteAssetCollectionResponseErrorType5.NotImplemented,
                "rate_limited" => FavoriteAssetCollectionResponseErrorType5.RateLimited,
                "server_error" => FavoriteAssetCollectionResponseErrorType5.ServerError,
                "validation_error" => FavoriteAssetCollectionResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
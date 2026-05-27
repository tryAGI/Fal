
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetCollectionResponseErrorType7
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
    public static class FavoriteAssetCollectionResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetCollectionResponseErrorType7 value)
        {
            return value switch
            {
                FavoriteAssetCollectionResponseErrorType7.AuthorizationError => "authorization_error",
                FavoriteAssetCollectionResponseErrorType7.NotFound => "not_found",
                FavoriteAssetCollectionResponseErrorType7.NotImplemented => "not_implemented",
                FavoriteAssetCollectionResponseErrorType7.RateLimited => "rate_limited",
                FavoriteAssetCollectionResponseErrorType7.ServerError => "server_error",
                FavoriteAssetCollectionResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetCollectionResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetCollectionResponseErrorType7.AuthorizationError,
                "not_found" => FavoriteAssetCollectionResponseErrorType7.NotFound,
                "not_implemented" => FavoriteAssetCollectionResponseErrorType7.NotImplemented,
                "rate_limited" => FavoriteAssetCollectionResponseErrorType7.RateLimited,
                "server_error" => FavoriteAssetCollectionResponseErrorType7.ServerError,
                "validation_error" => FavoriteAssetCollectionResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}
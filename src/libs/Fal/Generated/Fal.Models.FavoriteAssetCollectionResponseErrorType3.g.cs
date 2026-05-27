
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetCollectionResponseErrorType3
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
    public static class FavoriteAssetCollectionResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetCollectionResponseErrorType3 value)
        {
            return value switch
            {
                FavoriteAssetCollectionResponseErrorType3.AuthorizationError => "authorization_error",
                FavoriteAssetCollectionResponseErrorType3.NotFound => "not_found",
                FavoriteAssetCollectionResponseErrorType3.NotImplemented => "not_implemented",
                FavoriteAssetCollectionResponseErrorType3.RateLimited => "rate_limited",
                FavoriteAssetCollectionResponseErrorType3.ServerError => "server_error",
                FavoriteAssetCollectionResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetCollectionResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetCollectionResponseErrorType3.AuthorizationError,
                "not_found" => FavoriteAssetCollectionResponseErrorType3.NotFound,
                "not_implemented" => FavoriteAssetCollectionResponseErrorType3.NotImplemented,
                "rate_limited" => FavoriteAssetCollectionResponseErrorType3.RateLimited,
                "server_error" => FavoriteAssetCollectionResponseErrorType3.ServerError,
                "validation_error" => FavoriteAssetCollectionResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
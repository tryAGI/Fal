
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetCollectionResponseErrorType4
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
    public static class FavoriteAssetCollectionResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetCollectionResponseErrorType4 value)
        {
            return value switch
            {
                FavoriteAssetCollectionResponseErrorType4.AuthorizationError => "authorization_error",
                FavoriteAssetCollectionResponseErrorType4.NotFound => "not_found",
                FavoriteAssetCollectionResponseErrorType4.NotImplemented => "not_implemented",
                FavoriteAssetCollectionResponseErrorType4.RateLimited => "rate_limited",
                FavoriteAssetCollectionResponseErrorType4.ServerError => "server_error",
                FavoriteAssetCollectionResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetCollectionResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetCollectionResponseErrorType4.AuthorizationError,
                "not_found" => FavoriteAssetCollectionResponseErrorType4.NotFound,
                "not_implemented" => FavoriteAssetCollectionResponseErrorType4.NotImplemented,
                "rate_limited" => FavoriteAssetCollectionResponseErrorType4.RateLimited,
                "server_error" => FavoriteAssetCollectionResponseErrorType4.ServerError,
                "validation_error" => FavoriteAssetCollectionResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetCollectionResponseErrorType8
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
    public static class FavoriteAssetCollectionResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetCollectionResponseErrorType8 value)
        {
            return value switch
            {
                FavoriteAssetCollectionResponseErrorType8.AuthorizationError => "authorization_error",
                FavoriteAssetCollectionResponseErrorType8.NotFound => "not_found",
                FavoriteAssetCollectionResponseErrorType8.NotImplemented => "not_implemented",
                FavoriteAssetCollectionResponseErrorType8.RateLimited => "rate_limited",
                FavoriteAssetCollectionResponseErrorType8.ServerError => "server_error",
                FavoriteAssetCollectionResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetCollectionResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetCollectionResponseErrorType8.AuthorizationError,
                "not_found" => FavoriteAssetCollectionResponseErrorType8.NotFound,
                "not_implemented" => FavoriteAssetCollectionResponseErrorType8.NotImplemented,
                "rate_limited" => FavoriteAssetCollectionResponseErrorType8.RateLimited,
                "server_error" => FavoriteAssetCollectionResponseErrorType8.ServerError,
                "validation_error" => FavoriteAssetCollectionResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
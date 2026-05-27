
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetCollectionResponseErrorType
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
    public static class FavoriteAssetCollectionResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetCollectionResponseErrorType value)
        {
            return value switch
            {
                FavoriteAssetCollectionResponseErrorType.AuthorizationError => "authorization_error",
                FavoriteAssetCollectionResponseErrorType.NotFound => "not_found",
                FavoriteAssetCollectionResponseErrorType.NotImplemented => "not_implemented",
                FavoriteAssetCollectionResponseErrorType.RateLimited => "rate_limited",
                FavoriteAssetCollectionResponseErrorType.ServerError => "server_error",
                FavoriteAssetCollectionResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetCollectionResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetCollectionResponseErrorType.AuthorizationError,
                "not_found" => FavoriteAssetCollectionResponseErrorType.NotFound,
                "not_implemented" => FavoriteAssetCollectionResponseErrorType.NotImplemented,
                "rate_limited" => FavoriteAssetCollectionResponseErrorType.RateLimited,
                "server_error" => FavoriteAssetCollectionResponseErrorType.ServerError,
                "validation_error" => FavoriteAssetCollectionResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
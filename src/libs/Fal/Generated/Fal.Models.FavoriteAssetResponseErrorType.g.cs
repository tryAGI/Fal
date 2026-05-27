
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetResponseErrorType
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
    public static class FavoriteAssetResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetResponseErrorType value)
        {
            return value switch
            {
                FavoriteAssetResponseErrorType.AuthorizationError => "authorization_error",
                FavoriteAssetResponseErrorType.NotFound => "not_found",
                FavoriteAssetResponseErrorType.NotImplemented => "not_implemented",
                FavoriteAssetResponseErrorType.RateLimited => "rate_limited",
                FavoriteAssetResponseErrorType.ServerError => "server_error",
                FavoriteAssetResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetResponseErrorType.AuthorizationError,
                "not_found" => FavoriteAssetResponseErrorType.NotFound,
                "not_implemented" => FavoriteAssetResponseErrorType.NotImplemented,
                "rate_limited" => FavoriteAssetResponseErrorType.RateLimited,
                "server_error" => FavoriteAssetResponseErrorType.ServerError,
                "validation_error" => FavoriteAssetResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
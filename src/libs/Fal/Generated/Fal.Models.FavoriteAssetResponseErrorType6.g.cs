
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetResponseErrorType6
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
    public static class FavoriteAssetResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetResponseErrorType6 value)
        {
            return value switch
            {
                FavoriteAssetResponseErrorType6.AuthorizationError => "authorization_error",
                FavoriteAssetResponseErrorType6.NotFound => "not_found",
                FavoriteAssetResponseErrorType6.NotImplemented => "not_implemented",
                FavoriteAssetResponseErrorType6.RateLimited => "rate_limited",
                FavoriteAssetResponseErrorType6.ServerError => "server_error",
                FavoriteAssetResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetResponseErrorType6.AuthorizationError,
                "not_found" => FavoriteAssetResponseErrorType6.NotFound,
                "not_implemented" => FavoriteAssetResponseErrorType6.NotImplemented,
                "rate_limited" => FavoriteAssetResponseErrorType6.RateLimited,
                "server_error" => FavoriteAssetResponseErrorType6.ServerError,
                "validation_error" => FavoriteAssetResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
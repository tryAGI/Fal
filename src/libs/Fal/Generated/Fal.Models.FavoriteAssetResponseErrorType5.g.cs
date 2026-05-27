
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetResponseErrorType5
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
    public static class FavoriteAssetResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetResponseErrorType5 value)
        {
            return value switch
            {
                FavoriteAssetResponseErrorType5.AuthorizationError => "authorization_error",
                FavoriteAssetResponseErrorType5.NotFound => "not_found",
                FavoriteAssetResponseErrorType5.NotImplemented => "not_implemented",
                FavoriteAssetResponseErrorType5.RateLimited => "rate_limited",
                FavoriteAssetResponseErrorType5.ServerError => "server_error",
                FavoriteAssetResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetResponseErrorType5.AuthorizationError,
                "not_found" => FavoriteAssetResponseErrorType5.NotFound,
                "not_implemented" => FavoriteAssetResponseErrorType5.NotImplemented,
                "rate_limited" => FavoriteAssetResponseErrorType5.RateLimited,
                "server_error" => FavoriteAssetResponseErrorType5.ServerError,
                "validation_error" => FavoriteAssetResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetResponseErrorType2
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
    public static class FavoriteAssetResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetResponseErrorType2 value)
        {
            return value switch
            {
                FavoriteAssetResponseErrorType2.AuthorizationError => "authorization_error",
                FavoriteAssetResponseErrorType2.NotFound => "not_found",
                FavoriteAssetResponseErrorType2.NotImplemented => "not_implemented",
                FavoriteAssetResponseErrorType2.RateLimited => "rate_limited",
                FavoriteAssetResponseErrorType2.ServerError => "server_error",
                FavoriteAssetResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetResponseErrorType2.AuthorizationError,
                "not_found" => FavoriteAssetResponseErrorType2.NotFound,
                "not_implemented" => FavoriteAssetResponseErrorType2.NotImplemented,
                "rate_limited" => FavoriteAssetResponseErrorType2.RateLimited,
                "server_error" => FavoriteAssetResponseErrorType2.ServerError,
                "validation_error" => FavoriteAssetResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
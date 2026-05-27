
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetResponseErrorType7
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
    public static class FavoriteAssetResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetResponseErrorType7 value)
        {
            return value switch
            {
                FavoriteAssetResponseErrorType7.AuthorizationError => "authorization_error",
                FavoriteAssetResponseErrorType7.NotFound => "not_found",
                FavoriteAssetResponseErrorType7.NotImplemented => "not_implemented",
                FavoriteAssetResponseErrorType7.RateLimited => "rate_limited",
                FavoriteAssetResponseErrorType7.ServerError => "server_error",
                FavoriteAssetResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetResponseErrorType7.AuthorizationError,
                "not_found" => FavoriteAssetResponseErrorType7.NotFound,
                "not_implemented" => FavoriteAssetResponseErrorType7.NotImplemented,
                "rate_limited" => FavoriteAssetResponseErrorType7.RateLimited,
                "server_error" => FavoriteAssetResponseErrorType7.ServerError,
                "validation_error" => FavoriteAssetResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}
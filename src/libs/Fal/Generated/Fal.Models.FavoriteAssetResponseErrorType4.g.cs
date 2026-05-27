
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetResponseErrorType4
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
    public static class FavoriteAssetResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetResponseErrorType4 value)
        {
            return value switch
            {
                FavoriteAssetResponseErrorType4.AuthorizationError => "authorization_error",
                FavoriteAssetResponseErrorType4.NotFound => "not_found",
                FavoriteAssetResponseErrorType4.NotImplemented => "not_implemented",
                FavoriteAssetResponseErrorType4.RateLimited => "rate_limited",
                FavoriteAssetResponseErrorType4.ServerError => "server_error",
                FavoriteAssetResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetResponseErrorType4.AuthorizationError,
                "not_found" => FavoriteAssetResponseErrorType4.NotFound,
                "not_implemented" => FavoriteAssetResponseErrorType4.NotImplemented,
                "rate_limited" => FavoriteAssetResponseErrorType4.RateLimited,
                "server_error" => FavoriteAssetResponseErrorType4.ServerError,
                "validation_error" => FavoriteAssetResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
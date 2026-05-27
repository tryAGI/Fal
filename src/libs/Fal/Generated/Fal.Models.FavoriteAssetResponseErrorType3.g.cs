
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum FavoriteAssetResponseErrorType3
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
    public static class FavoriteAssetResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetResponseErrorType3 value)
        {
            return value switch
            {
                FavoriteAssetResponseErrorType3.AuthorizationError => "authorization_error",
                FavoriteAssetResponseErrorType3.NotFound => "not_found",
                FavoriteAssetResponseErrorType3.NotImplemented => "not_implemented",
                FavoriteAssetResponseErrorType3.RateLimited => "rate_limited",
                FavoriteAssetResponseErrorType3.ServerError => "server_error",
                FavoriteAssetResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => FavoriteAssetResponseErrorType3.AuthorizationError,
                "not_found" => FavoriteAssetResponseErrorType3.NotFound,
                "not_implemented" => FavoriteAssetResponseErrorType3.NotImplemented,
                "rate_limited" => FavoriteAssetResponseErrorType3.RateLimited,
                "server_error" => FavoriteAssetResponseErrorType3.ServerError,
                "validation_error" => FavoriteAssetResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
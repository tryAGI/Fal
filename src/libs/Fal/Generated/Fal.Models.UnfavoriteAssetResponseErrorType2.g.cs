
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetResponseErrorType2
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
    public static class UnfavoriteAssetResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetResponseErrorType2 value)
        {
            return value switch
            {
                UnfavoriteAssetResponseErrorType2.AuthorizationError => "authorization_error",
                UnfavoriteAssetResponseErrorType2.NotFound => "not_found",
                UnfavoriteAssetResponseErrorType2.NotImplemented => "not_implemented",
                UnfavoriteAssetResponseErrorType2.RateLimited => "rate_limited",
                UnfavoriteAssetResponseErrorType2.ServerError => "server_error",
                UnfavoriteAssetResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetResponseErrorType2.AuthorizationError,
                "not_found" => UnfavoriteAssetResponseErrorType2.NotFound,
                "not_implemented" => UnfavoriteAssetResponseErrorType2.NotImplemented,
                "rate_limited" => UnfavoriteAssetResponseErrorType2.RateLimited,
                "server_error" => UnfavoriteAssetResponseErrorType2.ServerError,
                "validation_error" => UnfavoriteAssetResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
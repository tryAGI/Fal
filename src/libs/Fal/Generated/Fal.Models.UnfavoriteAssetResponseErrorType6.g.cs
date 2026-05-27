
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetResponseErrorType6
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
    public static class UnfavoriteAssetResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetResponseErrorType6 value)
        {
            return value switch
            {
                UnfavoriteAssetResponseErrorType6.AuthorizationError => "authorization_error",
                UnfavoriteAssetResponseErrorType6.NotFound => "not_found",
                UnfavoriteAssetResponseErrorType6.NotImplemented => "not_implemented",
                UnfavoriteAssetResponseErrorType6.RateLimited => "rate_limited",
                UnfavoriteAssetResponseErrorType6.ServerError => "server_error",
                UnfavoriteAssetResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetResponseErrorType6.AuthorizationError,
                "not_found" => UnfavoriteAssetResponseErrorType6.NotFound,
                "not_implemented" => UnfavoriteAssetResponseErrorType6.NotImplemented,
                "rate_limited" => UnfavoriteAssetResponseErrorType6.RateLimited,
                "server_error" => UnfavoriteAssetResponseErrorType6.ServerError,
                "validation_error" => UnfavoriteAssetResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetResponseErrorType9
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
    public static class UnfavoriteAssetResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetResponseErrorType9 value)
        {
            return value switch
            {
                UnfavoriteAssetResponseErrorType9.AuthorizationError => "authorization_error",
                UnfavoriteAssetResponseErrorType9.NotFound => "not_found",
                UnfavoriteAssetResponseErrorType9.NotImplemented => "not_implemented",
                UnfavoriteAssetResponseErrorType9.RateLimited => "rate_limited",
                UnfavoriteAssetResponseErrorType9.ServerError => "server_error",
                UnfavoriteAssetResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetResponseErrorType9.AuthorizationError,
                "not_found" => UnfavoriteAssetResponseErrorType9.NotFound,
                "not_implemented" => UnfavoriteAssetResponseErrorType9.NotImplemented,
                "rate_limited" => UnfavoriteAssetResponseErrorType9.RateLimited,
                "server_error" => UnfavoriteAssetResponseErrorType9.ServerError,
                "validation_error" => UnfavoriteAssetResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}
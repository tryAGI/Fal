
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetResponseErrorType5
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
    public static class UnfavoriteAssetResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetResponseErrorType5 value)
        {
            return value switch
            {
                UnfavoriteAssetResponseErrorType5.AuthorizationError => "authorization_error",
                UnfavoriteAssetResponseErrorType5.NotFound => "not_found",
                UnfavoriteAssetResponseErrorType5.NotImplemented => "not_implemented",
                UnfavoriteAssetResponseErrorType5.RateLimited => "rate_limited",
                UnfavoriteAssetResponseErrorType5.ServerError => "server_error",
                UnfavoriteAssetResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetResponseErrorType5.AuthorizationError,
                "not_found" => UnfavoriteAssetResponseErrorType5.NotFound,
                "not_implemented" => UnfavoriteAssetResponseErrorType5.NotImplemented,
                "rate_limited" => UnfavoriteAssetResponseErrorType5.RateLimited,
                "server_error" => UnfavoriteAssetResponseErrorType5.ServerError,
                "validation_error" => UnfavoriteAssetResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
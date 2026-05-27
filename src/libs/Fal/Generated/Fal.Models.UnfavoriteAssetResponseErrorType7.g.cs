
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetResponseErrorType7
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
    public static class UnfavoriteAssetResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetResponseErrorType7 value)
        {
            return value switch
            {
                UnfavoriteAssetResponseErrorType7.AuthorizationError => "authorization_error",
                UnfavoriteAssetResponseErrorType7.NotFound => "not_found",
                UnfavoriteAssetResponseErrorType7.NotImplemented => "not_implemented",
                UnfavoriteAssetResponseErrorType7.RateLimited => "rate_limited",
                UnfavoriteAssetResponseErrorType7.ServerError => "server_error",
                UnfavoriteAssetResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetResponseErrorType7.AuthorizationError,
                "not_found" => UnfavoriteAssetResponseErrorType7.NotFound,
                "not_implemented" => UnfavoriteAssetResponseErrorType7.NotImplemented,
                "rate_limited" => UnfavoriteAssetResponseErrorType7.RateLimited,
                "server_error" => UnfavoriteAssetResponseErrorType7.ServerError,
                "validation_error" => UnfavoriteAssetResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}
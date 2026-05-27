
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetResponseErrorType3
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
    public static class UnfavoriteAssetResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetResponseErrorType3 value)
        {
            return value switch
            {
                UnfavoriteAssetResponseErrorType3.AuthorizationError => "authorization_error",
                UnfavoriteAssetResponseErrorType3.NotFound => "not_found",
                UnfavoriteAssetResponseErrorType3.NotImplemented => "not_implemented",
                UnfavoriteAssetResponseErrorType3.RateLimited => "rate_limited",
                UnfavoriteAssetResponseErrorType3.ServerError => "server_error",
                UnfavoriteAssetResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetResponseErrorType3.AuthorizationError,
                "not_found" => UnfavoriteAssetResponseErrorType3.NotFound,
                "not_implemented" => UnfavoriteAssetResponseErrorType3.NotImplemented,
                "rate_limited" => UnfavoriteAssetResponseErrorType3.RateLimited,
                "server_error" => UnfavoriteAssetResponseErrorType3.ServerError,
                "validation_error" => UnfavoriteAssetResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
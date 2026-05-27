
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetResponseErrorType
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
    public static class UnfavoriteAssetResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetResponseErrorType value)
        {
            return value switch
            {
                UnfavoriteAssetResponseErrorType.AuthorizationError => "authorization_error",
                UnfavoriteAssetResponseErrorType.NotFound => "not_found",
                UnfavoriteAssetResponseErrorType.NotImplemented => "not_implemented",
                UnfavoriteAssetResponseErrorType.RateLimited => "rate_limited",
                UnfavoriteAssetResponseErrorType.ServerError => "server_error",
                UnfavoriteAssetResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetResponseErrorType.AuthorizationError,
                "not_found" => UnfavoriteAssetResponseErrorType.NotFound,
                "not_implemented" => UnfavoriteAssetResponseErrorType.NotImplemented,
                "rate_limited" => UnfavoriteAssetResponseErrorType.RateLimited,
                "server_error" => UnfavoriteAssetResponseErrorType.ServerError,
                "validation_error" => UnfavoriteAssetResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
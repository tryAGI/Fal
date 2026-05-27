
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetResponseErrorType8
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
    public static class UnfavoriteAssetResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetResponseErrorType8 value)
        {
            return value switch
            {
                UnfavoriteAssetResponseErrorType8.AuthorizationError => "authorization_error",
                UnfavoriteAssetResponseErrorType8.NotFound => "not_found",
                UnfavoriteAssetResponseErrorType8.NotImplemented => "not_implemented",
                UnfavoriteAssetResponseErrorType8.RateLimited => "rate_limited",
                UnfavoriteAssetResponseErrorType8.ServerError => "server_error",
                UnfavoriteAssetResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetResponseErrorType8.AuthorizationError,
                "not_found" => UnfavoriteAssetResponseErrorType8.NotFound,
                "not_implemented" => UnfavoriteAssetResponseErrorType8.NotImplemented,
                "rate_limited" => UnfavoriteAssetResponseErrorType8.RateLimited,
                "server_error" => UnfavoriteAssetResponseErrorType8.ServerError,
                "validation_error" => UnfavoriteAssetResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetCharacterResponseErrorType6
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
    public static class UnfavoriteAssetCharacterResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCharacterResponseErrorType6 value)
        {
            return value switch
            {
                UnfavoriteAssetCharacterResponseErrorType6.AuthorizationError => "authorization_error",
                UnfavoriteAssetCharacterResponseErrorType6.NotFound => "not_found",
                UnfavoriteAssetCharacterResponseErrorType6.NotImplemented => "not_implemented",
                UnfavoriteAssetCharacterResponseErrorType6.RateLimited => "rate_limited",
                UnfavoriteAssetCharacterResponseErrorType6.ServerError => "server_error",
                UnfavoriteAssetCharacterResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCharacterResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetCharacterResponseErrorType6.AuthorizationError,
                "not_found" => UnfavoriteAssetCharacterResponseErrorType6.NotFound,
                "not_implemented" => UnfavoriteAssetCharacterResponseErrorType6.NotImplemented,
                "rate_limited" => UnfavoriteAssetCharacterResponseErrorType6.RateLimited,
                "server_error" => UnfavoriteAssetCharacterResponseErrorType6.ServerError,
                "validation_error" => UnfavoriteAssetCharacterResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
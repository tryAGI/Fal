
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetCharacterResponseErrorType9
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
    public static class UnfavoriteAssetCharacterResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCharacterResponseErrorType9 value)
        {
            return value switch
            {
                UnfavoriteAssetCharacterResponseErrorType9.AuthorizationError => "authorization_error",
                UnfavoriteAssetCharacterResponseErrorType9.NotFound => "not_found",
                UnfavoriteAssetCharacterResponseErrorType9.NotImplemented => "not_implemented",
                UnfavoriteAssetCharacterResponseErrorType9.RateLimited => "rate_limited",
                UnfavoriteAssetCharacterResponseErrorType9.ServerError => "server_error",
                UnfavoriteAssetCharacterResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCharacterResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetCharacterResponseErrorType9.AuthorizationError,
                "not_found" => UnfavoriteAssetCharacterResponseErrorType9.NotFound,
                "not_implemented" => UnfavoriteAssetCharacterResponseErrorType9.NotImplemented,
                "rate_limited" => UnfavoriteAssetCharacterResponseErrorType9.RateLimited,
                "server_error" => UnfavoriteAssetCharacterResponseErrorType9.ServerError,
                "validation_error" => UnfavoriteAssetCharacterResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}
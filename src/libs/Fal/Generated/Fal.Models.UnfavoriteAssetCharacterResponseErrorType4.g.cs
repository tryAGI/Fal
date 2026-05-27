
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetCharacterResponseErrorType4
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
    public static class UnfavoriteAssetCharacterResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCharacterResponseErrorType4 value)
        {
            return value switch
            {
                UnfavoriteAssetCharacterResponseErrorType4.AuthorizationError => "authorization_error",
                UnfavoriteAssetCharacterResponseErrorType4.NotFound => "not_found",
                UnfavoriteAssetCharacterResponseErrorType4.NotImplemented => "not_implemented",
                UnfavoriteAssetCharacterResponseErrorType4.RateLimited => "rate_limited",
                UnfavoriteAssetCharacterResponseErrorType4.ServerError => "server_error",
                UnfavoriteAssetCharacterResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCharacterResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetCharacterResponseErrorType4.AuthorizationError,
                "not_found" => UnfavoriteAssetCharacterResponseErrorType4.NotFound,
                "not_implemented" => UnfavoriteAssetCharacterResponseErrorType4.NotImplemented,
                "rate_limited" => UnfavoriteAssetCharacterResponseErrorType4.RateLimited,
                "server_error" => UnfavoriteAssetCharacterResponseErrorType4.ServerError,
                "validation_error" => UnfavoriteAssetCharacterResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
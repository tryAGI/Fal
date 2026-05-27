
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetCharacterResponseErrorType7
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
    public static class UnfavoriteAssetCharacterResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCharacterResponseErrorType7 value)
        {
            return value switch
            {
                UnfavoriteAssetCharacterResponseErrorType7.AuthorizationError => "authorization_error",
                UnfavoriteAssetCharacterResponseErrorType7.NotFound => "not_found",
                UnfavoriteAssetCharacterResponseErrorType7.NotImplemented => "not_implemented",
                UnfavoriteAssetCharacterResponseErrorType7.RateLimited => "rate_limited",
                UnfavoriteAssetCharacterResponseErrorType7.ServerError => "server_error",
                UnfavoriteAssetCharacterResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCharacterResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetCharacterResponseErrorType7.AuthorizationError,
                "not_found" => UnfavoriteAssetCharacterResponseErrorType7.NotFound,
                "not_implemented" => UnfavoriteAssetCharacterResponseErrorType7.NotImplemented,
                "rate_limited" => UnfavoriteAssetCharacterResponseErrorType7.RateLimited,
                "server_error" => UnfavoriteAssetCharacterResponseErrorType7.ServerError,
                "validation_error" => UnfavoriteAssetCharacterResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}
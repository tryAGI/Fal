
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetCharacterResponseErrorType5
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
    public static class UnfavoriteAssetCharacterResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCharacterResponseErrorType5 value)
        {
            return value switch
            {
                UnfavoriteAssetCharacterResponseErrorType5.AuthorizationError => "authorization_error",
                UnfavoriteAssetCharacterResponseErrorType5.NotFound => "not_found",
                UnfavoriteAssetCharacterResponseErrorType5.NotImplemented => "not_implemented",
                UnfavoriteAssetCharacterResponseErrorType5.RateLimited => "rate_limited",
                UnfavoriteAssetCharacterResponseErrorType5.ServerError => "server_error",
                UnfavoriteAssetCharacterResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCharacterResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetCharacterResponseErrorType5.AuthorizationError,
                "not_found" => UnfavoriteAssetCharacterResponseErrorType5.NotFound,
                "not_implemented" => UnfavoriteAssetCharacterResponseErrorType5.NotImplemented,
                "rate_limited" => UnfavoriteAssetCharacterResponseErrorType5.RateLimited,
                "server_error" => UnfavoriteAssetCharacterResponseErrorType5.ServerError,
                "validation_error" => UnfavoriteAssetCharacterResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
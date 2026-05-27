
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetCharacterResponseErrorType3
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
    public static class UnfavoriteAssetCharacterResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCharacterResponseErrorType3 value)
        {
            return value switch
            {
                UnfavoriteAssetCharacterResponseErrorType3.AuthorizationError => "authorization_error",
                UnfavoriteAssetCharacterResponseErrorType3.NotFound => "not_found",
                UnfavoriteAssetCharacterResponseErrorType3.NotImplemented => "not_implemented",
                UnfavoriteAssetCharacterResponseErrorType3.RateLimited => "rate_limited",
                UnfavoriteAssetCharacterResponseErrorType3.ServerError => "server_error",
                UnfavoriteAssetCharacterResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCharacterResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetCharacterResponseErrorType3.AuthorizationError,
                "not_found" => UnfavoriteAssetCharacterResponseErrorType3.NotFound,
                "not_implemented" => UnfavoriteAssetCharacterResponseErrorType3.NotImplemented,
                "rate_limited" => UnfavoriteAssetCharacterResponseErrorType3.RateLimited,
                "server_error" => UnfavoriteAssetCharacterResponseErrorType3.ServerError,
                "validation_error" => UnfavoriteAssetCharacterResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
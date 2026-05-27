
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetCharacterResponseErrorType
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
    public static class UnfavoriteAssetCharacterResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCharacterResponseErrorType value)
        {
            return value switch
            {
                UnfavoriteAssetCharacterResponseErrorType.AuthorizationError => "authorization_error",
                UnfavoriteAssetCharacterResponseErrorType.NotFound => "not_found",
                UnfavoriteAssetCharacterResponseErrorType.NotImplemented => "not_implemented",
                UnfavoriteAssetCharacterResponseErrorType.RateLimited => "rate_limited",
                UnfavoriteAssetCharacterResponseErrorType.ServerError => "server_error",
                UnfavoriteAssetCharacterResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCharacterResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetCharacterResponseErrorType.AuthorizationError,
                "not_found" => UnfavoriteAssetCharacterResponseErrorType.NotFound,
                "not_implemented" => UnfavoriteAssetCharacterResponseErrorType.NotImplemented,
                "rate_limited" => UnfavoriteAssetCharacterResponseErrorType.RateLimited,
                "server_error" => UnfavoriteAssetCharacterResponseErrorType.ServerError,
                "validation_error" => UnfavoriteAssetCharacterResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
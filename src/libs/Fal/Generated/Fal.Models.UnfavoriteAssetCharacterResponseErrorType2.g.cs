
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetCharacterResponseErrorType2
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
    public static class UnfavoriteAssetCharacterResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCharacterResponseErrorType2 value)
        {
            return value switch
            {
                UnfavoriteAssetCharacterResponseErrorType2.AuthorizationError => "authorization_error",
                UnfavoriteAssetCharacterResponseErrorType2.NotFound => "not_found",
                UnfavoriteAssetCharacterResponseErrorType2.NotImplemented => "not_implemented",
                UnfavoriteAssetCharacterResponseErrorType2.RateLimited => "rate_limited",
                UnfavoriteAssetCharacterResponseErrorType2.ServerError => "server_error",
                UnfavoriteAssetCharacterResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCharacterResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetCharacterResponseErrorType2.AuthorizationError,
                "not_found" => UnfavoriteAssetCharacterResponseErrorType2.NotFound,
                "not_implemented" => UnfavoriteAssetCharacterResponseErrorType2.NotImplemented,
                "rate_limited" => UnfavoriteAssetCharacterResponseErrorType2.RateLimited,
                "server_error" => UnfavoriteAssetCharacterResponseErrorType2.ServerError,
                "validation_error" => UnfavoriteAssetCharacterResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
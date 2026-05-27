
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetCharacterResponseErrorType8
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
    public static class UnfavoriteAssetCharacterResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCharacterResponseErrorType8 value)
        {
            return value switch
            {
                UnfavoriteAssetCharacterResponseErrorType8.AuthorizationError => "authorization_error",
                UnfavoriteAssetCharacterResponseErrorType8.NotFound => "not_found",
                UnfavoriteAssetCharacterResponseErrorType8.NotImplemented => "not_implemented",
                UnfavoriteAssetCharacterResponseErrorType8.RateLimited => "rate_limited",
                UnfavoriteAssetCharacterResponseErrorType8.ServerError => "server_error",
                UnfavoriteAssetCharacterResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCharacterResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetCharacterResponseErrorType8.AuthorizationError,
                "not_found" => UnfavoriteAssetCharacterResponseErrorType8.NotFound,
                "not_implemented" => UnfavoriteAssetCharacterResponseErrorType8.NotImplemented,
                "rate_limited" => UnfavoriteAssetCharacterResponseErrorType8.RateLimited,
                "server_error" => UnfavoriteAssetCharacterResponseErrorType8.ServerError,
                "validation_error" => UnfavoriteAssetCharacterResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
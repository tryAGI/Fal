
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetCharacterResponseErrorType7
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
    public static class UpdateAssetCharacterResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetCharacterResponseErrorType7 value)
        {
            return value switch
            {
                UpdateAssetCharacterResponseErrorType7.AuthorizationError => "authorization_error",
                UpdateAssetCharacterResponseErrorType7.NotFound => "not_found",
                UpdateAssetCharacterResponseErrorType7.NotImplemented => "not_implemented",
                UpdateAssetCharacterResponseErrorType7.RateLimited => "rate_limited",
                UpdateAssetCharacterResponseErrorType7.ServerError => "server_error",
                UpdateAssetCharacterResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetCharacterResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetCharacterResponseErrorType7.AuthorizationError,
                "not_found" => UpdateAssetCharacterResponseErrorType7.NotFound,
                "not_implemented" => UpdateAssetCharacterResponseErrorType7.NotImplemented,
                "rate_limited" => UpdateAssetCharacterResponseErrorType7.RateLimited,
                "server_error" => UpdateAssetCharacterResponseErrorType7.ServerError,
                "validation_error" => UpdateAssetCharacterResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}
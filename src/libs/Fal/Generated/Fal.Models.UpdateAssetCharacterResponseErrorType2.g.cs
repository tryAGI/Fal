
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetCharacterResponseErrorType2
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
    public static class UpdateAssetCharacterResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetCharacterResponseErrorType2 value)
        {
            return value switch
            {
                UpdateAssetCharacterResponseErrorType2.AuthorizationError => "authorization_error",
                UpdateAssetCharacterResponseErrorType2.NotFound => "not_found",
                UpdateAssetCharacterResponseErrorType2.NotImplemented => "not_implemented",
                UpdateAssetCharacterResponseErrorType2.RateLimited => "rate_limited",
                UpdateAssetCharacterResponseErrorType2.ServerError => "server_error",
                UpdateAssetCharacterResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetCharacterResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetCharacterResponseErrorType2.AuthorizationError,
                "not_found" => UpdateAssetCharacterResponseErrorType2.NotFound,
                "not_implemented" => UpdateAssetCharacterResponseErrorType2.NotImplemented,
                "rate_limited" => UpdateAssetCharacterResponseErrorType2.RateLimited,
                "server_error" => UpdateAssetCharacterResponseErrorType2.ServerError,
                "validation_error" => UpdateAssetCharacterResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
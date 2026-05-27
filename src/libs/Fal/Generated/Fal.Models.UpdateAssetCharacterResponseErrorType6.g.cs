
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetCharacterResponseErrorType6
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
    public static class UpdateAssetCharacterResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetCharacterResponseErrorType6 value)
        {
            return value switch
            {
                UpdateAssetCharacterResponseErrorType6.AuthorizationError => "authorization_error",
                UpdateAssetCharacterResponseErrorType6.NotFound => "not_found",
                UpdateAssetCharacterResponseErrorType6.NotImplemented => "not_implemented",
                UpdateAssetCharacterResponseErrorType6.RateLimited => "rate_limited",
                UpdateAssetCharacterResponseErrorType6.ServerError => "server_error",
                UpdateAssetCharacterResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetCharacterResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetCharacterResponseErrorType6.AuthorizationError,
                "not_found" => UpdateAssetCharacterResponseErrorType6.NotFound,
                "not_implemented" => UpdateAssetCharacterResponseErrorType6.NotImplemented,
                "rate_limited" => UpdateAssetCharacterResponseErrorType6.RateLimited,
                "server_error" => UpdateAssetCharacterResponseErrorType6.ServerError,
                "validation_error" => UpdateAssetCharacterResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
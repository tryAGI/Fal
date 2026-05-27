
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetCharacterResponseErrorType5
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
    public static class UpdateAssetCharacterResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetCharacterResponseErrorType5 value)
        {
            return value switch
            {
                UpdateAssetCharacterResponseErrorType5.AuthorizationError => "authorization_error",
                UpdateAssetCharacterResponseErrorType5.NotFound => "not_found",
                UpdateAssetCharacterResponseErrorType5.NotImplemented => "not_implemented",
                UpdateAssetCharacterResponseErrorType5.RateLimited => "rate_limited",
                UpdateAssetCharacterResponseErrorType5.ServerError => "server_error",
                UpdateAssetCharacterResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetCharacterResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetCharacterResponseErrorType5.AuthorizationError,
                "not_found" => UpdateAssetCharacterResponseErrorType5.NotFound,
                "not_implemented" => UpdateAssetCharacterResponseErrorType5.NotImplemented,
                "rate_limited" => UpdateAssetCharacterResponseErrorType5.RateLimited,
                "server_error" => UpdateAssetCharacterResponseErrorType5.ServerError,
                "validation_error" => UpdateAssetCharacterResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
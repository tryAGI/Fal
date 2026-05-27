
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetCharacterResponseErrorType3
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
    public static class UpdateAssetCharacterResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetCharacterResponseErrorType3 value)
        {
            return value switch
            {
                UpdateAssetCharacterResponseErrorType3.AuthorizationError => "authorization_error",
                UpdateAssetCharacterResponseErrorType3.NotFound => "not_found",
                UpdateAssetCharacterResponseErrorType3.NotImplemented => "not_implemented",
                UpdateAssetCharacterResponseErrorType3.RateLimited => "rate_limited",
                UpdateAssetCharacterResponseErrorType3.ServerError => "server_error",
                UpdateAssetCharacterResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetCharacterResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetCharacterResponseErrorType3.AuthorizationError,
                "not_found" => UpdateAssetCharacterResponseErrorType3.NotFound,
                "not_implemented" => UpdateAssetCharacterResponseErrorType3.NotImplemented,
                "rate_limited" => UpdateAssetCharacterResponseErrorType3.RateLimited,
                "server_error" => UpdateAssetCharacterResponseErrorType3.ServerError,
                "validation_error" => UpdateAssetCharacterResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
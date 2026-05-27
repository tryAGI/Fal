
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetCharacterResponseErrorType
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
    public static class UpdateAssetCharacterResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetCharacterResponseErrorType value)
        {
            return value switch
            {
                UpdateAssetCharacterResponseErrorType.AuthorizationError => "authorization_error",
                UpdateAssetCharacterResponseErrorType.NotFound => "not_found",
                UpdateAssetCharacterResponseErrorType.NotImplemented => "not_implemented",
                UpdateAssetCharacterResponseErrorType.RateLimited => "rate_limited",
                UpdateAssetCharacterResponseErrorType.ServerError => "server_error",
                UpdateAssetCharacterResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetCharacterResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetCharacterResponseErrorType.AuthorizationError,
                "not_found" => UpdateAssetCharacterResponseErrorType.NotFound,
                "not_implemented" => UpdateAssetCharacterResponseErrorType.NotImplemented,
                "rate_limited" => UpdateAssetCharacterResponseErrorType.RateLimited,
                "server_error" => UpdateAssetCharacterResponseErrorType.ServerError,
                "validation_error" => UpdateAssetCharacterResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetCharacterResponseErrorType8
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
    public static class UpdateAssetCharacterResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetCharacterResponseErrorType8 value)
        {
            return value switch
            {
                UpdateAssetCharacterResponseErrorType8.AuthorizationError => "authorization_error",
                UpdateAssetCharacterResponseErrorType8.NotFound => "not_found",
                UpdateAssetCharacterResponseErrorType8.NotImplemented => "not_implemented",
                UpdateAssetCharacterResponseErrorType8.RateLimited => "rate_limited",
                UpdateAssetCharacterResponseErrorType8.ServerError => "server_error",
                UpdateAssetCharacterResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetCharacterResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetCharacterResponseErrorType8.AuthorizationError,
                "not_found" => UpdateAssetCharacterResponseErrorType8.NotFound,
                "not_implemented" => UpdateAssetCharacterResponseErrorType8.NotImplemented,
                "rate_limited" => UpdateAssetCharacterResponseErrorType8.RateLimited,
                "server_error" => UpdateAssetCharacterResponseErrorType8.ServerError,
                "validation_error" => UpdateAssetCharacterResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
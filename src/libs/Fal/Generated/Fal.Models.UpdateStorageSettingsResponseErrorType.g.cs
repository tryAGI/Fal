
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateStorageSettingsResponseErrorType
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
    public static class UpdateStorageSettingsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateStorageSettingsResponseErrorType value)
        {
            return value switch
            {
                UpdateStorageSettingsResponseErrorType.AuthorizationError => "authorization_error",
                UpdateStorageSettingsResponseErrorType.NotFound => "not_found",
                UpdateStorageSettingsResponseErrorType.NotImplemented => "not_implemented",
                UpdateStorageSettingsResponseErrorType.RateLimited => "rate_limited",
                UpdateStorageSettingsResponseErrorType.ServerError => "server_error",
                UpdateStorageSettingsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateStorageSettingsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateStorageSettingsResponseErrorType.AuthorizationError,
                "not_found" => UpdateStorageSettingsResponseErrorType.NotFound,
                "not_implemented" => UpdateStorageSettingsResponseErrorType.NotImplemented,
                "rate_limited" => UpdateStorageSettingsResponseErrorType.RateLimited,
                "server_error" => UpdateStorageSettingsResponseErrorType.ServerError,
                "validation_error" => UpdateStorageSettingsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
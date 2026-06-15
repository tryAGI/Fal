
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateStorageSettingsResponseErrorType4
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
    public static class UpdateStorageSettingsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateStorageSettingsResponseErrorType4 value)
        {
            return value switch
            {
                UpdateStorageSettingsResponseErrorType4.AuthorizationError => "authorization_error",
                UpdateStorageSettingsResponseErrorType4.NotFound => "not_found",
                UpdateStorageSettingsResponseErrorType4.NotImplemented => "not_implemented",
                UpdateStorageSettingsResponseErrorType4.RateLimited => "rate_limited",
                UpdateStorageSettingsResponseErrorType4.ServerError => "server_error",
                UpdateStorageSettingsResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateStorageSettingsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateStorageSettingsResponseErrorType4.AuthorizationError,
                "not_found" => UpdateStorageSettingsResponseErrorType4.NotFound,
                "not_implemented" => UpdateStorageSettingsResponseErrorType4.NotImplemented,
                "rate_limited" => UpdateStorageSettingsResponseErrorType4.RateLimited,
                "server_error" => UpdateStorageSettingsResponseErrorType4.ServerError,
                "validation_error" => UpdateStorageSettingsResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateStorageSettingsResponseErrorType2
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
    public static class UpdateStorageSettingsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateStorageSettingsResponseErrorType2 value)
        {
            return value switch
            {
                UpdateStorageSettingsResponseErrorType2.AuthorizationError => "authorization_error",
                UpdateStorageSettingsResponseErrorType2.NotFound => "not_found",
                UpdateStorageSettingsResponseErrorType2.NotImplemented => "not_implemented",
                UpdateStorageSettingsResponseErrorType2.RateLimited => "rate_limited",
                UpdateStorageSettingsResponseErrorType2.ServerError => "server_error",
                UpdateStorageSettingsResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateStorageSettingsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateStorageSettingsResponseErrorType2.AuthorizationError,
                "not_found" => UpdateStorageSettingsResponseErrorType2.NotFound,
                "not_implemented" => UpdateStorageSettingsResponseErrorType2.NotImplemented,
                "rate_limited" => UpdateStorageSettingsResponseErrorType2.RateLimited,
                "server_error" => UpdateStorageSettingsResponseErrorType2.ServerError,
                "validation_error" => UpdateStorageSettingsResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
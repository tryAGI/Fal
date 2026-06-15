
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateStorageSettingsResponseErrorType5
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
    public static class UpdateStorageSettingsResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateStorageSettingsResponseErrorType5 value)
        {
            return value switch
            {
                UpdateStorageSettingsResponseErrorType5.AuthorizationError => "authorization_error",
                UpdateStorageSettingsResponseErrorType5.NotFound => "not_found",
                UpdateStorageSettingsResponseErrorType5.NotImplemented => "not_implemented",
                UpdateStorageSettingsResponseErrorType5.RateLimited => "rate_limited",
                UpdateStorageSettingsResponseErrorType5.ServerError => "server_error",
                UpdateStorageSettingsResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateStorageSettingsResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateStorageSettingsResponseErrorType5.AuthorizationError,
                "not_found" => UpdateStorageSettingsResponseErrorType5.NotFound,
                "not_implemented" => UpdateStorageSettingsResponseErrorType5.NotImplemented,
                "rate_limited" => UpdateStorageSettingsResponseErrorType5.RateLimited,
                "server_error" => UpdateStorageSettingsResponseErrorType5.ServerError,
                "validation_error" => UpdateStorageSettingsResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
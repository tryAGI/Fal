
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateStorageSettingsResponseErrorType3
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
    public static class UpdateStorageSettingsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateStorageSettingsResponseErrorType3 value)
        {
            return value switch
            {
                UpdateStorageSettingsResponseErrorType3.AuthorizationError => "authorization_error",
                UpdateStorageSettingsResponseErrorType3.NotFound => "not_found",
                UpdateStorageSettingsResponseErrorType3.NotImplemented => "not_implemented",
                UpdateStorageSettingsResponseErrorType3.RateLimited => "rate_limited",
                UpdateStorageSettingsResponseErrorType3.ServerError => "server_error",
                UpdateStorageSettingsResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateStorageSettingsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateStorageSettingsResponseErrorType3.AuthorizationError,
                "not_found" => UpdateStorageSettingsResponseErrorType3.NotFound,
                "not_implemented" => UpdateStorageSettingsResponseErrorType3.NotImplemented,
                "rate_limited" => UpdateStorageSettingsResponseErrorType3.RateLimited,
                "server_error" => UpdateStorageSettingsResponseErrorType3.ServerError,
                "validation_error" => UpdateStorageSettingsResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
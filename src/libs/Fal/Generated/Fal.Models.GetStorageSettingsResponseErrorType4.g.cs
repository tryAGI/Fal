
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetStorageSettingsResponseErrorType4
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
    public static class GetStorageSettingsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStorageSettingsResponseErrorType4 value)
        {
            return value switch
            {
                GetStorageSettingsResponseErrorType4.AuthorizationError => "authorization_error",
                GetStorageSettingsResponseErrorType4.NotFound => "not_found",
                GetStorageSettingsResponseErrorType4.NotImplemented => "not_implemented",
                GetStorageSettingsResponseErrorType4.RateLimited => "rate_limited",
                GetStorageSettingsResponseErrorType4.ServerError => "server_error",
                GetStorageSettingsResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStorageSettingsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetStorageSettingsResponseErrorType4.AuthorizationError,
                "not_found" => GetStorageSettingsResponseErrorType4.NotFound,
                "not_implemented" => GetStorageSettingsResponseErrorType4.NotImplemented,
                "rate_limited" => GetStorageSettingsResponseErrorType4.RateLimited,
                "server_error" => GetStorageSettingsResponseErrorType4.ServerError,
                "validation_error" => GetStorageSettingsResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
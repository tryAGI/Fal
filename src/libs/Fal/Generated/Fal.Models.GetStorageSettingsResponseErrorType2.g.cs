
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetStorageSettingsResponseErrorType2
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
    public static class GetStorageSettingsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStorageSettingsResponseErrorType2 value)
        {
            return value switch
            {
                GetStorageSettingsResponseErrorType2.AuthorizationError => "authorization_error",
                GetStorageSettingsResponseErrorType2.NotFound => "not_found",
                GetStorageSettingsResponseErrorType2.NotImplemented => "not_implemented",
                GetStorageSettingsResponseErrorType2.RateLimited => "rate_limited",
                GetStorageSettingsResponseErrorType2.ServerError => "server_error",
                GetStorageSettingsResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStorageSettingsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetStorageSettingsResponseErrorType2.AuthorizationError,
                "not_found" => GetStorageSettingsResponseErrorType2.NotFound,
                "not_implemented" => GetStorageSettingsResponseErrorType2.NotImplemented,
                "rate_limited" => GetStorageSettingsResponseErrorType2.RateLimited,
                "server_error" => GetStorageSettingsResponseErrorType2.ServerError,
                "validation_error" => GetStorageSettingsResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
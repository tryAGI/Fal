
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetStorageSettingsResponseErrorType
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
    public static class GetStorageSettingsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStorageSettingsResponseErrorType value)
        {
            return value switch
            {
                GetStorageSettingsResponseErrorType.AuthorizationError => "authorization_error",
                GetStorageSettingsResponseErrorType.NotFound => "not_found",
                GetStorageSettingsResponseErrorType.NotImplemented => "not_implemented",
                GetStorageSettingsResponseErrorType.RateLimited => "rate_limited",
                GetStorageSettingsResponseErrorType.ServerError => "server_error",
                GetStorageSettingsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStorageSettingsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetStorageSettingsResponseErrorType.AuthorizationError,
                "not_found" => GetStorageSettingsResponseErrorType.NotFound,
                "not_implemented" => GetStorageSettingsResponseErrorType.NotImplemented,
                "rate_limited" => GetStorageSettingsResponseErrorType.RateLimited,
                "server_error" => GetStorageSettingsResponseErrorType.ServerError,
                "validation_error" => GetStorageSettingsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
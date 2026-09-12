
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetEntityResponseErrorType
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
    public static class UpdateAssetEntityResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetEntityResponseErrorType value)
        {
            return value switch
            {
                UpdateAssetEntityResponseErrorType.AuthorizationError => "authorization_error",
                UpdateAssetEntityResponseErrorType.NotFound => "not_found",
                UpdateAssetEntityResponseErrorType.NotImplemented => "not_implemented",
                UpdateAssetEntityResponseErrorType.RateLimited => "rate_limited",
                UpdateAssetEntityResponseErrorType.ServerError => "server_error",
                UpdateAssetEntityResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetEntityResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetEntityResponseErrorType.AuthorizationError,
                "not_found" => UpdateAssetEntityResponseErrorType.NotFound,
                "not_implemented" => UpdateAssetEntityResponseErrorType.NotImplemented,
                "rate_limited" => UpdateAssetEntityResponseErrorType.RateLimited,
                "server_error" => UpdateAssetEntityResponseErrorType.ServerError,
                "validation_error" => UpdateAssetEntityResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetEntityResponseErrorType6
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
    public static class UpdateAssetEntityResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetEntityResponseErrorType6 value)
        {
            return value switch
            {
                UpdateAssetEntityResponseErrorType6.AuthorizationError => "authorization_error",
                UpdateAssetEntityResponseErrorType6.NotFound => "not_found",
                UpdateAssetEntityResponseErrorType6.NotImplemented => "not_implemented",
                UpdateAssetEntityResponseErrorType6.RateLimited => "rate_limited",
                UpdateAssetEntityResponseErrorType6.ServerError => "server_error",
                UpdateAssetEntityResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetEntityResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetEntityResponseErrorType6.AuthorizationError,
                "not_found" => UpdateAssetEntityResponseErrorType6.NotFound,
                "not_implemented" => UpdateAssetEntityResponseErrorType6.NotImplemented,
                "rate_limited" => UpdateAssetEntityResponseErrorType6.RateLimited,
                "server_error" => UpdateAssetEntityResponseErrorType6.ServerError,
                "validation_error" => UpdateAssetEntityResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
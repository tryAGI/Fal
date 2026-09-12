
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetEntityResponseErrorType5
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
    public static class UpdateAssetEntityResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetEntityResponseErrorType5 value)
        {
            return value switch
            {
                UpdateAssetEntityResponseErrorType5.AuthorizationError => "authorization_error",
                UpdateAssetEntityResponseErrorType5.NotFound => "not_found",
                UpdateAssetEntityResponseErrorType5.NotImplemented => "not_implemented",
                UpdateAssetEntityResponseErrorType5.RateLimited => "rate_limited",
                UpdateAssetEntityResponseErrorType5.ServerError => "server_error",
                UpdateAssetEntityResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetEntityResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetEntityResponseErrorType5.AuthorizationError,
                "not_found" => UpdateAssetEntityResponseErrorType5.NotFound,
                "not_implemented" => UpdateAssetEntityResponseErrorType5.NotImplemented,
                "rate_limited" => UpdateAssetEntityResponseErrorType5.RateLimited,
                "server_error" => UpdateAssetEntityResponseErrorType5.ServerError,
                "validation_error" => UpdateAssetEntityResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
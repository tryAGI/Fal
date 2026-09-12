
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetEntityResponseErrorType4
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
    public static class UpdateAssetEntityResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetEntityResponseErrorType4 value)
        {
            return value switch
            {
                UpdateAssetEntityResponseErrorType4.AuthorizationError => "authorization_error",
                UpdateAssetEntityResponseErrorType4.NotFound => "not_found",
                UpdateAssetEntityResponseErrorType4.NotImplemented => "not_implemented",
                UpdateAssetEntityResponseErrorType4.RateLimited => "rate_limited",
                UpdateAssetEntityResponseErrorType4.ServerError => "server_error",
                UpdateAssetEntityResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetEntityResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetEntityResponseErrorType4.AuthorizationError,
                "not_found" => UpdateAssetEntityResponseErrorType4.NotFound,
                "not_implemented" => UpdateAssetEntityResponseErrorType4.NotImplemented,
                "rate_limited" => UpdateAssetEntityResponseErrorType4.RateLimited,
                "server_error" => UpdateAssetEntityResponseErrorType4.ServerError,
                "validation_error" => UpdateAssetEntityResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetTagResponseErrorType4
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
    public static class UpdateAssetTagResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetTagResponseErrorType4 value)
        {
            return value switch
            {
                UpdateAssetTagResponseErrorType4.AuthorizationError => "authorization_error",
                UpdateAssetTagResponseErrorType4.NotFound => "not_found",
                UpdateAssetTagResponseErrorType4.NotImplemented => "not_implemented",
                UpdateAssetTagResponseErrorType4.RateLimited => "rate_limited",
                UpdateAssetTagResponseErrorType4.ServerError => "server_error",
                UpdateAssetTagResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetTagResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetTagResponseErrorType4.AuthorizationError,
                "not_found" => UpdateAssetTagResponseErrorType4.NotFound,
                "not_implemented" => UpdateAssetTagResponseErrorType4.NotImplemented,
                "rate_limited" => UpdateAssetTagResponseErrorType4.RateLimited,
                "server_error" => UpdateAssetTagResponseErrorType4.ServerError,
                "validation_error" => UpdateAssetTagResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
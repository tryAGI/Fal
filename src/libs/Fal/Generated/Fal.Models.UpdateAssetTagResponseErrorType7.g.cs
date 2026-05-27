
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetTagResponseErrorType7
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
    public static class UpdateAssetTagResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetTagResponseErrorType7 value)
        {
            return value switch
            {
                UpdateAssetTagResponseErrorType7.AuthorizationError => "authorization_error",
                UpdateAssetTagResponseErrorType7.NotFound => "not_found",
                UpdateAssetTagResponseErrorType7.NotImplemented => "not_implemented",
                UpdateAssetTagResponseErrorType7.RateLimited => "rate_limited",
                UpdateAssetTagResponseErrorType7.ServerError => "server_error",
                UpdateAssetTagResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetTagResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetTagResponseErrorType7.AuthorizationError,
                "not_found" => UpdateAssetTagResponseErrorType7.NotFound,
                "not_implemented" => UpdateAssetTagResponseErrorType7.NotImplemented,
                "rate_limited" => UpdateAssetTagResponseErrorType7.RateLimited,
                "server_error" => UpdateAssetTagResponseErrorType7.ServerError,
                "validation_error" => UpdateAssetTagResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}
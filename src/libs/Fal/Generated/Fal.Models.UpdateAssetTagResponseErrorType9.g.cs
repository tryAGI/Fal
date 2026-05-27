
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetTagResponseErrorType9
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
    public static class UpdateAssetTagResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetTagResponseErrorType9 value)
        {
            return value switch
            {
                UpdateAssetTagResponseErrorType9.AuthorizationError => "authorization_error",
                UpdateAssetTagResponseErrorType9.NotFound => "not_found",
                UpdateAssetTagResponseErrorType9.NotImplemented => "not_implemented",
                UpdateAssetTagResponseErrorType9.RateLimited => "rate_limited",
                UpdateAssetTagResponseErrorType9.ServerError => "server_error",
                UpdateAssetTagResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetTagResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetTagResponseErrorType9.AuthorizationError,
                "not_found" => UpdateAssetTagResponseErrorType9.NotFound,
                "not_implemented" => UpdateAssetTagResponseErrorType9.NotImplemented,
                "rate_limited" => UpdateAssetTagResponseErrorType9.RateLimited,
                "server_error" => UpdateAssetTagResponseErrorType9.ServerError,
                "validation_error" => UpdateAssetTagResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetTagResponseErrorType5
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
    public static class UpdateAssetTagResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetTagResponseErrorType5 value)
        {
            return value switch
            {
                UpdateAssetTagResponseErrorType5.AuthorizationError => "authorization_error",
                UpdateAssetTagResponseErrorType5.NotFound => "not_found",
                UpdateAssetTagResponseErrorType5.NotImplemented => "not_implemented",
                UpdateAssetTagResponseErrorType5.RateLimited => "rate_limited",
                UpdateAssetTagResponseErrorType5.ServerError => "server_error",
                UpdateAssetTagResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetTagResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetTagResponseErrorType5.AuthorizationError,
                "not_found" => UpdateAssetTagResponseErrorType5.NotFound,
                "not_implemented" => UpdateAssetTagResponseErrorType5.NotImplemented,
                "rate_limited" => UpdateAssetTagResponseErrorType5.RateLimited,
                "server_error" => UpdateAssetTagResponseErrorType5.ServerError,
                "validation_error" => UpdateAssetTagResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
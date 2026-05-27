
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetTagResponseErrorType3
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
    public static class UpdateAssetTagResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetTagResponseErrorType3 value)
        {
            return value switch
            {
                UpdateAssetTagResponseErrorType3.AuthorizationError => "authorization_error",
                UpdateAssetTagResponseErrorType3.NotFound => "not_found",
                UpdateAssetTagResponseErrorType3.NotImplemented => "not_implemented",
                UpdateAssetTagResponseErrorType3.RateLimited => "rate_limited",
                UpdateAssetTagResponseErrorType3.ServerError => "server_error",
                UpdateAssetTagResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetTagResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetTagResponseErrorType3.AuthorizationError,
                "not_found" => UpdateAssetTagResponseErrorType3.NotFound,
                "not_implemented" => UpdateAssetTagResponseErrorType3.NotImplemented,
                "rate_limited" => UpdateAssetTagResponseErrorType3.RateLimited,
                "server_error" => UpdateAssetTagResponseErrorType3.ServerError,
                "validation_error" => UpdateAssetTagResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
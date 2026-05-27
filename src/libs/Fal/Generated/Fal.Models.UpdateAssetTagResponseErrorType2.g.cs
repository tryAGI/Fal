
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetTagResponseErrorType2
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
    public static class UpdateAssetTagResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetTagResponseErrorType2 value)
        {
            return value switch
            {
                UpdateAssetTagResponseErrorType2.AuthorizationError => "authorization_error",
                UpdateAssetTagResponseErrorType2.NotFound => "not_found",
                UpdateAssetTagResponseErrorType2.NotImplemented => "not_implemented",
                UpdateAssetTagResponseErrorType2.RateLimited => "rate_limited",
                UpdateAssetTagResponseErrorType2.ServerError => "server_error",
                UpdateAssetTagResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetTagResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetTagResponseErrorType2.AuthorizationError,
                "not_found" => UpdateAssetTagResponseErrorType2.NotFound,
                "not_implemented" => UpdateAssetTagResponseErrorType2.NotImplemented,
                "rate_limited" => UpdateAssetTagResponseErrorType2.RateLimited,
                "server_error" => UpdateAssetTagResponseErrorType2.ServerError,
                "validation_error" => UpdateAssetTagResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
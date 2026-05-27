
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetTagResponseErrorType
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
    public static class UpdateAssetTagResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetTagResponseErrorType value)
        {
            return value switch
            {
                UpdateAssetTagResponseErrorType.AuthorizationError => "authorization_error",
                UpdateAssetTagResponseErrorType.NotFound => "not_found",
                UpdateAssetTagResponseErrorType.NotImplemented => "not_implemented",
                UpdateAssetTagResponseErrorType.RateLimited => "rate_limited",
                UpdateAssetTagResponseErrorType.ServerError => "server_error",
                UpdateAssetTagResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetTagResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetTagResponseErrorType.AuthorizationError,
                "not_found" => UpdateAssetTagResponseErrorType.NotFound,
                "not_implemented" => UpdateAssetTagResponseErrorType.NotImplemented,
                "rate_limited" => UpdateAssetTagResponseErrorType.RateLimited,
                "server_error" => UpdateAssetTagResponseErrorType.ServerError,
                "validation_error" => UpdateAssetTagResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
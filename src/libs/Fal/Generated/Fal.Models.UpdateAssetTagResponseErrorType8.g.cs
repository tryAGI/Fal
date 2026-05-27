
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetTagResponseErrorType8
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
    public static class UpdateAssetTagResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetTagResponseErrorType8 value)
        {
            return value switch
            {
                UpdateAssetTagResponseErrorType8.AuthorizationError => "authorization_error",
                UpdateAssetTagResponseErrorType8.NotFound => "not_found",
                UpdateAssetTagResponseErrorType8.NotImplemented => "not_implemented",
                UpdateAssetTagResponseErrorType8.RateLimited => "rate_limited",
                UpdateAssetTagResponseErrorType8.ServerError => "server_error",
                UpdateAssetTagResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetTagResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetTagResponseErrorType8.AuthorizationError,
                "not_found" => UpdateAssetTagResponseErrorType8.NotFound,
                "not_implemented" => UpdateAssetTagResponseErrorType8.NotImplemented,
                "rate_limited" => UpdateAssetTagResponseErrorType8.RateLimited,
                "server_error" => UpdateAssetTagResponseErrorType8.ServerError,
                "validation_error" => UpdateAssetTagResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
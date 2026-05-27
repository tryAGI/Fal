
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UploadAssetResponseErrorType9
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
    public static class UploadAssetResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadAssetResponseErrorType9 value)
        {
            return value switch
            {
                UploadAssetResponseErrorType9.AuthorizationError => "authorization_error",
                UploadAssetResponseErrorType9.NotFound => "not_found",
                UploadAssetResponseErrorType9.NotImplemented => "not_implemented",
                UploadAssetResponseErrorType9.RateLimited => "rate_limited",
                UploadAssetResponseErrorType9.ServerError => "server_error",
                UploadAssetResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadAssetResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UploadAssetResponseErrorType9.AuthorizationError,
                "not_found" => UploadAssetResponseErrorType9.NotFound,
                "not_implemented" => UploadAssetResponseErrorType9.NotImplemented,
                "rate_limited" => UploadAssetResponseErrorType9.RateLimited,
                "server_error" => UploadAssetResponseErrorType9.ServerError,
                "validation_error" => UploadAssetResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}
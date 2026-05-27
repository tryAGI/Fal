
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UploadAssetResponseErrorType6
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
    public static class UploadAssetResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadAssetResponseErrorType6 value)
        {
            return value switch
            {
                UploadAssetResponseErrorType6.AuthorizationError => "authorization_error",
                UploadAssetResponseErrorType6.NotFound => "not_found",
                UploadAssetResponseErrorType6.NotImplemented => "not_implemented",
                UploadAssetResponseErrorType6.RateLimited => "rate_limited",
                UploadAssetResponseErrorType6.ServerError => "server_error",
                UploadAssetResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadAssetResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UploadAssetResponseErrorType6.AuthorizationError,
                "not_found" => UploadAssetResponseErrorType6.NotFound,
                "not_implemented" => UploadAssetResponseErrorType6.NotImplemented,
                "rate_limited" => UploadAssetResponseErrorType6.RateLimited,
                "server_error" => UploadAssetResponseErrorType6.ServerError,
                "validation_error" => UploadAssetResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UploadAssetResponseErrorType3
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
    public static class UploadAssetResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadAssetResponseErrorType3 value)
        {
            return value switch
            {
                UploadAssetResponseErrorType3.AuthorizationError => "authorization_error",
                UploadAssetResponseErrorType3.NotFound => "not_found",
                UploadAssetResponseErrorType3.NotImplemented => "not_implemented",
                UploadAssetResponseErrorType3.RateLimited => "rate_limited",
                UploadAssetResponseErrorType3.ServerError => "server_error",
                UploadAssetResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadAssetResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UploadAssetResponseErrorType3.AuthorizationError,
                "not_found" => UploadAssetResponseErrorType3.NotFound,
                "not_implemented" => UploadAssetResponseErrorType3.NotImplemented,
                "rate_limited" => UploadAssetResponseErrorType3.RateLimited,
                "server_error" => UploadAssetResponseErrorType3.ServerError,
                "validation_error" => UploadAssetResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
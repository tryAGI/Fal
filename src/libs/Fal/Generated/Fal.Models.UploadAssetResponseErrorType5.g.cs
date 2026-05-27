
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UploadAssetResponseErrorType5
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
    public static class UploadAssetResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadAssetResponseErrorType5 value)
        {
            return value switch
            {
                UploadAssetResponseErrorType5.AuthorizationError => "authorization_error",
                UploadAssetResponseErrorType5.NotFound => "not_found",
                UploadAssetResponseErrorType5.NotImplemented => "not_implemented",
                UploadAssetResponseErrorType5.RateLimited => "rate_limited",
                UploadAssetResponseErrorType5.ServerError => "server_error",
                UploadAssetResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadAssetResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UploadAssetResponseErrorType5.AuthorizationError,
                "not_found" => UploadAssetResponseErrorType5.NotFound,
                "not_implemented" => UploadAssetResponseErrorType5.NotImplemented,
                "rate_limited" => UploadAssetResponseErrorType5.RateLimited,
                "server_error" => UploadAssetResponseErrorType5.ServerError,
                "validation_error" => UploadAssetResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
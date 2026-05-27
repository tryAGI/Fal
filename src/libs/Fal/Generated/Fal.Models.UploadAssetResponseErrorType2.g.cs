
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UploadAssetResponseErrorType2
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
    public static class UploadAssetResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadAssetResponseErrorType2 value)
        {
            return value switch
            {
                UploadAssetResponseErrorType2.AuthorizationError => "authorization_error",
                UploadAssetResponseErrorType2.NotFound => "not_found",
                UploadAssetResponseErrorType2.NotImplemented => "not_implemented",
                UploadAssetResponseErrorType2.RateLimited => "rate_limited",
                UploadAssetResponseErrorType2.ServerError => "server_error",
                UploadAssetResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadAssetResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UploadAssetResponseErrorType2.AuthorizationError,
                "not_found" => UploadAssetResponseErrorType2.NotFound,
                "not_implemented" => UploadAssetResponseErrorType2.NotImplemented,
                "rate_limited" => UploadAssetResponseErrorType2.RateLimited,
                "server_error" => UploadAssetResponseErrorType2.ServerError,
                "validation_error" => UploadAssetResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
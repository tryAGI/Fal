
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UploadAssetResponseErrorType7
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
    public static class UploadAssetResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadAssetResponseErrorType7 value)
        {
            return value switch
            {
                UploadAssetResponseErrorType7.AuthorizationError => "authorization_error",
                UploadAssetResponseErrorType7.NotFound => "not_found",
                UploadAssetResponseErrorType7.NotImplemented => "not_implemented",
                UploadAssetResponseErrorType7.RateLimited => "rate_limited",
                UploadAssetResponseErrorType7.ServerError => "server_error",
                UploadAssetResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadAssetResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UploadAssetResponseErrorType7.AuthorizationError,
                "not_found" => UploadAssetResponseErrorType7.NotFound,
                "not_implemented" => UploadAssetResponseErrorType7.NotImplemented,
                "rate_limited" => UploadAssetResponseErrorType7.RateLimited,
                "server_error" => UploadAssetResponseErrorType7.ServerError,
                "validation_error" => UploadAssetResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}
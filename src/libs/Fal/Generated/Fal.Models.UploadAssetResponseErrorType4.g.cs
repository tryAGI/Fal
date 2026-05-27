
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UploadAssetResponseErrorType4
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
    public static class UploadAssetResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadAssetResponseErrorType4 value)
        {
            return value switch
            {
                UploadAssetResponseErrorType4.AuthorizationError => "authorization_error",
                UploadAssetResponseErrorType4.NotFound => "not_found",
                UploadAssetResponseErrorType4.NotImplemented => "not_implemented",
                UploadAssetResponseErrorType4.RateLimited => "rate_limited",
                UploadAssetResponseErrorType4.ServerError => "server_error",
                UploadAssetResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadAssetResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UploadAssetResponseErrorType4.AuthorizationError,
                "not_found" => UploadAssetResponseErrorType4.NotFound,
                "not_implemented" => UploadAssetResponseErrorType4.NotImplemented,
                "rate_limited" => UploadAssetResponseErrorType4.RateLimited,
                "server_error" => UploadAssetResponseErrorType4.ServerError,
                "validation_error" => UploadAssetResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
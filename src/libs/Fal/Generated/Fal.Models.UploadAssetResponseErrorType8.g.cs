
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UploadAssetResponseErrorType8
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
    public static class UploadAssetResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadAssetResponseErrorType8 value)
        {
            return value switch
            {
                UploadAssetResponseErrorType8.AuthorizationError => "authorization_error",
                UploadAssetResponseErrorType8.NotFound => "not_found",
                UploadAssetResponseErrorType8.NotImplemented => "not_implemented",
                UploadAssetResponseErrorType8.RateLimited => "rate_limited",
                UploadAssetResponseErrorType8.ServerError => "server_error",
                UploadAssetResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadAssetResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UploadAssetResponseErrorType8.AuthorizationError,
                "not_found" => UploadAssetResponseErrorType8.NotFound,
                "not_implemented" => UploadAssetResponseErrorType8.NotImplemented,
                "rate_limited" => UploadAssetResponseErrorType8.RateLimited,
                "server_error" => UploadAssetResponseErrorType8.ServerError,
                "validation_error" => UploadAssetResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
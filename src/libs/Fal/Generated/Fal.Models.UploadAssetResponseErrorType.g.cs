
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UploadAssetResponseErrorType
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
    public static class UploadAssetResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadAssetResponseErrorType value)
        {
            return value switch
            {
                UploadAssetResponseErrorType.AuthorizationError => "authorization_error",
                UploadAssetResponseErrorType.NotFound => "not_found",
                UploadAssetResponseErrorType.NotImplemented => "not_implemented",
                UploadAssetResponseErrorType.RateLimited => "rate_limited",
                UploadAssetResponseErrorType.ServerError => "server_error",
                UploadAssetResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadAssetResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UploadAssetResponseErrorType.AuthorizationError,
                "not_found" => UploadAssetResponseErrorType.NotFound,
                "not_implemented" => UploadAssetResponseErrorType.NotImplemented,
                "rate_limited" => UploadAssetResponseErrorType.RateLimited,
                "server_error" => UploadAssetResponseErrorType.ServerError,
                "validation_error" => UploadAssetResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
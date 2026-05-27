
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetResponseErrorType
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
    public static class DeleteAssetResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetResponseErrorType value)
        {
            return value switch
            {
                DeleteAssetResponseErrorType.AuthorizationError => "authorization_error",
                DeleteAssetResponseErrorType.NotFound => "not_found",
                DeleteAssetResponseErrorType.NotImplemented => "not_implemented",
                DeleteAssetResponseErrorType.RateLimited => "rate_limited",
                DeleteAssetResponseErrorType.ServerError => "server_error",
                DeleteAssetResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetResponseErrorType.AuthorizationError,
                "not_found" => DeleteAssetResponseErrorType.NotFound,
                "not_implemented" => DeleteAssetResponseErrorType.NotImplemented,
                "rate_limited" => DeleteAssetResponseErrorType.RateLimited,
                "server_error" => DeleteAssetResponseErrorType.ServerError,
                "validation_error" => DeleteAssetResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
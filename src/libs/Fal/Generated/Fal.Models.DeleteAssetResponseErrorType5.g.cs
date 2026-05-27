
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetResponseErrorType5
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
    public static class DeleteAssetResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetResponseErrorType5 value)
        {
            return value switch
            {
                DeleteAssetResponseErrorType5.AuthorizationError => "authorization_error",
                DeleteAssetResponseErrorType5.NotFound => "not_found",
                DeleteAssetResponseErrorType5.NotImplemented => "not_implemented",
                DeleteAssetResponseErrorType5.RateLimited => "rate_limited",
                DeleteAssetResponseErrorType5.ServerError => "server_error",
                DeleteAssetResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetResponseErrorType5.AuthorizationError,
                "not_found" => DeleteAssetResponseErrorType5.NotFound,
                "not_implemented" => DeleteAssetResponseErrorType5.NotImplemented,
                "rate_limited" => DeleteAssetResponseErrorType5.RateLimited,
                "server_error" => DeleteAssetResponseErrorType5.ServerError,
                "validation_error" => DeleteAssetResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
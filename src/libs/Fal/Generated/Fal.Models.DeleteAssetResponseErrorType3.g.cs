
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetResponseErrorType3
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
    public static class DeleteAssetResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetResponseErrorType3 value)
        {
            return value switch
            {
                DeleteAssetResponseErrorType3.AuthorizationError => "authorization_error",
                DeleteAssetResponseErrorType3.NotFound => "not_found",
                DeleteAssetResponseErrorType3.NotImplemented => "not_implemented",
                DeleteAssetResponseErrorType3.RateLimited => "rate_limited",
                DeleteAssetResponseErrorType3.ServerError => "server_error",
                DeleteAssetResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetResponseErrorType3.AuthorizationError,
                "not_found" => DeleteAssetResponseErrorType3.NotFound,
                "not_implemented" => DeleteAssetResponseErrorType3.NotImplemented,
                "rate_limited" => DeleteAssetResponseErrorType3.RateLimited,
                "server_error" => DeleteAssetResponseErrorType3.ServerError,
                "validation_error" => DeleteAssetResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetResponseErrorType9
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
    public static class DeleteAssetResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetResponseErrorType9 value)
        {
            return value switch
            {
                DeleteAssetResponseErrorType9.AuthorizationError => "authorization_error",
                DeleteAssetResponseErrorType9.NotFound => "not_found",
                DeleteAssetResponseErrorType9.NotImplemented => "not_implemented",
                DeleteAssetResponseErrorType9.RateLimited => "rate_limited",
                DeleteAssetResponseErrorType9.ServerError => "server_error",
                DeleteAssetResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetResponseErrorType9.AuthorizationError,
                "not_found" => DeleteAssetResponseErrorType9.NotFound,
                "not_implemented" => DeleteAssetResponseErrorType9.NotImplemented,
                "rate_limited" => DeleteAssetResponseErrorType9.RateLimited,
                "server_error" => DeleteAssetResponseErrorType9.ServerError,
                "validation_error" => DeleteAssetResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}
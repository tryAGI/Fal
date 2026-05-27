
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetResponseErrorType4
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
    public static class DeleteAssetResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetResponseErrorType4 value)
        {
            return value switch
            {
                DeleteAssetResponseErrorType4.AuthorizationError => "authorization_error",
                DeleteAssetResponseErrorType4.NotFound => "not_found",
                DeleteAssetResponseErrorType4.NotImplemented => "not_implemented",
                DeleteAssetResponseErrorType4.RateLimited => "rate_limited",
                DeleteAssetResponseErrorType4.ServerError => "server_error",
                DeleteAssetResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetResponseErrorType4.AuthorizationError,
                "not_found" => DeleteAssetResponseErrorType4.NotFound,
                "not_implemented" => DeleteAssetResponseErrorType4.NotImplemented,
                "rate_limited" => DeleteAssetResponseErrorType4.RateLimited,
                "server_error" => DeleteAssetResponseErrorType4.ServerError,
                "validation_error" => DeleteAssetResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
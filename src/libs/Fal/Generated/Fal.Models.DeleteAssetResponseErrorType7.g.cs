
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetResponseErrorType7
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
    public static class DeleteAssetResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetResponseErrorType7 value)
        {
            return value switch
            {
                DeleteAssetResponseErrorType7.AuthorizationError => "authorization_error",
                DeleteAssetResponseErrorType7.NotFound => "not_found",
                DeleteAssetResponseErrorType7.NotImplemented => "not_implemented",
                DeleteAssetResponseErrorType7.RateLimited => "rate_limited",
                DeleteAssetResponseErrorType7.ServerError => "server_error",
                DeleteAssetResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetResponseErrorType7.AuthorizationError,
                "not_found" => DeleteAssetResponseErrorType7.NotFound,
                "not_implemented" => DeleteAssetResponseErrorType7.NotImplemented,
                "rate_limited" => DeleteAssetResponseErrorType7.RateLimited,
                "server_error" => DeleteAssetResponseErrorType7.ServerError,
                "validation_error" => DeleteAssetResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}
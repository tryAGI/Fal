
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetResponseErrorType2
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
    public static class DeleteAssetResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetResponseErrorType2 value)
        {
            return value switch
            {
                DeleteAssetResponseErrorType2.AuthorizationError => "authorization_error",
                DeleteAssetResponseErrorType2.NotFound => "not_found",
                DeleteAssetResponseErrorType2.NotImplemented => "not_implemented",
                DeleteAssetResponseErrorType2.RateLimited => "rate_limited",
                DeleteAssetResponseErrorType2.ServerError => "server_error",
                DeleteAssetResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetResponseErrorType2.AuthorizationError,
                "not_found" => DeleteAssetResponseErrorType2.NotFound,
                "not_implemented" => DeleteAssetResponseErrorType2.NotImplemented,
                "rate_limited" => DeleteAssetResponseErrorType2.RateLimited,
                "server_error" => DeleteAssetResponseErrorType2.ServerError,
                "validation_error" => DeleteAssetResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
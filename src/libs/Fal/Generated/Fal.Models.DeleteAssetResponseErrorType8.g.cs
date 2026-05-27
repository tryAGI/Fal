
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetResponseErrorType8
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
    public static class DeleteAssetResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetResponseErrorType8 value)
        {
            return value switch
            {
                DeleteAssetResponseErrorType8.AuthorizationError => "authorization_error",
                DeleteAssetResponseErrorType8.NotFound => "not_found",
                DeleteAssetResponseErrorType8.NotImplemented => "not_implemented",
                DeleteAssetResponseErrorType8.RateLimited => "rate_limited",
                DeleteAssetResponseErrorType8.ServerError => "server_error",
                DeleteAssetResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetResponseErrorType8.AuthorizationError,
                "not_found" => DeleteAssetResponseErrorType8.NotFound,
                "not_implemented" => DeleteAssetResponseErrorType8.NotImplemented,
                "rate_limited" => DeleteAssetResponseErrorType8.RateLimited,
                "server_error" => DeleteAssetResponseErrorType8.ServerError,
                "validation_error" => DeleteAssetResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
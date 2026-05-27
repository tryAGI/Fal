
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetTagResponseErrorType2
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
    public static class DeleteAssetTagResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetTagResponseErrorType2 value)
        {
            return value switch
            {
                DeleteAssetTagResponseErrorType2.AuthorizationError => "authorization_error",
                DeleteAssetTagResponseErrorType2.NotFound => "not_found",
                DeleteAssetTagResponseErrorType2.NotImplemented => "not_implemented",
                DeleteAssetTagResponseErrorType2.RateLimited => "rate_limited",
                DeleteAssetTagResponseErrorType2.ServerError => "server_error",
                DeleteAssetTagResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetTagResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetTagResponseErrorType2.AuthorizationError,
                "not_found" => DeleteAssetTagResponseErrorType2.NotFound,
                "not_implemented" => DeleteAssetTagResponseErrorType2.NotImplemented,
                "rate_limited" => DeleteAssetTagResponseErrorType2.RateLimited,
                "server_error" => DeleteAssetTagResponseErrorType2.ServerError,
                "validation_error" => DeleteAssetTagResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
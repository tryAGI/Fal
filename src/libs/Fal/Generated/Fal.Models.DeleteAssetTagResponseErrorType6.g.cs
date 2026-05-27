
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetTagResponseErrorType6
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
    public static class DeleteAssetTagResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetTagResponseErrorType6 value)
        {
            return value switch
            {
                DeleteAssetTagResponseErrorType6.AuthorizationError => "authorization_error",
                DeleteAssetTagResponseErrorType6.NotFound => "not_found",
                DeleteAssetTagResponseErrorType6.NotImplemented => "not_implemented",
                DeleteAssetTagResponseErrorType6.RateLimited => "rate_limited",
                DeleteAssetTagResponseErrorType6.ServerError => "server_error",
                DeleteAssetTagResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetTagResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetTagResponseErrorType6.AuthorizationError,
                "not_found" => DeleteAssetTagResponseErrorType6.NotFound,
                "not_implemented" => DeleteAssetTagResponseErrorType6.NotImplemented,
                "rate_limited" => DeleteAssetTagResponseErrorType6.RateLimited,
                "server_error" => DeleteAssetTagResponseErrorType6.ServerError,
                "validation_error" => DeleteAssetTagResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
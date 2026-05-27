
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetTagResponseErrorType9
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
    public static class DeleteAssetTagResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetTagResponseErrorType9 value)
        {
            return value switch
            {
                DeleteAssetTagResponseErrorType9.AuthorizationError => "authorization_error",
                DeleteAssetTagResponseErrorType9.NotFound => "not_found",
                DeleteAssetTagResponseErrorType9.NotImplemented => "not_implemented",
                DeleteAssetTagResponseErrorType9.RateLimited => "rate_limited",
                DeleteAssetTagResponseErrorType9.ServerError => "server_error",
                DeleteAssetTagResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetTagResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetTagResponseErrorType9.AuthorizationError,
                "not_found" => DeleteAssetTagResponseErrorType9.NotFound,
                "not_implemented" => DeleteAssetTagResponseErrorType9.NotImplemented,
                "rate_limited" => DeleteAssetTagResponseErrorType9.RateLimited,
                "server_error" => DeleteAssetTagResponseErrorType9.ServerError,
                "validation_error" => DeleteAssetTagResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}
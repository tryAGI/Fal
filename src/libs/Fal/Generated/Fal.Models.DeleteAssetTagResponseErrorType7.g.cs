
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetTagResponseErrorType7
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
    public static class DeleteAssetTagResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetTagResponseErrorType7 value)
        {
            return value switch
            {
                DeleteAssetTagResponseErrorType7.AuthorizationError => "authorization_error",
                DeleteAssetTagResponseErrorType7.NotFound => "not_found",
                DeleteAssetTagResponseErrorType7.NotImplemented => "not_implemented",
                DeleteAssetTagResponseErrorType7.RateLimited => "rate_limited",
                DeleteAssetTagResponseErrorType7.ServerError => "server_error",
                DeleteAssetTagResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetTagResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetTagResponseErrorType7.AuthorizationError,
                "not_found" => DeleteAssetTagResponseErrorType7.NotFound,
                "not_implemented" => DeleteAssetTagResponseErrorType7.NotImplemented,
                "rate_limited" => DeleteAssetTagResponseErrorType7.RateLimited,
                "server_error" => DeleteAssetTagResponseErrorType7.ServerError,
                "validation_error" => DeleteAssetTagResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}
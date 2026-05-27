
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetTagResponseErrorType5
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
    public static class DeleteAssetTagResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetTagResponseErrorType5 value)
        {
            return value switch
            {
                DeleteAssetTagResponseErrorType5.AuthorizationError => "authorization_error",
                DeleteAssetTagResponseErrorType5.NotFound => "not_found",
                DeleteAssetTagResponseErrorType5.NotImplemented => "not_implemented",
                DeleteAssetTagResponseErrorType5.RateLimited => "rate_limited",
                DeleteAssetTagResponseErrorType5.ServerError => "server_error",
                DeleteAssetTagResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetTagResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetTagResponseErrorType5.AuthorizationError,
                "not_found" => DeleteAssetTagResponseErrorType5.NotFound,
                "not_implemented" => DeleteAssetTagResponseErrorType5.NotImplemented,
                "rate_limited" => DeleteAssetTagResponseErrorType5.RateLimited,
                "server_error" => DeleteAssetTagResponseErrorType5.ServerError,
                "validation_error" => DeleteAssetTagResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
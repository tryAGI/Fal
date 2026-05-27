
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetTagResponseErrorType3
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
    public static class DeleteAssetTagResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetTagResponseErrorType3 value)
        {
            return value switch
            {
                DeleteAssetTagResponseErrorType3.AuthorizationError => "authorization_error",
                DeleteAssetTagResponseErrorType3.NotFound => "not_found",
                DeleteAssetTagResponseErrorType3.NotImplemented => "not_implemented",
                DeleteAssetTagResponseErrorType3.RateLimited => "rate_limited",
                DeleteAssetTagResponseErrorType3.ServerError => "server_error",
                DeleteAssetTagResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetTagResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetTagResponseErrorType3.AuthorizationError,
                "not_found" => DeleteAssetTagResponseErrorType3.NotFound,
                "not_implemented" => DeleteAssetTagResponseErrorType3.NotImplemented,
                "rate_limited" => DeleteAssetTagResponseErrorType3.RateLimited,
                "server_error" => DeleteAssetTagResponseErrorType3.ServerError,
                "validation_error" => DeleteAssetTagResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
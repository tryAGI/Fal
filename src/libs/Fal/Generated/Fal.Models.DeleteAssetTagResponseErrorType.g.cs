
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetTagResponseErrorType
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
    public static class DeleteAssetTagResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetTagResponseErrorType value)
        {
            return value switch
            {
                DeleteAssetTagResponseErrorType.AuthorizationError => "authorization_error",
                DeleteAssetTagResponseErrorType.NotFound => "not_found",
                DeleteAssetTagResponseErrorType.NotImplemented => "not_implemented",
                DeleteAssetTagResponseErrorType.RateLimited => "rate_limited",
                DeleteAssetTagResponseErrorType.ServerError => "server_error",
                DeleteAssetTagResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetTagResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetTagResponseErrorType.AuthorizationError,
                "not_found" => DeleteAssetTagResponseErrorType.NotFound,
                "not_implemented" => DeleteAssetTagResponseErrorType.NotImplemented,
                "rate_limited" => DeleteAssetTagResponseErrorType.RateLimited,
                "server_error" => DeleteAssetTagResponseErrorType.ServerError,
                "validation_error" => DeleteAssetTagResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
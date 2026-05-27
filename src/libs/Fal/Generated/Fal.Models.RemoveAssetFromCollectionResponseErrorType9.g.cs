
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum RemoveAssetFromCollectionResponseErrorType9
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
    public static class RemoveAssetFromCollectionResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveAssetFromCollectionResponseErrorType9 value)
        {
            return value switch
            {
                RemoveAssetFromCollectionResponseErrorType9.AuthorizationError => "authorization_error",
                RemoveAssetFromCollectionResponseErrorType9.NotFound => "not_found",
                RemoveAssetFromCollectionResponseErrorType9.NotImplemented => "not_implemented",
                RemoveAssetFromCollectionResponseErrorType9.RateLimited => "rate_limited",
                RemoveAssetFromCollectionResponseErrorType9.ServerError => "server_error",
                RemoveAssetFromCollectionResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveAssetFromCollectionResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => RemoveAssetFromCollectionResponseErrorType9.AuthorizationError,
                "not_found" => RemoveAssetFromCollectionResponseErrorType9.NotFound,
                "not_implemented" => RemoveAssetFromCollectionResponseErrorType9.NotImplemented,
                "rate_limited" => RemoveAssetFromCollectionResponseErrorType9.RateLimited,
                "server_error" => RemoveAssetFromCollectionResponseErrorType9.ServerError,
                "validation_error" => RemoveAssetFromCollectionResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}
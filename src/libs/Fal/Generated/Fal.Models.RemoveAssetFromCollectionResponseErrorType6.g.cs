
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum RemoveAssetFromCollectionResponseErrorType6
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
    public static class RemoveAssetFromCollectionResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveAssetFromCollectionResponseErrorType6 value)
        {
            return value switch
            {
                RemoveAssetFromCollectionResponseErrorType6.AuthorizationError => "authorization_error",
                RemoveAssetFromCollectionResponseErrorType6.NotFound => "not_found",
                RemoveAssetFromCollectionResponseErrorType6.NotImplemented => "not_implemented",
                RemoveAssetFromCollectionResponseErrorType6.RateLimited => "rate_limited",
                RemoveAssetFromCollectionResponseErrorType6.ServerError => "server_error",
                RemoveAssetFromCollectionResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveAssetFromCollectionResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => RemoveAssetFromCollectionResponseErrorType6.AuthorizationError,
                "not_found" => RemoveAssetFromCollectionResponseErrorType6.NotFound,
                "not_implemented" => RemoveAssetFromCollectionResponseErrorType6.NotImplemented,
                "rate_limited" => RemoveAssetFromCollectionResponseErrorType6.RateLimited,
                "server_error" => RemoveAssetFromCollectionResponseErrorType6.ServerError,
                "validation_error" => RemoveAssetFromCollectionResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
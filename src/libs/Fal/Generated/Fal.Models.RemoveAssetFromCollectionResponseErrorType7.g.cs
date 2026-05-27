
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum RemoveAssetFromCollectionResponseErrorType7
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
    public static class RemoveAssetFromCollectionResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveAssetFromCollectionResponseErrorType7 value)
        {
            return value switch
            {
                RemoveAssetFromCollectionResponseErrorType7.AuthorizationError => "authorization_error",
                RemoveAssetFromCollectionResponseErrorType7.NotFound => "not_found",
                RemoveAssetFromCollectionResponseErrorType7.NotImplemented => "not_implemented",
                RemoveAssetFromCollectionResponseErrorType7.RateLimited => "rate_limited",
                RemoveAssetFromCollectionResponseErrorType7.ServerError => "server_error",
                RemoveAssetFromCollectionResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveAssetFromCollectionResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => RemoveAssetFromCollectionResponseErrorType7.AuthorizationError,
                "not_found" => RemoveAssetFromCollectionResponseErrorType7.NotFound,
                "not_implemented" => RemoveAssetFromCollectionResponseErrorType7.NotImplemented,
                "rate_limited" => RemoveAssetFromCollectionResponseErrorType7.RateLimited,
                "server_error" => RemoveAssetFromCollectionResponseErrorType7.ServerError,
                "validation_error" => RemoveAssetFromCollectionResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}
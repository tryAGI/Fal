
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum RemoveAssetFromCollectionResponseErrorType5
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
    public static class RemoveAssetFromCollectionResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveAssetFromCollectionResponseErrorType5 value)
        {
            return value switch
            {
                RemoveAssetFromCollectionResponseErrorType5.AuthorizationError => "authorization_error",
                RemoveAssetFromCollectionResponseErrorType5.NotFound => "not_found",
                RemoveAssetFromCollectionResponseErrorType5.NotImplemented => "not_implemented",
                RemoveAssetFromCollectionResponseErrorType5.RateLimited => "rate_limited",
                RemoveAssetFromCollectionResponseErrorType5.ServerError => "server_error",
                RemoveAssetFromCollectionResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveAssetFromCollectionResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => RemoveAssetFromCollectionResponseErrorType5.AuthorizationError,
                "not_found" => RemoveAssetFromCollectionResponseErrorType5.NotFound,
                "not_implemented" => RemoveAssetFromCollectionResponseErrorType5.NotImplemented,
                "rate_limited" => RemoveAssetFromCollectionResponseErrorType5.RateLimited,
                "server_error" => RemoveAssetFromCollectionResponseErrorType5.ServerError,
                "validation_error" => RemoveAssetFromCollectionResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum RemoveAssetFromCollectionResponseErrorType
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
    public static class RemoveAssetFromCollectionResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveAssetFromCollectionResponseErrorType value)
        {
            return value switch
            {
                RemoveAssetFromCollectionResponseErrorType.AuthorizationError => "authorization_error",
                RemoveAssetFromCollectionResponseErrorType.NotFound => "not_found",
                RemoveAssetFromCollectionResponseErrorType.NotImplemented => "not_implemented",
                RemoveAssetFromCollectionResponseErrorType.RateLimited => "rate_limited",
                RemoveAssetFromCollectionResponseErrorType.ServerError => "server_error",
                RemoveAssetFromCollectionResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveAssetFromCollectionResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => RemoveAssetFromCollectionResponseErrorType.AuthorizationError,
                "not_found" => RemoveAssetFromCollectionResponseErrorType.NotFound,
                "not_implemented" => RemoveAssetFromCollectionResponseErrorType.NotImplemented,
                "rate_limited" => RemoveAssetFromCollectionResponseErrorType.RateLimited,
                "server_error" => RemoveAssetFromCollectionResponseErrorType.ServerError,
                "validation_error" => RemoveAssetFromCollectionResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
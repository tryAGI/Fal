
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum RemoveAssetFromCollectionResponseErrorType4
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
    public static class RemoveAssetFromCollectionResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveAssetFromCollectionResponseErrorType4 value)
        {
            return value switch
            {
                RemoveAssetFromCollectionResponseErrorType4.AuthorizationError => "authorization_error",
                RemoveAssetFromCollectionResponseErrorType4.NotFound => "not_found",
                RemoveAssetFromCollectionResponseErrorType4.NotImplemented => "not_implemented",
                RemoveAssetFromCollectionResponseErrorType4.RateLimited => "rate_limited",
                RemoveAssetFromCollectionResponseErrorType4.ServerError => "server_error",
                RemoveAssetFromCollectionResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveAssetFromCollectionResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => RemoveAssetFromCollectionResponseErrorType4.AuthorizationError,
                "not_found" => RemoveAssetFromCollectionResponseErrorType4.NotFound,
                "not_implemented" => RemoveAssetFromCollectionResponseErrorType4.NotImplemented,
                "rate_limited" => RemoveAssetFromCollectionResponseErrorType4.RateLimited,
                "server_error" => RemoveAssetFromCollectionResponseErrorType4.ServerError,
                "validation_error" => RemoveAssetFromCollectionResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
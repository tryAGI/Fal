
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum RemoveAssetFromCollectionResponseErrorType8
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
    public static class RemoveAssetFromCollectionResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemoveAssetFromCollectionResponseErrorType8 value)
        {
            return value switch
            {
                RemoveAssetFromCollectionResponseErrorType8.AuthorizationError => "authorization_error",
                RemoveAssetFromCollectionResponseErrorType8.NotFound => "not_found",
                RemoveAssetFromCollectionResponseErrorType8.NotImplemented => "not_implemented",
                RemoveAssetFromCollectionResponseErrorType8.RateLimited => "rate_limited",
                RemoveAssetFromCollectionResponseErrorType8.ServerError => "server_error",
                RemoveAssetFromCollectionResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemoveAssetFromCollectionResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => RemoveAssetFromCollectionResponseErrorType8.AuthorizationError,
                "not_found" => RemoveAssetFromCollectionResponseErrorType8.NotFound,
                "not_implemented" => RemoveAssetFromCollectionResponseErrorType8.NotImplemented,
                "rate_limited" => RemoveAssetFromCollectionResponseErrorType8.RateLimited,
                "server_error" => RemoveAssetFromCollectionResponseErrorType8.ServerError,
                "validation_error" => RemoveAssetFromCollectionResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
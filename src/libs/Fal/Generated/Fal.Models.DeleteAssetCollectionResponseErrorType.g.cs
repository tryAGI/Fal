
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetCollectionResponseErrorType
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
    public static class DeleteAssetCollectionResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetCollectionResponseErrorType value)
        {
            return value switch
            {
                DeleteAssetCollectionResponseErrorType.AuthorizationError => "authorization_error",
                DeleteAssetCollectionResponseErrorType.NotFound => "not_found",
                DeleteAssetCollectionResponseErrorType.NotImplemented => "not_implemented",
                DeleteAssetCollectionResponseErrorType.RateLimited => "rate_limited",
                DeleteAssetCollectionResponseErrorType.ServerError => "server_error",
                DeleteAssetCollectionResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetCollectionResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetCollectionResponseErrorType.AuthorizationError,
                "not_found" => DeleteAssetCollectionResponseErrorType.NotFound,
                "not_implemented" => DeleteAssetCollectionResponseErrorType.NotImplemented,
                "rate_limited" => DeleteAssetCollectionResponseErrorType.RateLimited,
                "server_error" => DeleteAssetCollectionResponseErrorType.ServerError,
                "validation_error" => DeleteAssetCollectionResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
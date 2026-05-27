
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetCollectionResponseErrorType
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
    public static class UnfavoriteAssetCollectionResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCollectionResponseErrorType value)
        {
            return value switch
            {
                UnfavoriteAssetCollectionResponseErrorType.AuthorizationError => "authorization_error",
                UnfavoriteAssetCollectionResponseErrorType.NotFound => "not_found",
                UnfavoriteAssetCollectionResponseErrorType.NotImplemented => "not_implemented",
                UnfavoriteAssetCollectionResponseErrorType.RateLimited => "rate_limited",
                UnfavoriteAssetCollectionResponseErrorType.ServerError => "server_error",
                UnfavoriteAssetCollectionResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCollectionResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetCollectionResponseErrorType.AuthorizationError,
                "not_found" => UnfavoriteAssetCollectionResponseErrorType.NotFound,
                "not_implemented" => UnfavoriteAssetCollectionResponseErrorType.NotImplemented,
                "rate_limited" => UnfavoriteAssetCollectionResponseErrorType.RateLimited,
                "server_error" => UnfavoriteAssetCollectionResponseErrorType.ServerError,
                "validation_error" => UnfavoriteAssetCollectionResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetCollectionResponseErrorType6
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
    public static class UnfavoriteAssetCollectionResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCollectionResponseErrorType6 value)
        {
            return value switch
            {
                UnfavoriteAssetCollectionResponseErrorType6.AuthorizationError => "authorization_error",
                UnfavoriteAssetCollectionResponseErrorType6.NotFound => "not_found",
                UnfavoriteAssetCollectionResponseErrorType6.NotImplemented => "not_implemented",
                UnfavoriteAssetCollectionResponseErrorType6.RateLimited => "rate_limited",
                UnfavoriteAssetCollectionResponseErrorType6.ServerError => "server_error",
                UnfavoriteAssetCollectionResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCollectionResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetCollectionResponseErrorType6.AuthorizationError,
                "not_found" => UnfavoriteAssetCollectionResponseErrorType6.NotFound,
                "not_implemented" => UnfavoriteAssetCollectionResponseErrorType6.NotImplemented,
                "rate_limited" => UnfavoriteAssetCollectionResponseErrorType6.RateLimited,
                "server_error" => UnfavoriteAssetCollectionResponseErrorType6.ServerError,
                "validation_error" => UnfavoriteAssetCollectionResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
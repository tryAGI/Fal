
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetCollectionResponseErrorType9
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
    public static class UnfavoriteAssetCollectionResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCollectionResponseErrorType9 value)
        {
            return value switch
            {
                UnfavoriteAssetCollectionResponseErrorType9.AuthorizationError => "authorization_error",
                UnfavoriteAssetCollectionResponseErrorType9.NotFound => "not_found",
                UnfavoriteAssetCollectionResponseErrorType9.NotImplemented => "not_implemented",
                UnfavoriteAssetCollectionResponseErrorType9.RateLimited => "rate_limited",
                UnfavoriteAssetCollectionResponseErrorType9.ServerError => "server_error",
                UnfavoriteAssetCollectionResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCollectionResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetCollectionResponseErrorType9.AuthorizationError,
                "not_found" => UnfavoriteAssetCollectionResponseErrorType9.NotFound,
                "not_implemented" => UnfavoriteAssetCollectionResponseErrorType9.NotImplemented,
                "rate_limited" => UnfavoriteAssetCollectionResponseErrorType9.RateLimited,
                "server_error" => UnfavoriteAssetCollectionResponseErrorType9.ServerError,
                "validation_error" => UnfavoriteAssetCollectionResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetCollectionResponseErrorType3
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
    public static class UnfavoriteAssetCollectionResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCollectionResponseErrorType3 value)
        {
            return value switch
            {
                UnfavoriteAssetCollectionResponseErrorType3.AuthorizationError => "authorization_error",
                UnfavoriteAssetCollectionResponseErrorType3.NotFound => "not_found",
                UnfavoriteAssetCollectionResponseErrorType3.NotImplemented => "not_implemented",
                UnfavoriteAssetCollectionResponseErrorType3.RateLimited => "rate_limited",
                UnfavoriteAssetCollectionResponseErrorType3.ServerError => "server_error",
                UnfavoriteAssetCollectionResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCollectionResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetCollectionResponseErrorType3.AuthorizationError,
                "not_found" => UnfavoriteAssetCollectionResponseErrorType3.NotFound,
                "not_implemented" => UnfavoriteAssetCollectionResponseErrorType3.NotImplemented,
                "rate_limited" => UnfavoriteAssetCollectionResponseErrorType3.RateLimited,
                "server_error" => UnfavoriteAssetCollectionResponseErrorType3.ServerError,
                "validation_error" => UnfavoriteAssetCollectionResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
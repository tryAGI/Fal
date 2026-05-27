
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetCollectionResponseErrorType7
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
    public static class UnfavoriteAssetCollectionResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCollectionResponseErrorType7 value)
        {
            return value switch
            {
                UnfavoriteAssetCollectionResponseErrorType7.AuthorizationError => "authorization_error",
                UnfavoriteAssetCollectionResponseErrorType7.NotFound => "not_found",
                UnfavoriteAssetCollectionResponseErrorType7.NotImplemented => "not_implemented",
                UnfavoriteAssetCollectionResponseErrorType7.RateLimited => "rate_limited",
                UnfavoriteAssetCollectionResponseErrorType7.ServerError => "server_error",
                UnfavoriteAssetCollectionResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCollectionResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetCollectionResponseErrorType7.AuthorizationError,
                "not_found" => UnfavoriteAssetCollectionResponseErrorType7.NotFound,
                "not_implemented" => UnfavoriteAssetCollectionResponseErrorType7.NotImplemented,
                "rate_limited" => UnfavoriteAssetCollectionResponseErrorType7.RateLimited,
                "server_error" => UnfavoriteAssetCollectionResponseErrorType7.ServerError,
                "validation_error" => UnfavoriteAssetCollectionResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetCollectionResponseErrorType2
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
    public static class UnfavoriteAssetCollectionResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCollectionResponseErrorType2 value)
        {
            return value switch
            {
                UnfavoriteAssetCollectionResponseErrorType2.AuthorizationError => "authorization_error",
                UnfavoriteAssetCollectionResponseErrorType2.NotFound => "not_found",
                UnfavoriteAssetCollectionResponseErrorType2.NotImplemented => "not_implemented",
                UnfavoriteAssetCollectionResponseErrorType2.RateLimited => "rate_limited",
                UnfavoriteAssetCollectionResponseErrorType2.ServerError => "server_error",
                UnfavoriteAssetCollectionResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCollectionResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetCollectionResponseErrorType2.AuthorizationError,
                "not_found" => UnfavoriteAssetCollectionResponseErrorType2.NotFound,
                "not_implemented" => UnfavoriteAssetCollectionResponseErrorType2.NotImplemented,
                "rate_limited" => UnfavoriteAssetCollectionResponseErrorType2.RateLimited,
                "server_error" => UnfavoriteAssetCollectionResponseErrorType2.ServerError,
                "validation_error" => UnfavoriteAssetCollectionResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
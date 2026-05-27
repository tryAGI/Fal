
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnfavoriteAssetCollectionResponseErrorType8
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
    public static class UnfavoriteAssetCollectionResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCollectionResponseErrorType8 value)
        {
            return value switch
            {
                UnfavoriteAssetCollectionResponseErrorType8.AuthorizationError => "authorization_error",
                UnfavoriteAssetCollectionResponseErrorType8.NotFound => "not_found",
                UnfavoriteAssetCollectionResponseErrorType8.NotImplemented => "not_implemented",
                UnfavoriteAssetCollectionResponseErrorType8.RateLimited => "rate_limited",
                UnfavoriteAssetCollectionResponseErrorType8.ServerError => "server_error",
                UnfavoriteAssetCollectionResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCollectionResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnfavoriteAssetCollectionResponseErrorType8.AuthorizationError,
                "not_found" => UnfavoriteAssetCollectionResponseErrorType8.NotFound,
                "not_implemented" => UnfavoriteAssetCollectionResponseErrorType8.NotImplemented,
                "rate_limited" => UnfavoriteAssetCollectionResponseErrorType8.RateLimited,
                "server_error" => UnfavoriteAssetCollectionResponseErrorType8.ServerError,
                "validation_error" => UnfavoriteAssetCollectionResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
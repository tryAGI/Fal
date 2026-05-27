
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCollectionAssetsResponseErrorType6
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
    public static class ListAssetCollectionAssetsResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionAssetsResponseErrorType6 value)
        {
            return value switch
            {
                ListAssetCollectionAssetsResponseErrorType6.AuthorizationError => "authorization_error",
                ListAssetCollectionAssetsResponseErrorType6.NotFound => "not_found",
                ListAssetCollectionAssetsResponseErrorType6.NotImplemented => "not_implemented",
                ListAssetCollectionAssetsResponseErrorType6.RateLimited => "rate_limited",
                ListAssetCollectionAssetsResponseErrorType6.ServerError => "server_error",
                ListAssetCollectionAssetsResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionAssetsResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCollectionAssetsResponseErrorType6.AuthorizationError,
                "not_found" => ListAssetCollectionAssetsResponseErrorType6.NotFound,
                "not_implemented" => ListAssetCollectionAssetsResponseErrorType6.NotImplemented,
                "rate_limited" => ListAssetCollectionAssetsResponseErrorType6.RateLimited,
                "server_error" => ListAssetCollectionAssetsResponseErrorType6.ServerError,
                "validation_error" => ListAssetCollectionAssetsResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
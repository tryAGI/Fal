
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCollectionAssetsResponseErrorType9
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
    public static class ListAssetCollectionAssetsResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionAssetsResponseErrorType9 value)
        {
            return value switch
            {
                ListAssetCollectionAssetsResponseErrorType9.AuthorizationError => "authorization_error",
                ListAssetCollectionAssetsResponseErrorType9.NotFound => "not_found",
                ListAssetCollectionAssetsResponseErrorType9.NotImplemented => "not_implemented",
                ListAssetCollectionAssetsResponseErrorType9.RateLimited => "rate_limited",
                ListAssetCollectionAssetsResponseErrorType9.ServerError => "server_error",
                ListAssetCollectionAssetsResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionAssetsResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCollectionAssetsResponseErrorType9.AuthorizationError,
                "not_found" => ListAssetCollectionAssetsResponseErrorType9.NotFound,
                "not_implemented" => ListAssetCollectionAssetsResponseErrorType9.NotImplemented,
                "rate_limited" => ListAssetCollectionAssetsResponseErrorType9.RateLimited,
                "server_error" => ListAssetCollectionAssetsResponseErrorType9.ServerError,
                "validation_error" => ListAssetCollectionAssetsResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}
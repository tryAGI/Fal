
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCollectionAssetsResponseErrorType3
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
    public static class ListAssetCollectionAssetsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionAssetsResponseErrorType3 value)
        {
            return value switch
            {
                ListAssetCollectionAssetsResponseErrorType3.AuthorizationError => "authorization_error",
                ListAssetCollectionAssetsResponseErrorType3.NotFound => "not_found",
                ListAssetCollectionAssetsResponseErrorType3.NotImplemented => "not_implemented",
                ListAssetCollectionAssetsResponseErrorType3.RateLimited => "rate_limited",
                ListAssetCollectionAssetsResponseErrorType3.ServerError => "server_error",
                ListAssetCollectionAssetsResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionAssetsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCollectionAssetsResponseErrorType3.AuthorizationError,
                "not_found" => ListAssetCollectionAssetsResponseErrorType3.NotFound,
                "not_implemented" => ListAssetCollectionAssetsResponseErrorType3.NotImplemented,
                "rate_limited" => ListAssetCollectionAssetsResponseErrorType3.RateLimited,
                "server_error" => ListAssetCollectionAssetsResponseErrorType3.ServerError,
                "validation_error" => ListAssetCollectionAssetsResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
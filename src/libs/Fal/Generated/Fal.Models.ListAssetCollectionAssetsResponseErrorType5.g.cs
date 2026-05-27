
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCollectionAssetsResponseErrorType5
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
    public static class ListAssetCollectionAssetsResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionAssetsResponseErrorType5 value)
        {
            return value switch
            {
                ListAssetCollectionAssetsResponseErrorType5.AuthorizationError => "authorization_error",
                ListAssetCollectionAssetsResponseErrorType5.NotFound => "not_found",
                ListAssetCollectionAssetsResponseErrorType5.NotImplemented => "not_implemented",
                ListAssetCollectionAssetsResponseErrorType5.RateLimited => "rate_limited",
                ListAssetCollectionAssetsResponseErrorType5.ServerError => "server_error",
                ListAssetCollectionAssetsResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionAssetsResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCollectionAssetsResponseErrorType5.AuthorizationError,
                "not_found" => ListAssetCollectionAssetsResponseErrorType5.NotFound,
                "not_implemented" => ListAssetCollectionAssetsResponseErrorType5.NotImplemented,
                "rate_limited" => ListAssetCollectionAssetsResponseErrorType5.RateLimited,
                "server_error" => ListAssetCollectionAssetsResponseErrorType5.ServerError,
                "validation_error" => ListAssetCollectionAssetsResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
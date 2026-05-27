
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCollectionAssetsResponseErrorType2
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
    public static class ListAssetCollectionAssetsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionAssetsResponseErrorType2 value)
        {
            return value switch
            {
                ListAssetCollectionAssetsResponseErrorType2.AuthorizationError => "authorization_error",
                ListAssetCollectionAssetsResponseErrorType2.NotFound => "not_found",
                ListAssetCollectionAssetsResponseErrorType2.NotImplemented => "not_implemented",
                ListAssetCollectionAssetsResponseErrorType2.RateLimited => "rate_limited",
                ListAssetCollectionAssetsResponseErrorType2.ServerError => "server_error",
                ListAssetCollectionAssetsResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionAssetsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCollectionAssetsResponseErrorType2.AuthorizationError,
                "not_found" => ListAssetCollectionAssetsResponseErrorType2.NotFound,
                "not_implemented" => ListAssetCollectionAssetsResponseErrorType2.NotImplemented,
                "rate_limited" => ListAssetCollectionAssetsResponseErrorType2.RateLimited,
                "server_error" => ListAssetCollectionAssetsResponseErrorType2.ServerError,
                "validation_error" => ListAssetCollectionAssetsResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCollectionAssetsResponseErrorType8
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
    public static class ListAssetCollectionAssetsResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionAssetsResponseErrorType8 value)
        {
            return value switch
            {
                ListAssetCollectionAssetsResponseErrorType8.AuthorizationError => "authorization_error",
                ListAssetCollectionAssetsResponseErrorType8.NotFound => "not_found",
                ListAssetCollectionAssetsResponseErrorType8.NotImplemented => "not_implemented",
                ListAssetCollectionAssetsResponseErrorType8.RateLimited => "rate_limited",
                ListAssetCollectionAssetsResponseErrorType8.ServerError => "server_error",
                ListAssetCollectionAssetsResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionAssetsResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCollectionAssetsResponseErrorType8.AuthorizationError,
                "not_found" => ListAssetCollectionAssetsResponseErrorType8.NotFound,
                "not_implemented" => ListAssetCollectionAssetsResponseErrorType8.NotImplemented,
                "rate_limited" => ListAssetCollectionAssetsResponseErrorType8.RateLimited,
                "server_error" => ListAssetCollectionAssetsResponseErrorType8.ServerError,
                "validation_error" => ListAssetCollectionAssetsResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCollectionAssetsResponseErrorType
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
    public static class ListAssetCollectionAssetsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionAssetsResponseErrorType value)
        {
            return value switch
            {
                ListAssetCollectionAssetsResponseErrorType.AuthorizationError => "authorization_error",
                ListAssetCollectionAssetsResponseErrorType.NotFound => "not_found",
                ListAssetCollectionAssetsResponseErrorType.NotImplemented => "not_implemented",
                ListAssetCollectionAssetsResponseErrorType.RateLimited => "rate_limited",
                ListAssetCollectionAssetsResponseErrorType.ServerError => "server_error",
                ListAssetCollectionAssetsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionAssetsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCollectionAssetsResponseErrorType.AuthorizationError,
                "not_found" => ListAssetCollectionAssetsResponseErrorType.NotFound,
                "not_implemented" => ListAssetCollectionAssetsResponseErrorType.NotImplemented,
                "rate_limited" => ListAssetCollectionAssetsResponseErrorType.RateLimited,
                "server_error" => ListAssetCollectionAssetsResponseErrorType.ServerError,
                "validation_error" => ListAssetCollectionAssetsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
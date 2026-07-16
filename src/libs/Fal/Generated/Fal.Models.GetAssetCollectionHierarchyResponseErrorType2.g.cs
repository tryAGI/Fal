
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCollectionHierarchyResponseErrorType2
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
    public static class GetAssetCollectionHierarchyResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionHierarchyResponseErrorType2 value)
        {
            return value switch
            {
                GetAssetCollectionHierarchyResponseErrorType2.AuthorizationError => "authorization_error",
                GetAssetCollectionHierarchyResponseErrorType2.NotFound => "not_found",
                GetAssetCollectionHierarchyResponseErrorType2.NotImplemented => "not_implemented",
                GetAssetCollectionHierarchyResponseErrorType2.RateLimited => "rate_limited",
                GetAssetCollectionHierarchyResponseErrorType2.ServerError => "server_error",
                GetAssetCollectionHierarchyResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionHierarchyResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCollectionHierarchyResponseErrorType2.AuthorizationError,
                "not_found" => GetAssetCollectionHierarchyResponseErrorType2.NotFound,
                "not_implemented" => GetAssetCollectionHierarchyResponseErrorType2.NotImplemented,
                "rate_limited" => GetAssetCollectionHierarchyResponseErrorType2.RateLimited,
                "server_error" => GetAssetCollectionHierarchyResponseErrorType2.ServerError,
                "validation_error" => GetAssetCollectionHierarchyResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCollectionHierarchyResponseErrorType7
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
    public static class GetAssetCollectionHierarchyResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionHierarchyResponseErrorType7 value)
        {
            return value switch
            {
                GetAssetCollectionHierarchyResponseErrorType7.AuthorizationError => "authorization_error",
                GetAssetCollectionHierarchyResponseErrorType7.NotFound => "not_found",
                GetAssetCollectionHierarchyResponseErrorType7.NotImplemented => "not_implemented",
                GetAssetCollectionHierarchyResponseErrorType7.RateLimited => "rate_limited",
                GetAssetCollectionHierarchyResponseErrorType7.ServerError => "server_error",
                GetAssetCollectionHierarchyResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionHierarchyResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCollectionHierarchyResponseErrorType7.AuthorizationError,
                "not_found" => GetAssetCollectionHierarchyResponseErrorType7.NotFound,
                "not_implemented" => GetAssetCollectionHierarchyResponseErrorType7.NotImplemented,
                "rate_limited" => GetAssetCollectionHierarchyResponseErrorType7.RateLimited,
                "server_error" => GetAssetCollectionHierarchyResponseErrorType7.ServerError,
                "validation_error" => GetAssetCollectionHierarchyResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}
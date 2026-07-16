
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCollectionHierarchyResponseErrorType3
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
    public static class GetAssetCollectionHierarchyResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionHierarchyResponseErrorType3 value)
        {
            return value switch
            {
                GetAssetCollectionHierarchyResponseErrorType3.AuthorizationError => "authorization_error",
                GetAssetCollectionHierarchyResponseErrorType3.NotFound => "not_found",
                GetAssetCollectionHierarchyResponseErrorType3.NotImplemented => "not_implemented",
                GetAssetCollectionHierarchyResponseErrorType3.RateLimited => "rate_limited",
                GetAssetCollectionHierarchyResponseErrorType3.ServerError => "server_error",
                GetAssetCollectionHierarchyResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionHierarchyResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCollectionHierarchyResponseErrorType3.AuthorizationError,
                "not_found" => GetAssetCollectionHierarchyResponseErrorType3.NotFound,
                "not_implemented" => GetAssetCollectionHierarchyResponseErrorType3.NotImplemented,
                "rate_limited" => GetAssetCollectionHierarchyResponseErrorType3.RateLimited,
                "server_error" => GetAssetCollectionHierarchyResponseErrorType3.ServerError,
                "validation_error" => GetAssetCollectionHierarchyResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
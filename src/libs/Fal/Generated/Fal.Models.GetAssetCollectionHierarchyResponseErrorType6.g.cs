
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCollectionHierarchyResponseErrorType6
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
    public static class GetAssetCollectionHierarchyResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionHierarchyResponseErrorType6 value)
        {
            return value switch
            {
                GetAssetCollectionHierarchyResponseErrorType6.AuthorizationError => "authorization_error",
                GetAssetCollectionHierarchyResponseErrorType6.NotFound => "not_found",
                GetAssetCollectionHierarchyResponseErrorType6.NotImplemented => "not_implemented",
                GetAssetCollectionHierarchyResponseErrorType6.RateLimited => "rate_limited",
                GetAssetCollectionHierarchyResponseErrorType6.ServerError => "server_error",
                GetAssetCollectionHierarchyResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionHierarchyResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCollectionHierarchyResponseErrorType6.AuthorizationError,
                "not_found" => GetAssetCollectionHierarchyResponseErrorType6.NotFound,
                "not_implemented" => GetAssetCollectionHierarchyResponseErrorType6.NotImplemented,
                "rate_limited" => GetAssetCollectionHierarchyResponseErrorType6.RateLimited,
                "server_error" => GetAssetCollectionHierarchyResponseErrorType6.ServerError,
                "validation_error" => GetAssetCollectionHierarchyResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
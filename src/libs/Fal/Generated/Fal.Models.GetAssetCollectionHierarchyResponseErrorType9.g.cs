
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCollectionHierarchyResponseErrorType9
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
    public static class GetAssetCollectionHierarchyResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionHierarchyResponseErrorType9 value)
        {
            return value switch
            {
                GetAssetCollectionHierarchyResponseErrorType9.AuthorizationError => "authorization_error",
                GetAssetCollectionHierarchyResponseErrorType9.NotFound => "not_found",
                GetAssetCollectionHierarchyResponseErrorType9.NotImplemented => "not_implemented",
                GetAssetCollectionHierarchyResponseErrorType9.RateLimited => "rate_limited",
                GetAssetCollectionHierarchyResponseErrorType9.ServerError => "server_error",
                GetAssetCollectionHierarchyResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionHierarchyResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCollectionHierarchyResponseErrorType9.AuthorizationError,
                "not_found" => GetAssetCollectionHierarchyResponseErrorType9.NotFound,
                "not_implemented" => GetAssetCollectionHierarchyResponseErrorType9.NotImplemented,
                "rate_limited" => GetAssetCollectionHierarchyResponseErrorType9.RateLimited,
                "server_error" => GetAssetCollectionHierarchyResponseErrorType9.ServerError,
                "validation_error" => GetAssetCollectionHierarchyResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}
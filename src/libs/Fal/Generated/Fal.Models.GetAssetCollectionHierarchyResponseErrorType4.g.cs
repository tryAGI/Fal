
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCollectionHierarchyResponseErrorType4
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
    public static class GetAssetCollectionHierarchyResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionHierarchyResponseErrorType4 value)
        {
            return value switch
            {
                GetAssetCollectionHierarchyResponseErrorType4.AuthorizationError => "authorization_error",
                GetAssetCollectionHierarchyResponseErrorType4.NotFound => "not_found",
                GetAssetCollectionHierarchyResponseErrorType4.NotImplemented => "not_implemented",
                GetAssetCollectionHierarchyResponseErrorType4.RateLimited => "rate_limited",
                GetAssetCollectionHierarchyResponseErrorType4.ServerError => "server_error",
                GetAssetCollectionHierarchyResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionHierarchyResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCollectionHierarchyResponseErrorType4.AuthorizationError,
                "not_found" => GetAssetCollectionHierarchyResponseErrorType4.NotFound,
                "not_implemented" => GetAssetCollectionHierarchyResponseErrorType4.NotImplemented,
                "rate_limited" => GetAssetCollectionHierarchyResponseErrorType4.RateLimited,
                "server_error" => GetAssetCollectionHierarchyResponseErrorType4.ServerError,
                "validation_error" => GetAssetCollectionHierarchyResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
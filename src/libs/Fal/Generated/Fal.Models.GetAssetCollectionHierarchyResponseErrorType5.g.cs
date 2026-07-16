
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCollectionHierarchyResponseErrorType5
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
    public static class GetAssetCollectionHierarchyResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionHierarchyResponseErrorType5 value)
        {
            return value switch
            {
                GetAssetCollectionHierarchyResponseErrorType5.AuthorizationError => "authorization_error",
                GetAssetCollectionHierarchyResponseErrorType5.NotFound => "not_found",
                GetAssetCollectionHierarchyResponseErrorType5.NotImplemented => "not_implemented",
                GetAssetCollectionHierarchyResponseErrorType5.RateLimited => "rate_limited",
                GetAssetCollectionHierarchyResponseErrorType5.ServerError => "server_error",
                GetAssetCollectionHierarchyResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionHierarchyResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCollectionHierarchyResponseErrorType5.AuthorizationError,
                "not_found" => GetAssetCollectionHierarchyResponseErrorType5.NotFound,
                "not_implemented" => GetAssetCollectionHierarchyResponseErrorType5.NotImplemented,
                "rate_limited" => GetAssetCollectionHierarchyResponseErrorType5.RateLimited,
                "server_error" => GetAssetCollectionHierarchyResponseErrorType5.ServerError,
                "validation_error" => GetAssetCollectionHierarchyResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCollectionHierarchyResponseErrorType
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
    public static class GetAssetCollectionHierarchyResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionHierarchyResponseErrorType value)
        {
            return value switch
            {
                GetAssetCollectionHierarchyResponseErrorType.AuthorizationError => "authorization_error",
                GetAssetCollectionHierarchyResponseErrorType.NotFound => "not_found",
                GetAssetCollectionHierarchyResponseErrorType.NotImplemented => "not_implemented",
                GetAssetCollectionHierarchyResponseErrorType.RateLimited => "rate_limited",
                GetAssetCollectionHierarchyResponseErrorType.ServerError => "server_error",
                GetAssetCollectionHierarchyResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionHierarchyResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCollectionHierarchyResponseErrorType.AuthorizationError,
                "not_found" => GetAssetCollectionHierarchyResponseErrorType.NotFound,
                "not_implemented" => GetAssetCollectionHierarchyResponseErrorType.NotImplemented,
                "rate_limited" => GetAssetCollectionHierarchyResponseErrorType.RateLimited,
                "server_error" => GetAssetCollectionHierarchyResponseErrorType.ServerError,
                "validation_error" => GetAssetCollectionHierarchyResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
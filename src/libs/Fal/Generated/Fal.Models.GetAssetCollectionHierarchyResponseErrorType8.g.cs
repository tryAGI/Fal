
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCollectionHierarchyResponseErrorType8
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
    public static class GetAssetCollectionHierarchyResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionHierarchyResponseErrorType8 value)
        {
            return value switch
            {
                GetAssetCollectionHierarchyResponseErrorType8.AuthorizationError => "authorization_error",
                GetAssetCollectionHierarchyResponseErrorType8.NotFound => "not_found",
                GetAssetCollectionHierarchyResponseErrorType8.NotImplemented => "not_implemented",
                GetAssetCollectionHierarchyResponseErrorType8.RateLimited => "rate_limited",
                GetAssetCollectionHierarchyResponseErrorType8.ServerError => "server_error",
                GetAssetCollectionHierarchyResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionHierarchyResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCollectionHierarchyResponseErrorType8.AuthorizationError,
                "not_found" => GetAssetCollectionHierarchyResponseErrorType8.NotFound,
                "not_implemented" => GetAssetCollectionHierarchyResponseErrorType8.NotImplemented,
                "rate_limited" => GetAssetCollectionHierarchyResponseErrorType8.RateLimited,
                "server_error" => GetAssetCollectionHierarchyResponseErrorType8.ServerError,
                "validation_error" => GetAssetCollectionHierarchyResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
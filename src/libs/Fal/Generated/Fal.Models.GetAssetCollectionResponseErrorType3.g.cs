
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCollectionResponseErrorType3
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
    public static class GetAssetCollectionResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionResponseErrorType3 value)
        {
            return value switch
            {
                GetAssetCollectionResponseErrorType3.AuthorizationError => "authorization_error",
                GetAssetCollectionResponseErrorType3.NotFound => "not_found",
                GetAssetCollectionResponseErrorType3.NotImplemented => "not_implemented",
                GetAssetCollectionResponseErrorType3.RateLimited => "rate_limited",
                GetAssetCollectionResponseErrorType3.ServerError => "server_error",
                GetAssetCollectionResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCollectionResponseErrorType3.AuthorizationError,
                "not_found" => GetAssetCollectionResponseErrorType3.NotFound,
                "not_implemented" => GetAssetCollectionResponseErrorType3.NotImplemented,
                "rate_limited" => GetAssetCollectionResponseErrorType3.RateLimited,
                "server_error" => GetAssetCollectionResponseErrorType3.ServerError,
                "validation_error" => GetAssetCollectionResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCollectionResponseErrorType6
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
    public static class GetAssetCollectionResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionResponseErrorType6 value)
        {
            return value switch
            {
                GetAssetCollectionResponseErrorType6.AuthorizationError => "authorization_error",
                GetAssetCollectionResponseErrorType6.NotFound => "not_found",
                GetAssetCollectionResponseErrorType6.NotImplemented => "not_implemented",
                GetAssetCollectionResponseErrorType6.RateLimited => "rate_limited",
                GetAssetCollectionResponseErrorType6.ServerError => "server_error",
                GetAssetCollectionResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCollectionResponseErrorType6.AuthorizationError,
                "not_found" => GetAssetCollectionResponseErrorType6.NotFound,
                "not_implemented" => GetAssetCollectionResponseErrorType6.NotImplemented,
                "rate_limited" => GetAssetCollectionResponseErrorType6.RateLimited,
                "server_error" => GetAssetCollectionResponseErrorType6.ServerError,
                "validation_error" => GetAssetCollectionResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCollectionResponseErrorType9
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
    public static class GetAssetCollectionResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionResponseErrorType9 value)
        {
            return value switch
            {
                GetAssetCollectionResponseErrorType9.AuthorizationError => "authorization_error",
                GetAssetCollectionResponseErrorType9.NotFound => "not_found",
                GetAssetCollectionResponseErrorType9.NotImplemented => "not_implemented",
                GetAssetCollectionResponseErrorType9.RateLimited => "rate_limited",
                GetAssetCollectionResponseErrorType9.ServerError => "server_error",
                GetAssetCollectionResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCollectionResponseErrorType9.AuthorizationError,
                "not_found" => GetAssetCollectionResponseErrorType9.NotFound,
                "not_implemented" => GetAssetCollectionResponseErrorType9.NotImplemented,
                "rate_limited" => GetAssetCollectionResponseErrorType9.RateLimited,
                "server_error" => GetAssetCollectionResponseErrorType9.ServerError,
                "validation_error" => GetAssetCollectionResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}
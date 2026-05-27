
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCollectionResponseErrorType
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
    public static class GetAssetCollectionResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionResponseErrorType value)
        {
            return value switch
            {
                GetAssetCollectionResponseErrorType.AuthorizationError => "authorization_error",
                GetAssetCollectionResponseErrorType.NotFound => "not_found",
                GetAssetCollectionResponseErrorType.NotImplemented => "not_implemented",
                GetAssetCollectionResponseErrorType.RateLimited => "rate_limited",
                GetAssetCollectionResponseErrorType.ServerError => "server_error",
                GetAssetCollectionResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCollectionResponseErrorType.AuthorizationError,
                "not_found" => GetAssetCollectionResponseErrorType.NotFound,
                "not_implemented" => GetAssetCollectionResponseErrorType.NotImplemented,
                "rate_limited" => GetAssetCollectionResponseErrorType.RateLimited,
                "server_error" => GetAssetCollectionResponseErrorType.ServerError,
                "validation_error" => GetAssetCollectionResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
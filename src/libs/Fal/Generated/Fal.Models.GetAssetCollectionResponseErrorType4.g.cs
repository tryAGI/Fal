
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCollectionResponseErrorType4
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
    public static class GetAssetCollectionResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionResponseErrorType4 value)
        {
            return value switch
            {
                GetAssetCollectionResponseErrorType4.AuthorizationError => "authorization_error",
                GetAssetCollectionResponseErrorType4.NotFound => "not_found",
                GetAssetCollectionResponseErrorType4.NotImplemented => "not_implemented",
                GetAssetCollectionResponseErrorType4.RateLimited => "rate_limited",
                GetAssetCollectionResponseErrorType4.ServerError => "server_error",
                GetAssetCollectionResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCollectionResponseErrorType4.AuthorizationError,
                "not_found" => GetAssetCollectionResponseErrorType4.NotFound,
                "not_implemented" => GetAssetCollectionResponseErrorType4.NotImplemented,
                "rate_limited" => GetAssetCollectionResponseErrorType4.RateLimited,
                "server_error" => GetAssetCollectionResponseErrorType4.ServerError,
                "validation_error" => GetAssetCollectionResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
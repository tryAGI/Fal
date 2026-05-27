
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCollectionResponseErrorType8
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
    public static class GetAssetCollectionResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionResponseErrorType8 value)
        {
            return value switch
            {
                GetAssetCollectionResponseErrorType8.AuthorizationError => "authorization_error",
                GetAssetCollectionResponseErrorType8.NotFound => "not_found",
                GetAssetCollectionResponseErrorType8.NotImplemented => "not_implemented",
                GetAssetCollectionResponseErrorType8.RateLimited => "rate_limited",
                GetAssetCollectionResponseErrorType8.ServerError => "server_error",
                GetAssetCollectionResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCollectionResponseErrorType8.AuthorizationError,
                "not_found" => GetAssetCollectionResponseErrorType8.NotFound,
                "not_implemented" => GetAssetCollectionResponseErrorType8.NotImplemented,
                "rate_limited" => GetAssetCollectionResponseErrorType8.RateLimited,
                "server_error" => GetAssetCollectionResponseErrorType8.ServerError,
                "validation_error" => GetAssetCollectionResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
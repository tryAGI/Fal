
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCollectionResponseErrorType2
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
    public static class GetAssetCollectionResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionResponseErrorType2 value)
        {
            return value switch
            {
                GetAssetCollectionResponseErrorType2.AuthorizationError => "authorization_error",
                GetAssetCollectionResponseErrorType2.NotFound => "not_found",
                GetAssetCollectionResponseErrorType2.NotImplemented => "not_implemented",
                GetAssetCollectionResponseErrorType2.RateLimited => "rate_limited",
                GetAssetCollectionResponseErrorType2.ServerError => "server_error",
                GetAssetCollectionResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCollectionResponseErrorType2.AuthorizationError,
                "not_found" => GetAssetCollectionResponseErrorType2.NotFound,
                "not_implemented" => GetAssetCollectionResponseErrorType2.NotImplemented,
                "rate_limited" => GetAssetCollectionResponseErrorType2.RateLimited,
                "server_error" => GetAssetCollectionResponseErrorType2.ServerError,
                "validation_error" => GetAssetCollectionResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
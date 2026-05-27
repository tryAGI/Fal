
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetCollectionResponseErrorType3
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
    public static class CreateAssetCollectionResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetCollectionResponseErrorType3 value)
        {
            return value switch
            {
                CreateAssetCollectionResponseErrorType3.AuthorizationError => "authorization_error",
                CreateAssetCollectionResponseErrorType3.NotFound => "not_found",
                CreateAssetCollectionResponseErrorType3.NotImplemented => "not_implemented",
                CreateAssetCollectionResponseErrorType3.RateLimited => "rate_limited",
                CreateAssetCollectionResponseErrorType3.ServerError => "server_error",
                CreateAssetCollectionResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetCollectionResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetCollectionResponseErrorType3.AuthorizationError,
                "not_found" => CreateAssetCollectionResponseErrorType3.NotFound,
                "not_implemented" => CreateAssetCollectionResponseErrorType3.NotImplemented,
                "rate_limited" => CreateAssetCollectionResponseErrorType3.RateLimited,
                "server_error" => CreateAssetCollectionResponseErrorType3.ServerError,
                "validation_error" => CreateAssetCollectionResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
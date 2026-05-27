
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetCollectionResponseErrorType9
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
    public static class CreateAssetCollectionResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetCollectionResponseErrorType9 value)
        {
            return value switch
            {
                CreateAssetCollectionResponseErrorType9.AuthorizationError => "authorization_error",
                CreateAssetCollectionResponseErrorType9.NotFound => "not_found",
                CreateAssetCollectionResponseErrorType9.NotImplemented => "not_implemented",
                CreateAssetCollectionResponseErrorType9.RateLimited => "rate_limited",
                CreateAssetCollectionResponseErrorType9.ServerError => "server_error",
                CreateAssetCollectionResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetCollectionResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetCollectionResponseErrorType9.AuthorizationError,
                "not_found" => CreateAssetCollectionResponseErrorType9.NotFound,
                "not_implemented" => CreateAssetCollectionResponseErrorType9.NotImplemented,
                "rate_limited" => CreateAssetCollectionResponseErrorType9.RateLimited,
                "server_error" => CreateAssetCollectionResponseErrorType9.ServerError,
                "validation_error" => CreateAssetCollectionResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}
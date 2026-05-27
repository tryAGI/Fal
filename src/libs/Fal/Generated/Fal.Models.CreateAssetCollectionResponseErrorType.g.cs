
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetCollectionResponseErrorType
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
    public static class CreateAssetCollectionResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetCollectionResponseErrorType value)
        {
            return value switch
            {
                CreateAssetCollectionResponseErrorType.AuthorizationError => "authorization_error",
                CreateAssetCollectionResponseErrorType.NotFound => "not_found",
                CreateAssetCollectionResponseErrorType.NotImplemented => "not_implemented",
                CreateAssetCollectionResponseErrorType.RateLimited => "rate_limited",
                CreateAssetCollectionResponseErrorType.ServerError => "server_error",
                CreateAssetCollectionResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetCollectionResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetCollectionResponseErrorType.AuthorizationError,
                "not_found" => CreateAssetCollectionResponseErrorType.NotFound,
                "not_implemented" => CreateAssetCollectionResponseErrorType.NotImplemented,
                "rate_limited" => CreateAssetCollectionResponseErrorType.RateLimited,
                "server_error" => CreateAssetCollectionResponseErrorType.ServerError,
                "validation_error" => CreateAssetCollectionResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
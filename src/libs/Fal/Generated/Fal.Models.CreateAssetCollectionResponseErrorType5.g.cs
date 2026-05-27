
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetCollectionResponseErrorType5
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
    public static class CreateAssetCollectionResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetCollectionResponseErrorType5 value)
        {
            return value switch
            {
                CreateAssetCollectionResponseErrorType5.AuthorizationError => "authorization_error",
                CreateAssetCollectionResponseErrorType5.NotFound => "not_found",
                CreateAssetCollectionResponseErrorType5.NotImplemented => "not_implemented",
                CreateAssetCollectionResponseErrorType5.RateLimited => "rate_limited",
                CreateAssetCollectionResponseErrorType5.ServerError => "server_error",
                CreateAssetCollectionResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetCollectionResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetCollectionResponseErrorType5.AuthorizationError,
                "not_found" => CreateAssetCollectionResponseErrorType5.NotFound,
                "not_implemented" => CreateAssetCollectionResponseErrorType5.NotImplemented,
                "rate_limited" => CreateAssetCollectionResponseErrorType5.RateLimited,
                "server_error" => CreateAssetCollectionResponseErrorType5.ServerError,
                "validation_error" => CreateAssetCollectionResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
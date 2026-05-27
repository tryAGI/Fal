
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetTagResponseErrorType
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
    public static class CreateAssetTagResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetTagResponseErrorType value)
        {
            return value switch
            {
                CreateAssetTagResponseErrorType.AuthorizationError => "authorization_error",
                CreateAssetTagResponseErrorType.NotFound => "not_found",
                CreateAssetTagResponseErrorType.NotImplemented => "not_implemented",
                CreateAssetTagResponseErrorType.RateLimited => "rate_limited",
                CreateAssetTagResponseErrorType.ServerError => "server_error",
                CreateAssetTagResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetTagResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetTagResponseErrorType.AuthorizationError,
                "not_found" => CreateAssetTagResponseErrorType.NotFound,
                "not_implemented" => CreateAssetTagResponseErrorType.NotImplemented,
                "rate_limited" => CreateAssetTagResponseErrorType.RateLimited,
                "server_error" => CreateAssetTagResponseErrorType.ServerError,
                "validation_error" => CreateAssetTagResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
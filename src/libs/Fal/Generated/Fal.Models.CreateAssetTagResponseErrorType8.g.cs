
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetTagResponseErrorType8
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
    public static class CreateAssetTagResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetTagResponseErrorType8 value)
        {
            return value switch
            {
                CreateAssetTagResponseErrorType8.AuthorizationError => "authorization_error",
                CreateAssetTagResponseErrorType8.NotFound => "not_found",
                CreateAssetTagResponseErrorType8.NotImplemented => "not_implemented",
                CreateAssetTagResponseErrorType8.RateLimited => "rate_limited",
                CreateAssetTagResponseErrorType8.ServerError => "server_error",
                CreateAssetTagResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetTagResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetTagResponseErrorType8.AuthorizationError,
                "not_found" => CreateAssetTagResponseErrorType8.NotFound,
                "not_implemented" => CreateAssetTagResponseErrorType8.NotImplemented,
                "rate_limited" => CreateAssetTagResponseErrorType8.RateLimited,
                "server_error" => CreateAssetTagResponseErrorType8.ServerError,
                "validation_error" => CreateAssetTagResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
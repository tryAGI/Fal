
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetTagResponseErrorType9
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
    public static class CreateAssetTagResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetTagResponseErrorType9 value)
        {
            return value switch
            {
                CreateAssetTagResponseErrorType9.AuthorizationError => "authorization_error",
                CreateAssetTagResponseErrorType9.NotFound => "not_found",
                CreateAssetTagResponseErrorType9.NotImplemented => "not_implemented",
                CreateAssetTagResponseErrorType9.RateLimited => "rate_limited",
                CreateAssetTagResponseErrorType9.ServerError => "server_error",
                CreateAssetTagResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetTagResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetTagResponseErrorType9.AuthorizationError,
                "not_found" => CreateAssetTagResponseErrorType9.NotFound,
                "not_implemented" => CreateAssetTagResponseErrorType9.NotImplemented,
                "rate_limited" => CreateAssetTagResponseErrorType9.RateLimited,
                "server_error" => CreateAssetTagResponseErrorType9.ServerError,
                "validation_error" => CreateAssetTagResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}
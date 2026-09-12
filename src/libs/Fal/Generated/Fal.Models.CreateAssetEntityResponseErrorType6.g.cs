
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetEntityResponseErrorType6
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
    public static class CreateAssetEntityResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetEntityResponseErrorType6 value)
        {
            return value switch
            {
                CreateAssetEntityResponseErrorType6.AuthorizationError => "authorization_error",
                CreateAssetEntityResponseErrorType6.NotFound => "not_found",
                CreateAssetEntityResponseErrorType6.NotImplemented => "not_implemented",
                CreateAssetEntityResponseErrorType6.RateLimited => "rate_limited",
                CreateAssetEntityResponseErrorType6.ServerError => "server_error",
                CreateAssetEntityResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetEntityResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetEntityResponseErrorType6.AuthorizationError,
                "not_found" => CreateAssetEntityResponseErrorType6.NotFound,
                "not_implemented" => CreateAssetEntityResponseErrorType6.NotImplemented,
                "rate_limited" => CreateAssetEntityResponseErrorType6.RateLimited,
                "server_error" => CreateAssetEntityResponseErrorType6.ServerError,
                "validation_error" => CreateAssetEntityResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
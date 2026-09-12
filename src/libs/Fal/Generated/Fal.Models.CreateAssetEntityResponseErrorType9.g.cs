
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetEntityResponseErrorType9
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
    public static class CreateAssetEntityResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetEntityResponseErrorType9 value)
        {
            return value switch
            {
                CreateAssetEntityResponseErrorType9.AuthorizationError => "authorization_error",
                CreateAssetEntityResponseErrorType9.NotFound => "not_found",
                CreateAssetEntityResponseErrorType9.NotImplemented => "not_implemented",
                CreateAssetEntityResponseErrorType9.RateLimited => "rate_limited",
                CreateAssetEntityResponseErrorType9.ServerError => "server_error",
                CreateAssetEntityResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetEntityResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetEntityResponseErrorType9.AuthorizationError,
                "not_found" => CreateAssetEntityResponseErrorType9.NotFound,
                "not_implemented" => CreateAssetEntityResponseErrorType9.NotImplemented,
                "rate_limited" => CreateAssetEntityResponseErrorType9.RateLimited,
                "server_error" => CreateAssetEntityResponseErrorType9.ServerError,
                "validation_error" => CreateAssetEntityResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}
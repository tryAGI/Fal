
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetEntityResponseErrorType5
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
    public static class CreateAssetEntityResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetEntityResponseErrorType5 value)
        {
            return value switch
            {
                CreateAssetEntityResponseErrorType5.AuthorizationError => "authorization_error",
                CreateAssetEntityResponseErrorType5.NotFound => "not_found",
                CreateAssetEntityResponseErrorType5.NotImplemented => "not_implemented",
                CreateAssetEntityResponseErrorType5.RateLimited => "rate_limited",
                CreateAssetEntityResponseErrorType5.ServerError => "server_error",
                CreateAssetEntityResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetEntityResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetEntityResponseErrorType5.AuthorizationError,
                "not_found" => CreateAssetEntityResponseErrorType5.NotFound,
                "not_implemented" => CreateAssetEntityResponseErrorType5.NotImplemented,
                "rate_limited" => CreateAssetEntityResponseErrorType5.RateLimited,
                "server_error" => CreateAssetEntityResponseErrorType5.ServerError,
                "validation_error" => CreateAssetEntityResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
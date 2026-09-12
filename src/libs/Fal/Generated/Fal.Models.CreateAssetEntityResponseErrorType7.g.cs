
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetEntityResponseErrorType7
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
    public static class CreateAssetEntityResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetEntityResponseErrorType7 value)
        {
            return value switch
            {
                CreateAssetEntityResponseErrorType7.AuthorizationError => "authorization_error",
                CreateAssetEntityResponseErrorType7.NotFound => "not_found",
                CreateAssetEntityResponseErrorType7.NotImplemented => "not_implemented",
                CreateAssetEntityResponseErrorType7.RateLimited => "rate_limited",
                CreateAssetEntityResponseErrorType7.ServerError => "server_error",
                CreateAssetEntityResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetEntityResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetEntityResponseErrorType7.AuthorizationError,
                "not_found" => CreateAssetEntityResponseErrorType7.NotFound,
                "not_implemented" => CreateAssetEntityResponseErrorType7.NotImplemented,
                "rate_limited" => CreateAssetEntityResponseErrorType7.RateLimited,
                "server_error" => CreateAssetEntityResponseErrorType7.ServerError,
                "validation_error" => CreateAssetEntityResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}
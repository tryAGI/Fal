
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetEntityResponseErrorType
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
    public static class CreateAssetEntityResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetEntityResponseErrorType value)
        {
            return value switch
            {
                CreateAssetEntityResponseErrorType.AuthorizationError => "authorization_error",
                CreateAssetEntityResponseErrorType.NotFound => "not_found",
                CreateAssetEntityResponseErrorType.NotImplemented => "not_implemented",
                CreateAssetEntityResponseErrorType.RateLimited => "rate_limited",
                CreateAssetEntityResponseErrorType.ServerError => "server_error",
                CreateAssetEntityResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetEntityResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetEntityResponseErrorType.AuthorizationError,
                "not_found" => CreateAssetEntityResponseErrorType.NotFound,
                "not_implemented" => CreateAssetEntityResponseErrorType.NotImplemented,
                "rate_limited" => CreateAssetEntityResponseErrorType.RateLimited,
                "server_error" => CreateAssetEntityResponseErrorType.ServerError,
                "validation_error" => CreateAssetEntityResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
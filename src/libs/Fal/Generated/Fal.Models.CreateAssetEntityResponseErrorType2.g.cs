
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetEntityResponseErrorType2
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
    public static class CreateAssetEntityResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetEntityResponseErrorType2 value)
        {
            return value switch
            {
                CreateAssetEntityResponseErrorType2.AuthorizationError => "authorization_error",
                CreateAssetEntityResponseErrorType2.NotFound => "not_found",
                CreateAssetEntityResponseErrorType2.NotImplemented => "not_implemented",
                CreateAssetEntityResponseErrorType2.RateLimited => "rate_limited",
                CreateAssetEntityResponseErrorType2.ServerError => "server_error",
                CreateAssetEntityResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetEntityResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetEntityResponseErrorType2.AuthorizationError,
                "not_found" => CreateAssetEntityResponseErrorType2.NotFound,
                "not_implemented" => CreateAssetEntityResponseErrorType2.NotImplemented,
                "rate_limited" => CreateAssetEntityResponseErrorType2.RateLimited,
                "server_error" => CreateAssetEntityResponseErrorType2.ServerError,
                "validation_error" => CreateAssetEntityResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetEntityResponseErrorType4
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
    public static class CreateAssetEntityResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetEntityResponseErrorType4 value)
        {
            return value switch
            {
                CreateAssetEntityResponseErrorType4.AuthorizationError => "authorization_error",
                CreateAssetEntityResponseErrorType4.NotFound => "not_found",
                CreateAssetEntityResponseErrorType4.NotImplemented => "not_implemented",
                CreateAssetEntityResponseErrorType4.RateLimited => "rate_limited",
                CreateAssetEntityResponseErrorType4.ServerError => "server_error",
                CreateAssetEntityResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetEntityResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetEntityResponseErrorType4.AuthorizationError,
                "not_found" => CreateAssetEntityResponseErrorType4.NotFound,
                "not_implemented" => CreateAssetEntityResponseErrorType4.NotImplemented,
                "rate_limited" => CreateAssetEntityResponseErrorType4.RateLimited,
                "server_error" => CreateAssetEntityResponseErrorType4.ServerError,
                "validation_error" => CreateAssetEntityResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
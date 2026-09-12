
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetEntityResponseErrorType3
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
    public static class CreateAssetEntityResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetEntityResponseErrorType3 value)
        {
            return value switch
            {
                CreateAssetEntityResponseErrorType3.AuthorizationError => "authorization_error",
                CreateAssetEntityResponseErrorType3.NotFound => "not_found",
                CreateAssetEntityResponseErrorType3.NotImplemented => "not_implemented",
                CreateAssetEntityResponseErrorType3.RateLimited => "rate_limited",
                CreateAssetEntityResponseErrorType3.ServerError => "server_error",
                CreateAssetEntityResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetEntityResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetEntityResponseErrorType3.AuthorizationError,
                "not_found" => CreateAssetEntityResponseErrorType3.NotFound,
                "not_implemented" => CreateAssetEntityResponseErrorType3.NotImplemented,
                "rate_limited" => CreateAssetEntityResponseErrorType3.RateLimited,
                "server_error" => CreateAssetEntityResponseErrorType3.ServerError,
                "validation_error" => CreateAssetEntityResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
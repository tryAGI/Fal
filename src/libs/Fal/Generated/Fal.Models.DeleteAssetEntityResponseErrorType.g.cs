
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetEntityResponseErrorType
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
    public static class DeleteAssetEntityResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetEntityResponseErrorType value)
        {
            return value switch
            {
                DeleteAssetEntityResponseErrorType.AuthorizationError => "authorization_error",
                DeleteAssetEntityResponseErrorType.NotFound => "not_found",
                DeleteAssetEntityResponseErrorType.NotImplemented => "not_implemented",
                DeleteAssetEntityResponseErrorType.RateLimited => "rate_limited",
                DeleteAssetEntityResponseErrorType.ServerError => "server_error",
                DeleteAssetEntityResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetEntityResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetEntityResponseErrorType.AuthorizationError,
                "not_found" => DeleteAssetEntityResponseErrorType.NotFound,
                "not_implemented" => DeleteAssetEntityResponseErrorType.NotImplemented,
                "rate_limited" => DeleteAssetEntityResponseErrorType.RateLimited,
                "server_error" => DeleteAssetEntityResponseErrorType.ServerError,
                "validation_error" => DeleteAssetEntityResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
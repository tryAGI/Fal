
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetEntityResponseErrorType7
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
    public static class DeleteAssetEntityResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetEntityResponseErrorType7 value)
        {
            return value switch
            {
                DeleteAssetEntityResponseErrorType7.AuthorizationError => "authorization_error",
                DeleteAssetEntityResponseErrorType7.NotFound => "not_found",
                DeleteAssetEntityResponseErrorType7.NotImplemented => "not_implemented",
                DeleteAssetEntityResponseErrorType7.RateLimited => "rate_limited",
                DeleteAssetEntityResponseErrorType7.ServerError => "server_error",
                DeleteAssetEntityResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetEntityResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetEntityResponseErrorType7.AuthorizationError,
                "not_found" => DeleteAssetEntityResponseErrorType7.NotFound,
                "not_implemented" => DeleteAssetEntityResponseErrorType7.NotImplemented,
                "rate_limited" => DeleteAssetEntityResponseErrorType7.RateLimited,
                "server_error" => DeleteAssetEntityResponseErrorType7.ServerError,
                "validation_error" => DeleteAssetEntityResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}
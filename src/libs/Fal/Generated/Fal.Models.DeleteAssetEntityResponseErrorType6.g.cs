
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetEntityResponseErrorType6
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
    public static class DeleteAssetEntityResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetEntityResponseErrorType6 value)
        {
            return value switch
            {
                DeleteAssetEntityResponseErrorType6.AuthorizationError => "authorization_error",
                DeleteAssetEntityResponseErrorType6.NotFound => "not_found",
                DeleteAssetEntityResponseErrorType6.NotImplemented => "not_implemented",
                DeleteAssetEntityResponseErrorType6.RateLimited => "rate_limited",
                DeleteAssetEntityResponseErrorType6.ServerError => "server_error",
                DeleteAssetEntityResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetEntityResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetEntityResponseErrorType6.AuthorizationError,
                "not_found" => DeleteAssetEntityResponseErrorType6.NotFound,
                "not_implemented" => DeleteAssetEntityResponseErrorType6.NotImplemented,
                "rate_limited" => DeleteAssetEntityResponseErrorType6.RateLimited,
                "server_error" => DeleteAssetEntityResponseErrorType6.ServerError,
                "validation_error" => DeleteAssetEntityResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
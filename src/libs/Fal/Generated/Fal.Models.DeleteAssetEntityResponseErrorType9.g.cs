
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetEntityResponseErrorType9
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
    public static class DeleteAssetEntityResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetEntityResponseErrorType9 value)
        {
            return value switch
            {
                DeleteAssetEntityResponseErrorType9.AuthorizationError => "authorization_error",
                DeleteAssetEntityResponseErrorType9.NotFound => "not_found",
                DeleteAssetEntityResponseErrorType9.NotImplemented => "not_implemented",
                DeleteAssetEntityResponseErrorType9.RateLimited => "rate_limited",
                DeleteAssetEntityResponseErrorType9.ServerError => "server_error",
                DeleteAssetEntityResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetEntityResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetEntityResponseErrorType9.AuthorizationError,
                "not_found" => DeleteAssetEntityResponseErrorType9.NotFound,
                "not_implemented" => DeleteAssetEntityResponseErrorType9.NotImplemented,
                "rate_limited" => DeleteAssetEntityResponseErrorType9.RateLimited,
                "server_error" => DeleteAssetEntityResponseErrorType9.ServerError,
                "validation_error" => DeleteAssetEntityResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}
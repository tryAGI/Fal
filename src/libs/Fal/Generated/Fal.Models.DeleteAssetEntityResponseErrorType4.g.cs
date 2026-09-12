
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetEntityResponseErrorType4
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
    public static class DeleteAssetEntityResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetEntityResponseErrorType4 value)
        {
            return value switch
            {
                DeleteAssetEntityResponseErrorType4.AuthorizationError => "authorization_error",
                DeleteAssetEntityResponseErrorType4.NotFound => "not_found",
                DeleteAssetEntityResponseErrorType4.NotImplemented => "not_implemented",
                DeleteAssetEntityResponseErrorType4.RateLimited => "rate_limited",
                DeleteAssetEntityResponseErrorType4.ServerError => "server_error",
                DeleteAssetEntityResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetEntityResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetEntityResponseErrorType4.AuthorizationError,
                "not_found" => DeleteAssetEntityResponseErrorType4.NotFound,
                "not_implemented" => DeleteAssetEntityResponseErrorType4.NotImplemented,
                "rate_limited" => DeleteAssetEntityResponseErrorType4.RateLimited,
                "server_error" => DeleteAssetEntityResponseErrorType4.ServerError,
                "validation_error" => DeleteAssetEntityResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
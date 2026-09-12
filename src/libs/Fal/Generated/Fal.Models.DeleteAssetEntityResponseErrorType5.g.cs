
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetEntityResponseErrorType5
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
    public static class DeleteAssetEntityResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetEntityResponseErrorType5 value)
        {
            return value switch
            {
                DeleteAssetEntityResponseErrorType5.AuthorizationError => "authorization_error",
                DeleteAssetEntityResponseErrorType5.NotFound => "not_found",
                DeleteAssetEntityResponseErrorType5.NotImplemented => "not_implemented",
                DeleteAssetEntityResponseErrorType5.RateLimited => "rate_limited",
                DeleteAssetEntityResponseErrorType5.ServerError => "server_error",
                DeleteAssetEntityResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetEntityResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetEntityResponseErrorType5.AuthorizationError,
                "not_found" => DeleteAssetEntityResponseErrorType5.NotFound,
                "not_implemented" => DeleteAssetEntityResponseErrorType5.NotImplemented,
                "rate_limited" => DeleteAssetEntityResponseErrorType5.RateLimited,
                "server_error" => DeleteAssetEntityResponseErrorType5.ServerError,
                "validation_error" => DeleteAssetEntityResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
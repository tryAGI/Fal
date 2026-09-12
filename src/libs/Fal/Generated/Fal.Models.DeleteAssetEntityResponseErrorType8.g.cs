
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetEntityResponseErrorType8
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
    public static class DeleteAssetEntityResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetEntityResponseErrorType8 value)
        {
            return value switch
            {
                DeleteAssetEntityResponseErrorType8.AuthorizationError => "authorization_error",
                DeleteAssetEntityResponseErrorType8.NotFound => "not_found",
                DeleteAssetEntityResponseErrorType8.NotImplemented => "not_implemented",
                DeleteAssetEntityResponseErrorType8.RateLimited => "rate_limited",
                DeleteAssetEntityResponseErrorType8.ServerError => "server_error",
                DeleteAssetEntityResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetEntityResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetEntityResponseErrorType8.AuthorizationError,
                "not_found" => DeleteAssetEntityResponseErrorType8.NotFound,
                "not_implemented" => DeleteAssetEntityResponseErrorType8.NotImplemented,
                "rate_limited" => DeleteAssetEntityResponseErrorType8.RateLimited,
                "server_error" => DeleteAssetEntityResponseErrorType8.ServerError,
                "validation_error" => DeleteAssetEntityResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
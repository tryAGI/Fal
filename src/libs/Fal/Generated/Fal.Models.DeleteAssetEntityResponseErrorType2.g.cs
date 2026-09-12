
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetEntityResponseErrorType2
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
    public static class DeleteAssetEntityResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetEntityResponseErrorType2 value)
        {
            return value switch
            {
                DeleteAssetEntityResponseErrorType2.AuthorizationError => "authorization_error",
                DeleteAssetEntityResponseErrorType2.NotFound => "not_found",
                DeleteAssetEntityResponseErrorType2.NotImplemented => "not_implemented",
                DeleteAssetEntityResponseErrorType2.RateLimited => "rate_limited",
                DeleteAssetEntityResponseErrorType2.ServerError => "server_error",
                DeleteAssetEntityResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetEntityResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetEntityResponseErrorType2.AuthorizationError,
                "not_found" => DeleteAssetEntityResponseErrorType2.NotFound,
                "not_implemented" => DeleteAssetEntityResponseErrorType2.NotImplemented,
                "rate_limited" => DeleteAssetEntityResponseErrorType2.RateLimited,
                "server_error" => DeleteAssetEntityResponseErrorType2.ServerError,
                "validation_error" => DeleteAssetEntityResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
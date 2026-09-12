
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetEntityResponseErrorType3
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
    public static class DeleteAssetEntityResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetEntityResponseErrorType3 value)
        {
            return value switch
            {
                DeleteAssetEntityResponseErrorType3.AuthorizationError => "authorization_error",
                DeleteAssetEntityResponseErrorType3.NotFound => "not_found",
                DeleteAssetEntityResponseErrorType3.NotImplemented => "not_implemented",
                DeleteAssetEntityResponseErrorType3.RateLimited => "rate_limited",
                DeleteAssetEntityResponseErrorType3.ServerError => "server_error",
                DeleteAssetEntityResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetEntityResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetEntityResponseErrorType3.AuthorizationError,
                "not_found" => DeleteAssetEntityResponseErrorType3.NotFound,
                "not_implemented" => DeleteAssetEntityResponseErrorType3.NotImplemented,
                "rate_limited" => DeleteAssetEntityResponseErrorType3.RateLimited,
                "server_error" => DeleteAssetEntityResponseErrorType3.ServerError,
                "validation_error" => DeleteAssetEntityResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
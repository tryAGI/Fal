
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetEntityResponseErrorType8
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
    public static class GetAssetEntityResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetEntityResponseErrorType8 value)
        {
            return value switch
            {
                GetAssetEntityResponseErrorType8.AuthorizationError => "authorization_error",
                GetAssetEntityResponseErrorType8.NotFound => "not_found",
                GetAssetEntityResponseErrorType8.NotImplemented => "not_implemented",
                GetAssetEntityResponseErrorType8.RateLimited => "rate_limited",
                GetAssetEntityResponseErrorType8.ServerError => "server_error",
                GetAssetEntityResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetEntityResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetEntityResponseErrorType8.AuthorizationError,
                "not_found" => GetAssetEntityResponseErrorType8.NotFound,
                "not_implemented" => GetAssetEntityResponseErrorType8.NotImplemented,
                "rate_limited" => GetAssetEntityResponseErrorType8.RateLimited,
                "server_error" => GetAssetEntityResponseErrorType8.ServerError,
                "validation_error" => GetAssetEntityResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
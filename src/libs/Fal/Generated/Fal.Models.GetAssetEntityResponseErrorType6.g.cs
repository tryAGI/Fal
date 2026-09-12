
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetEntityResponseErrorType6
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
    public static class GetAssetEntityResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetEntityResponseErrorType6 value)
        {
            return value switch
            {
                GetAssetEntityResponseErrorType6.AuthorizationError => "authorization_error",
                GetAssetEntityResponseErrorType6.NotFound => "not_found",
                GetAssetEntityResponseErrorType6.NotImplemented => "not_implemented",
                GetAssetEntityResponseErrorType6.RateLimited => "rate_limited",
                GetAssetEntityResponseErrorType6.ServerError => "server_error",
                GetAssetEntityResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetEntityResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetEntityResponseErrorType6.AuthorizationError,
                "not_found" => GetAssetEntityResponseErrorType6.NotFound,
                "not_implemented" => GetAssetEntityResponseErrorType6.NotImplemented,
                "rate_limited" => GetAssetEntityResponseErrorType6.RateLimited,
                "server_error" => GetAssetEntityResponseErrorType6.ServerError,
                "validation_error" => GetAssetEntityResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
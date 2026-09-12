
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetEntityResponseErrorType4
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
    public static class GetAssetEntityResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetEntityResponseErrorType4 value)
        {
            return value switch
            {
                GetAssetEntityResponseErrorType4.AuthorizationError => "authorization_error",
                GetAssetEntityResponseErrorType4.NotFound => "not_found",
                GetAssetEntityResponseErrorType4.NotImplemented => "not_implemented",
                GetAssetEntityResponseErrorType4.RateLimited => "rate_limited",
                GetAssetEntityResponseErrorType4.ServerError => "server_error",
                GetAssetEntityResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetEntityResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetEntityResponseErrorType4.AuthorizationError,
                "not_found" => GetAssetEntityResponseErrorType4.NotFound,
                "not_implemented" => GetAssetEntityResponseErrorType4.NotImplemented,
                "rate_limited" => GetAssetEntityResponseErrorType4.RateLimited,
                "server_error" => GetAssetEntityResponseErrorType4.ServerError,
                "validation_error" => GetAssetEntityResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
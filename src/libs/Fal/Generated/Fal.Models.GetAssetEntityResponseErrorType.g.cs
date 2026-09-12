
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetEntityResponseErrorType
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
    public static class GetAssetEntityResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetEntityResponseErrorType value)
        {
            return value switch
            {
                GetAssetEntityResponseErrorType.AuthorizationError => "authorization_error",
                GetAssetEntityResponseErrorType.NotFound => "not_found",
                GetAssetEntityResponseErrorType.NotImplemented => "not_implemented",
                GetAssetEntityResponseErrorType.RateLimited => "rate_limited",
                GetAssetEntityResponseErrorType.ServerError => "server_error",
                GetAssetEntityResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetEntityResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetEntityResponseErrorType.AuthorizationError,
                "not_found" => GetAssetEntityResponseErrorType.NotFound,
                "not_implemented" => GetAssetEntityResponseErrorType.NotImplemented,
                "rate_limited" => GetAssetEntityResponseErrorType.RateLimited,
                "server_error" => GetAssetEntityResponseErrorType.ServerError,
                "validation_error" => GetAssetEntityResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
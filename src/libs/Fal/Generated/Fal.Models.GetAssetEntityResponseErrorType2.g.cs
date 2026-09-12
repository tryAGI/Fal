
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetEntityResponseErrorType2
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
    public static class GetAssetEntityResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetEntityResponseErrorType2 value)
        {
            return value switch
            {
                GetAssetEntityResponseErrorType2.AuthorizationError => "authorization_error",
                GetAssetEntityResponseErrorType2.NotFound => "not_found",
                GetAssetEntityResponseErrorType2.NotImplemented => "not_implemented",
                GetAssetEntityResponseErrorType2.RateLimited => "rate_limited",
                GetAssetEntityResponseErrorType2.ServerError => "server_error",
                GetAssetEntityResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetEntityResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetEntityResponseErrorType2.AuthorizationError,
                "not_found" => GetAssetEntityResponseErrorType2.NotFound,
                "not_implemented" => GetAssetEntityResponseErrorType2.NotImplemented,
                "rate_limited" => GetAssetEntityResponseErrorType2.RateLimited,
                "server_error" => GetAssetEntityResponseErrorType2.ServerError,
                "validation_error" => GetAssetEntityResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetTagResponseErrorType8
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
    public static class DeleteAssetTagResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetTagResponseErrorType8 value)
        {
            return value switch
            {
                DeleteAssetTagResponseErrorType8.AuthorizationError => "authorization_error",
                DeleteAssetTagResponseErrorType8.NotFound => "not_found",
                DeleteAssetTagResponseErrorType8.NotImplemented => "not_implemented",
                DeleteAssetTagResponseErrorType8.RateLimited => "rate_limited",
                DeleteAssetTagResponseErrorType8.ServerError => "server_error",
                DeleteAssetTagResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetTagResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetTagResponseErrorType8.AuthorizationError,
                "not_found" => DeleteAssetTagResponseErrorType8.NotFound,
                "not_implemented" => DeleteAssetTagResponseErrorType8.NotImplemented,
                "rate_limited" => DeleteAssetTagResponseErrorType8.RateLimited,
                "server_error" => DeleteAssetTagResponseErrorType8.ServerError,
                "validation_error" => DeleteAssetTagResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
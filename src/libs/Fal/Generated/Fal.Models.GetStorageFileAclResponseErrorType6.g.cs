
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetStorageFileAclResponseErrorType6
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
    public static class GetStorageFileAclResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStorageFileAclResponseErrorType6 value)
        {
            return value switch
            {
                GetStorageFileAclResponseErrorType6.AuthorizationError => "authorization_error",
                GetStorageFileAclResponseErrorType6.NotFound => "not_found",
                GetStorageFileAclResponseErrorType6.NotImplemented => "not_implemented",
                GetStorageFileAclResponseErrorType6.RateLimited => "rate_limited",
                GetStorageFileAclResponseErrorType6.ServerError => "server_error",
                GetStorageFileAclResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStorageFileAclResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetStorageFileAclResponseErrorType6.AuthorizationError,
                "not_found" => GetStorageFileAclResponseErrorType6.NotFound,
                "not_implemented" => GetStorageFileAclResponseErrorType6.NotImplemented,
                "rate_limited" => GetStorageFileAclResponseErrorType6.RateLimited,
                "server_error" => GetStorageFileAclResponseErrorType6.ServerError,
                "validation_error" => GetStorageFileAclResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetStorageFileAclResponseErrorType3
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
    public static class GetStorageFileAclResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStorageFileAclResponseErrorType3 value)
        {
            return value switch
            {
                GetStorageFileAclResponseErrorType3.AuthorizationError => "authorization_error",
                GetStorageFileAclResponseErrorType3.NotFound => "not_found",
                GetStorageFileAclResponseErrorType3.NotImplemented => "not_implemented",
                GetStorageFileAclResponseErrorType3.RateLimited => "rate_limited",
                GetStorageFileAclResponseErrorType3.ServerError => "server_error",
                GetStorageFileAclResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStorageFileAclResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetStorageFileAclResponseErrorType3.AuthorizationError,
                "not_found" => GetStorageFileAclResponseErrorType3.NotFound,
                "not_implemented" => GetStorageFileAclResponseErrorType3.NotImplemented,
                "rate_limited" => GetStorageFileAclResponseErrorType3.RateLimited,
                "server_error" => GetStorageFileAclResponseErrorType3.ServerError,
                "validation_error" => GetStorageFileAclResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
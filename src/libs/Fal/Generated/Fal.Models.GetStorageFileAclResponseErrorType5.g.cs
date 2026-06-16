
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetStorageFileAclResponseErrorType5
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
    public static class GetStorageFileAclResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStorageFileAclResponseErrorType5 value)
        {
            return value switch
            {
                GetStorageFileAclResponseErrorType5.AuthorizationError => "authorization_error",
                GetStorageFileAclResponseErrorType5.NotFound => "not_found",
                GetStorageFileAclResponseErrorType5.NotImplemented => "not_implemented",
                GetStorageFileAclResponseErrorType5.RateLimited => "rate_limited",
                GetStorageFileAclResponseErrorType5.ServerError => "server_error",
                GetStorageFileAclResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStorageFileAclResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetStorageFileAclResponseErrorType5.AuthorizationError,
                "not_found" => GetStorageFileAclResponseErrorType5.NotFound,
                "not_implemented" => GetStorageFileAclResponseErrorType5.NotImplemented,
                "rate_limited" => GetStorageFileAclResponseErrorType5.RateLimited,
                "server_error" => GetStorageFileAclResponseErrorType5.ServerError,
                "validation_error" => GetStorageFileAclResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
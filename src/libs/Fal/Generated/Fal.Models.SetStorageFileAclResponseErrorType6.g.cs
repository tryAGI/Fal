
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SetStorageFileAclResponseErrorType6
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
    public static class SetStorageFileAclResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetStorageFileAclResponseErrorType6 value)
        {
            return value switch
            {
                SetStorageFileAclResponseErrorType6.AuthorizationError => "authorization_error",
                SetStorageFileAclResponseErrorType6.NotFound => "not_found",
                SetStorageFileAclResponseErrorType6.NotImplemented => "not_implemented",
                SetStorageFileAclResponseErrorType6.RateLimited => "rate_limited",
                SetStorageFileAclResponseErrorType6.ServerError => "server_error",
                SetStorageFileAclResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetStorageFileAclResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SetStorageFileAclResponseErrorType6.AuthorizationError,
                "not_found" => SetStorageFileAclResponseErrorType6.NotFound,
                "not_implemented" => SetStorageFileAclResponseErrorType6.NotImplemented,
                "rate_limited" => SetStorageFileAclResponseErrorType6.RateLimited,
                "server_error" => SetStorageFileAclResponseErrorType6.ServerError,
                "validation_error" => SetStorageFileAclResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
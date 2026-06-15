
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SetStorageFileAclResponseErrorType3
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
    public static class SetStorageFileAclResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetStorageFileAclResponseErrorType3 value)
        {
            return value switch
            {
                SetStorageFileAclResponseErrorType3.AuthorizationError => "authorization_error",
                SetStorageFileAclResponseErrorType3.NotFound => "not_found",
                SetStorageFileAclResponseErrorType3.NotImplemented => "not_implemented",
                SetStorageFileAclResponseErrorType3.RateLimited => "rate_limited",
                SetStorageFileAclResponseErrorType3.ServerError => "server_error",
                SetStorageFileAclResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetStorageFileAclResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SetStorageFileAclResponseErrorType3.AuthorizationError,
                "not_found" => SetStorageFileAclResponseErrorType3.NotFound,
                "not_implemented" => SetStorageFileAclResponseErrorType3.NotImplemented,
                "rate_limited" => SetStorageFileAclResponseErrorType3.RateLimited,
                "server_error" => SetStorageFileAclResponseErrorType3.ServerError,
                "validation_error" => SetStorageFileAclResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
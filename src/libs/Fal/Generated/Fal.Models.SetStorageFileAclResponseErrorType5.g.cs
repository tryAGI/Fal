
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SetStorageFileAclResponseErrorType5
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
    public static class SetStorageFileAclResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetStorageFileAclResponseErrorType5 value)
        {
            return value switch
            {
                SetStorageFileAclResponseErrorType5.AuthorizationError => "authorization_error",
                SetStorageFileAclResponseErrorType5.NotFound => "not_found",
                SetStorageFileAclResponseErrorType5.NotImplemented => "not_implemented",
                SetStorageFileAclResponseErrorType5.RateLimited => "rate_limited",
                SetStorageFileAclResponseErrorType5.ServerError => "server_error",
                SetStorageFileAclResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetStorageFileAclResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SetStorageFileAclResponseErrorType5.AuthorizationError,
                "not_found" => SetStorageFileAclResponseErrorType5.NotFound,
                "not_implemented" => SetStorageFileAclResponseErrorType5.NotImplemented,
                "rate_limited" => SetStorageFileAclResponseErrorType5.RateLimited,
                "server_error" => SetStorageFileAclResponseErrorType5.ServerError,
                "validation_error" => SetStorageFileAclResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}
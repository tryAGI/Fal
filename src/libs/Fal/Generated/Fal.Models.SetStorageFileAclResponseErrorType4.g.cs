
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SetStorageFileAclResponseErrorType4
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
    public static class SetStorageFileAclResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetStorageFileAclResponseErrorType4 value)
        {
            return value switch
            {
                SetStorageFileAclResponseErrorType4.AuthorizationError => "authorization_error",
                SetStorageFileAclResponseErrorType4.NotFound => "not_found",
                SetStorageFileAclResponseErrorType4.NotImplemented => "not_implemented",
                SetStorageFileAclResponseErrorType4.RateLimited => "rate_limited",
                SetStorageFileAclResponseErrorType4.ServerError => "server_error",
                SetStorageFileAclResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetStorageFileAclResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SetStorageFileAclResponseErrorType4.AuthorizationError,
                "not_found" => SetStorageFileAclResponseErrorType4.NotFound,
                "not_implemented" => SetStorageFileAclResponseErrorType4.NotImplemented,
                "rate_limited" => SetStorageFileAclResponseErrorType4.RateLimited,
                "server_error" => SetStorageFileAclResponseErrorType4.ServerError,
                "validation_error" => SetStorageFileAclResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SetStorageFileAclResponseErrorType
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
    public static class SetStorageFileAclResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetStorageFileAclResponseErrorType value)
        {
            return value switch
            {
                SetStorageFileAclResponseErrorType.AuthorizationError => "authorization_error",
                SetStorageFileAclResponseErrorType.NotFound => "not_found",
                SetStorageFileAclResponseErrorType.NotImplemented => "not_implemented",
                SetStorageFileAclResponseErrorType.RateLimited => "rate_limited",
                SetStorageFileAclResponseErrorType.ServerError => "server_error",
                SetStorageFileAclResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetStorageFileAclResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SetStorageFileAclResponseErrorType.AuthorizationError,
                "not_found" => SetStorageFileAclResponseErrorType.NotFound,
                "not_implemented" => SetStorageFileAclResponseErrorType.NotImplemented,
                "rate_limited" => SetStorageFileAclResponseErrorType.RateLimited,
                "server_error" => SetStorageFileAclResponseErrorType.ServerError,
                "validation_error" => SetStorageFileAclResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
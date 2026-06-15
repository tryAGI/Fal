
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SetStorageFileAclResponseErrorType2
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
    public static class SetStorageFileAclResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetStorageFileAclResponseErrorType2 value)
        {
            return value switch
            {
                SetStorageFileAclResponseErrorType2.AuthorizationError => "authorization_error",
                SetStorageFileAclResponseErrorType2.NotFound => "not_found",
                SetStorageFileAclResponseErrorType2.NotImplemented => "not_implemented",
                SetStorageFileAclResponseErrorType2.RateLimited => "rate_limited",
                SetStorageFileAclResponseErrorType2.ServerError => "server_error",
                SetStorageFileAclResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetStorageFileAclResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SetStorageFileAclResponseErrorType2.AuthorizationError,
                "not_found" => SetStorageFileAclResponseErrorType2.NotFound,
                "not_implemented" => SetStorageFileAclResponseErrorType2.NotImplemented,
                "rate_limited" => SetStorageFileAclResponseErrorType2.RateLimited,
                "server_error" => SetStorageFileAclResponseErrorType2.ServerError,
                "validation_error" => SetStorageFileAclResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetStorageFileAclResponseErrorType4
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
    public static class GetStorageFileAclResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStorageFileAclResponseErrorType4 value)
        {
            return value switch
            {
                GetStorageFileAclResponseErrorType4.AuthorizationError => "authorization_error",
                GetStorageFileAclResponseErrorType4.NotFound => "not_found",
                GetStorageFileAclResponseErrorType4.NotImplemented => "not_implemented",
                GetStorageFileAclResponseErrorType4.RateLimited => "rate_limited",
                GetStorageFileAclResponseErrorType4.ServerError => "server_error",
                GetStorageFileAclResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStorageFileAclResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetStorageFileAclResponseErrorType4.AuthorizationError,
                "not_found" => GetStorageFileAclResponseErrorType4.NotFound,
                "not_implemented" => GetStorageFileAclResponseErrorType4.NotImplemented,
                "rate_limited" => GetStorageFileAclResponseErrorType4.RateLimited,
                "server_error" => GetStorageFileAclResponseErrorType4.ServerError,
                "validation_error" => GetStorageFileAclResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
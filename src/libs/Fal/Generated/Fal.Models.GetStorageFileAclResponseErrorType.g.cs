
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetStorageFileAclResponseErrorType
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
    public static class GetStorageFileAclResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStorageFileAclResponseErrorType value)
        {
            return value switch
            {
                GetStorageFileAclResponseErrorType.AuthorizationError => "authorization_error",
                GetStorageFileAclResponseErrorType.NotFound => "not_found",
                GetStorageFileAclResponseErrorType.NotImplemented => "not_implemented",
                GetStorageFileAclResponseErrorType.RateLimited => "rate_limited",
                GetStorageFileAclResponseErrorType.ServerError => "server_error",
                GetStorageFileAclResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStorageFileAclResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetStorageFileAclResponseErrorType.AuthorizationError,
                "not_found" => GetStorageFileAclResponseErrorType.NotFound,
                "not_implemented" => GetStorageFileAclResponseErrorType.NotImplemented,
                "rate_limited" => GetStorageFileAclResponseErrorType.RateLimited,
                "server_error" => GetStorageFileAclResponseErrorType.ServerError,
                "validation_error" => GetStorageFileAclResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}
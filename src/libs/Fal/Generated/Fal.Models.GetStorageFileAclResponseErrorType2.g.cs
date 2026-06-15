
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetStorageFileAclResponseErrorType2
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
    public static class GetStorageFileAclResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStorageFileAclResponseErrorType2 value)
        {
            return value switch
            {
                GetStorageFileAclResponseErrorType2.AuthorizationError => "authorization_error",
                GetStorageFileAclResponseErrorType2.NotFound => "not_found",
                GetStorageFileAclResponseErrorType2.NotImplemented => "not_implemented",
                GetStorageFileAclResponseErrorType2.RateLimited => "rate_limited",
                GetStorageFileAclResponseErrorType2.ServerError => "server_error",
                GetStorageFileAclResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStorageFileAclResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetStorageFileAclResponseErrorType2.AuthorizationError,
                "not_found" => GetStorageFileAclResponseErrorType2.NotFound,
                "not_implemented" => GetStorageFileAclResponseErrorType2.NotImplemented,
                "rate_limited" => GetStorageFileAclResponseErrorType2.RateLimited,
                "server_error" => GetStorageFileAclResponseErrorType2.ServerError,
                "validation_error" => GetStorageFileAclResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}
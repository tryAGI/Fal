
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum MoveAssetCollectionResponseErrorType8
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
    public static class MoveAssetCollectionResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MoveAssetCollectionResponseErrorType8 value)
        {
            return value switch
            {
                MoveAssetCollectionResponseErrorType8.AuthorizationError => "authorization_error",
                MoveAssetCollectionResponseErrorType8.NotFound => "not_found",
                MoveAssetCollectionResponseErrorType8.NotImplemented => "not_implemented",
                MoveAssetCollectionResponseErrorType8.RateLimited => "rate_limited",
                MoveAssetCollectionResponseErrorType8.ServerError => "server_error",
                MoveAssetCollectionResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MoveAssetCollectionResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => MoveAssetCollectionResponseErrorType8.AuthorizationError,
                "not_found" => MoveAssetCollectionResponseErrorType8.NotFound,
                "not_implemented" => MoveAssetCollectionResponseErrorType8.NotImplemented,
                "rate_limited" => MoveAssetCollectionResponseErrorType8.RateLimited,
                "server_error" => MoveAssetCollectionResponseErrorType8.ServerError,
                "validation_error" => MoveAssetCollectionResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}
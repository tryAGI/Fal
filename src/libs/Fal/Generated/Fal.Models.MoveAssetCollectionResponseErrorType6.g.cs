
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum MoveAssetCollectionResponseErrorType6
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
    public static class MoveAssetCollectionResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MoveAssetCollectionResponseErrorType6 value)
        {
            return value switch
            {
                MoveAssetCollectionResponseErrorType6.AuthorizationError => "authorization_error",
                MoveAssetCollectionResponseErrorType6.NotFound => "not_found",
                MoveAssetCollectionResponseErrorType6.NotImplemented => "not_implemented",
                MoveAssetCollectionResponseErrorType6.RateLimited => "rate_limited",
                MoveAssetCollectionResponseErrorType6.ServerError => "server_error",
                MoveAssetCollectionResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MoveAssetCollectionResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => MoveAssetCollectionResponseErrorType6.AuthorizationError,
                "not_found" => MoveAssetCollectionResponseErrorType6.NotFound,
                "not_implemented" => MoveAssetCollectionResponseErrorType6.NotImplemented,
                "rate_limited" => MoveAssetCollectionResponseErrorType6.RateLimited,
                "server_error" => MoveAssetCollectionResponseErrorType6.ServerError,
                "validation_error" => MoveAssetCollectionResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}
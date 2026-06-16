
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum MoveAssetCollectionResponseErrorType3
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
    public static class MoveAssetCollectionResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MoveAssetCollectionResponseErrorType3 value)
        {
            return value switch
            {
                MoveAssetCollectionResponseErrorType3.AuthorizationError => "authorization_error",
                MoveAssetCollectionResponseErrorType3.NotFound => "not_found",
                MoveAssetCollectionResponseErrorType3.NotImplemented => "not_implemented",
                MoveAssetCollectionResponseErrorType3.RateLimited => "rate_limited",
                MoveAssetCollectionResponseErrorType3.ServerError => "server_error",
                MoveAssetCollectionResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MoveAssetCollectionResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => MoveAssetCollectionResponseErrorType3.AuthorizationError,
                "not_found" => MoveAssetCollectionResponseErrorType3.NotFound,
                "not_implemented" => MoveAssetCollectionResponseErrorType3.NotImplemented,
                "rate_limited" => MoveAssetCollectionResponseErrorType3.RateLimited,
                "server_error" => MoveAssetCollectionResponseErrorType3.ServerError,
                "validation_error" => MoveAssetCollectionResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}
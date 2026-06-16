
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum MoveAssetCollectionResponseErrorType4
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
    public static class MoveAssetCollectionResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MoveAssetCollectionResponseErrorType4 value)
        {
            return value switch
            {
                MoveAssetCollectionResponseErrorType4.AuthorizationError => "authorization_error",
                MoveAssetCollectionResponseErrorType4.NotFound => "not_found",
                MoveAssetCollectionResponseErrorType4.NotImplemented => "not_implemented",
                MoveAssetCollectionResponseErrorType4.RateLimited => "rate_limited",
                MoveAssetCollectionResponseErrorType4.ServerError => "server_error",
                MoveAssetCollectionResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MoveAssetCollectionResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => MoveAssetCollectionResponseErrorType4.AuthorizationError,
                "not_found" => MoveAssetCollectionResponseErrorType4.NotFound,
                "not_implemented" => MoveAssetCollectionResponseErrorType4.NotImplemented,
                "rate_limited" => MoveAssetCollectionResponseErrorType4.RateLimited,
                "server_error" => MoveAssetCollectionResponseErrorType4.ServerError,
                "validation_error" => MoveAssetCollectionResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}
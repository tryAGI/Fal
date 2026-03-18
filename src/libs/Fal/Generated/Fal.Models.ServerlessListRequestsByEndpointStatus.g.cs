
#nullable enable

namespace Fal
{
    /// <summary>
    /// Filter by request status<br/>
    /// Example: success
    /// </summary>
    public enum ServerlessListRequestsByEndpointStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        UserError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessListRequestsByEndpointStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListRequestsByEndpointStatus value)
        {
            return value switch
            {
                ServerlessListRequestsByEndpointStatus.Success => "success",
                ServerlessListRequestsByEndpointStatus.Error => "error",
                ServerlessListRequestsByEndpointStatus.UserError => "user_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListRequestsByEndpointStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => ServerlessListRequestsByEndpointStatus.Success,
                "error" => ServerlessListRequestsByEndpointStatus.Error,
                "user_error" => ServerlessListRequestsByEndpointStatus.UserError,
                _ => null,
            };
        }
    }
}
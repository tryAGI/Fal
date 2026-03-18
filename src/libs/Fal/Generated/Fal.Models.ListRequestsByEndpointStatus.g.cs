
#nullable enable

namespace Fal
{
    /// <summary>
    /// Filter by request status<br/>
    /// Example: success
    /// </summary>
    public enum ListRequestsByEndpointStatus
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
    public static class ListRequestsByEndpointStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRequestsByEndpointStatus value)
        {
            return value switch
            {
                ListRequestsByEndpointStatus.Success => "success",
                ListRequestsByEndpointStatus.Error => "error",
                ListRequestsByEndpointStatus.UserError => "user_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRequestsByEndpointStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => ListRequestsByEndpointStatus.Success,
                "error" => ListRequestsByEndpointStatus.Error,
                "user_error" => ListRequestsByEndpointStatus.UserError,
                _ => null,
            };
        }
    }
}
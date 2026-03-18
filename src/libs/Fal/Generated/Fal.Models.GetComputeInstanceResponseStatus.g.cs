
#nullable enable

namespace Fal
{
    /// <summary>
    /// Current operational status of the instance<br/>
    /// Example: ready
    /// </summary>
    public enum GetComputeInstanceResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Init,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Provisioning,
        /// <summary>
        /// 
        /// </summary>
        Stopped,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetComputeInstanceResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeInstanceResponseStatus value)
        {
            return value switch
            {
                GetComputeInstanceResponseStatus.Ready => "ready",
                GetComputeInstanceResponseStatus.Init => "init",
                GetComputeInstanceResponseStatus.Pending => "pending",
                GetComputeInstanceResponseStatus.Provisioning => "provisioning",
                GetComputeInstanceResponseStatus.Stopped => "stopped",
                GetComputeInstanceResponseStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeInstanceResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ready" => GetComputeInstanceResponseStatus.Ready,
                "init" => GetComputeInstanceResponseStatus.Init,
                "pending" => GetComputeInstanceResponseStatus.Pending,
                "provisioning" => GetComputeInstanceResponseStatus.Provisioning,
                "stopped" => GetComputeInstanceResponseStatus.Stopped,
                "unknown" => GetComputeInstanceResponseStatus.Unknown,
                _ => null,
            };
        }
    }
}
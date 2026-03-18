
#nullable enable

namespace Fal
{
    /// <summary>
    /// Current operational status of the instance<br/>
    /// Example: ready
    /// </summary>
    public enum ListComputeInstancesResponseInstanceStatus
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
    public static class ListComputeInstancesResponseInstanceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListComputeInstancesResponseInstanceStatus value)
        {
            return value switch
            {
                ListComputeInstancesResponseInstanceStatus.Ready => "ready",
                ListComputeInstancesResponseInstanceStatus.Init => "init",
                ListComputeInstancesResponseInstanceStatus.Pending => "pending",
                ListComputeInstancesResponseInstanceStatus.Provisioning => "provisioning",
                ListComputeInstancesResponseInstanceStatus.Stopped => "stopped",
                ListComputeInstancesResponseInstanceStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListComputeInstancesResponseInstanceStatus? ToEnum(string value)
        {
            return value switch
            {
                "ready" => ListComputeInstancesResponseInstanceStatus.Ready,
                "init" => ListComputeInstancesResponseInstanceStatus.Init,
                "pending" => ListComputeInstancesResponseInstanceStatus.Pending,
                "provisioning" => ListComputeInstancesResponseInstanceStatus.Provisioning,
                "stopped" => ListComputeInstancesResponseInstanceStatus.Stopped,
                "unknown" => ListComputeInstancesResponseInstanceStatus.Unknown,
                _ => null,
            };
        }
    }
}
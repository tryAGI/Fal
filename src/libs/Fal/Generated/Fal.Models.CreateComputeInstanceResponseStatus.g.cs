
#nullable enable

namespace Fal
{
    /// <summary>
    /// Current operational status of the instance<br/>
    /// Example: ready
    /// </summary>
    public enum CreateComputeInstanceResponseStatus
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
    public static class CreateComputeInstanceResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputeInstanceResponseStatus value)
        {
            return value switch
            {
                CreateComputeInstanceResponseStatus.Ready => "ready",
                CreateComputeInstanceResponseStatus.Init => "init",
                CreateComputeInstanceResponseStatus.Pending => "pending",
                CreateComputeInstanceResponseStatus.Provisioning => "provisioning",
                CreateComputeInstanceResponseStatus.Stopped => "stopped",
                CreateComputeInstanceResponseStatus.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputeInstanceResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "ready" => CreateComputeInstanceResponseStatus.Ready,
                "init" => CreateComputeInstanceResponseStatus.Init,
                "pending" => CreateComputeInstanceResponseStatus.Pending,
                "provisioning" => CreateComputeInstanceResponseStatus.Provisioning,
                "stopped" => CreateComputeInstanceResponseStatus.Stopped,
                "unknown" => CreateComputeInstanceResponseStatus.Unknown,
                _ => null,
            };
        }
    }
}
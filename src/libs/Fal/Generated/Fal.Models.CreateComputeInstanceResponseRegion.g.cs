
#nullable enable

namespace Fal
{
    /// <summary>
    /// Geographical region where the instance is located<br/>
    /// Example: us-west
    /// </summary>
    public enum CreateComputeInstanceResponseRegion
    {
        /// <summary>
        /// 
        /// </summary>
        UsWest,
        /// <summary>
        /// 
        /// </summary>
        UsCentral,
        /// <summary>
        /// 
        /// </summary>
        UsEast,
        /// <summary>
        /// 
        /// </summary>
        EuNorth,
        /// <summary>
        /// 
        /// </summary>
        EuWest,
        /// <summary>
        /// 
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateComputeInstanceResponseRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputeInstanceResponseRegion value)
        {
            return value switch
            {
                CreateComputeInstanceResponseRegion.UsWest => "us-west",
                CreateComputeInstanceResponseRegion.UsCentral => "us-central",
                CreateComputeInstanceResponseRegion.UsEast => "us-east",
                CreateComputeInstanceResponseRegion.EuNorth => "eu-north",
                CreateComputeInstanceResponseRegion.EuWest => "eu-west",
                CreateComputeInstanceResponseRegion.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputeInstanceResponseRegion? ToEnum(string value)
        {
            return value switch
            {
                "us-west" => CreateComputeInstanceResponseRegion.UsWest,
                "us-central" => CreateComputeInstanceResponseRegion.UsCentral,
                "us-east" => CreateComputeInstanceResponseRegion.UsEast,
                "eu-north" => CreateComputeInstanceResponseRegion.EuNorth,
                "eu-west" => CreateComputeInstanceResponseRegion.EuWest,
                "other" => CreateComputeInstanceResponseRegion.Other,
                _ => null,
            };
        }
    }
}
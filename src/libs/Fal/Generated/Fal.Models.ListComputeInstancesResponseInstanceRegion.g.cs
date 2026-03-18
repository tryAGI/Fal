
#nullable enable

namespace Fal
{
    /// <summary>
    /// Geographical region where the instance is located<br/>
    /// Example: us-west
    /// </summary>
    public enum ListComputeInstancesResponseInstanceRegion
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
    public static class ListComputeInstancesResponseInstanceRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListComputeInstancesResponseInstanceRegion value)
        {
            return value switch
            {
                ListComputeInstancesResponseInstanceRegion.UsWest => "us-west",
                ListComputeInstancesResponseInstanceRegion.UsCentral => "us-central",
                ListComputeInstancesResponseInstanceRegion.UsEast => "us-east",
                ListComputeInstancesResponseInstanceRegion.EuNorth => "eu-north",
                ListComputeInstancesResponseInstanceRegion.EuWest => "eu-west",
                ListComputeInstancesResponseInstanceRegion.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListComputeInstancesResponseInstanceRegion? ToEnum(string value)
        {
            return value switch
            {
                "us-west" => ListComputeInstancesResponseInstanceRegion.UsWest,
                "us-central" => ListComputeInstancesResponseInstanceRegion.UsCentral,
                "us-east" => ListComputeInstancesResponseInstanceRegion.UsEast,
                "eu-north" => ListComputeInstancesResponseInstanceRegion.EuNorth,
                "eu-west" => ListComputeInstancesResponseInstanceRegion.EuWest,
                "other" => ListComputeInstancesResponseInstanceRegion.Other,
                _ => null,
            };
        }
    }
}
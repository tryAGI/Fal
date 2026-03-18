
#nullable enable

namespace Fal
{
    /// <summary>
    /// License type for the model (optional)
    /// </summary>
    public enum GetModelsResponseModelMetadataLicenseType
    {
        /// <summary>
        /// 
        /// </summary>
        Commercial,
        /// <summary>
        /// 
        /// </summary>
        Research,
        /// <summary>
        /// 
        /// </summary>
        Private,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsResponseModelMetadataLicenseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsResponseModelMetadataLicenseType value)
        {
            return value switch
            {
                GetModelsResponseModelMetadataLicenseType.Commercial => "commercial",
                GetModelsResponseModelMetadataLicenseType.Research => "research",
                GetModelsResponseModelMetadataLicenseType.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsResponseModelMetadataLicenseType? ToEnum(string value)
        {
            return value switch
            {
                "commercial" => GetModelsResponseModelMetadataLicenseType.Commercial,
                "research" => GetModelsResponseModelMetadataLicenseType.Research,
                "private" => GetModelsResponseModelMetadataLicenseType.Private,
                _ => null,
            };
        }
    }
}
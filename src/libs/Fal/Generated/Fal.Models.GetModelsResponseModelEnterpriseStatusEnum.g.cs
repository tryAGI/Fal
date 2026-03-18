
#nullable enable

namespace Fal
{
    /// <summary>
    /// 'ready' means approved for enterprise use, 'pending' means awaiting approval
    /// </summary>
    public enum GetModelsResponseModelEnterpriseStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Ready,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsResponseModelEnterpriseStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsResponseModelEnterpriseStatusEnum value)
        {
            return value switch
            {
                GetModelsResponseModelEnterpriseStatusEnum.Ready => "ready",
                GetModelsResponseModelEnterpriseStatusEnum.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsResponseModelEnterpriseStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "ready" => GetModelsResponseModelEnterpriseStatusEnum.Ready,
                "pending" => GetModelsResponseModelEnterpriseStatusEnum.Pending,
                _ => null,
            };
        }
    }
}
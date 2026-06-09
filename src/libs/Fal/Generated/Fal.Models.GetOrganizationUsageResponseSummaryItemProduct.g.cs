
#nullable enable

namespace Fal
{
    /// <summary>
    /// Product line the usage belongs to: 'model_apis' (fal Model APIs — endpoint calls), 'serverless' (fal Serverless SDK billing), or 'compute' (fal Compute — raw instances).<br/>
    /// Example: model_apis
    /// </summary>
    public enum GetOrganizationUsageResponseSummaryItemProduct
    {
        /// <summary>
        /// 'model_apis' (fal Model APIs — endpoint calls), 'serverless' (fal Serverless SDK billing), or 'compute' (fal Compute — raw instances).
        /// </summary>
        Compute,
        /// <summary>
        /// 'model_apis' (fal Model APIs — endpoint calls), 'serverless' (fal Serverless SDK billing), or 'compute' (fal Compute — raw instances).
        /// </summary>
        ModelApis,
        /// <summary>
        /// 'model_apis' (fal Model APIs — endpoint calls), 'serverless' (fal Serverless SDK billing), or 'compute' (fal Compute — raw instances).
        /// </summary>
        Serverless,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationUsageResponseSummaryItemProductExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationUsageResponseSummaryItemProduct value)
        {
            return value switch
            {
                GetOrganizationUsageResponseSummaryItemProduct.Compute => "compute",
                GetOrganizationUsageResponseSummaryItemProduct.ModelApis => "model_apis",
                GetOrganizationUsageResponseSummaryItemProduct.Serverless => "serverless",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationUsageResponseSummaryItemProduct? ToEnum(string value)
        {
            return value switch
            {
                "compute" => GetOrganizationUsageResponseSummaryItemProduct.Compute,
                "model_apis" => GetOrganizationUsageResponseSummaryItemProduct.ModelApis,
                "serverless" => GetOrganizationUsageResponseSummaryItemProduct.Serverless,
                _ => null,
            };
        }
    }
}
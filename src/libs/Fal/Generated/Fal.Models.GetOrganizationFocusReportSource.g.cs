
#nullable enable

namespace Fal
{
    /// <summary>
    /// Report source. 'invoice' returns finalized invoice data for a billing month. 'estimate' returns real-time usage estimates for a date range.<br/>
    /// Example: estimate
    /// </summary>
    public enum GetOrganizationFocusReportSource
    {
        /// <summary>
        /// 
        /// </summary>
        Estimate,
        /// <summary>
        /// 
        /// </summary>
        Invoice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationFocusReportSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationFocusReportSource value)
        {
            return value switch
            {
                GetOrganizationFocusReportSource.Estimate => "estimate",
                GetOrganizationFocusReportSource.Invoice => "invoice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationFocusReportSource? ToEnum(string value)
        {
            return value switch
            {
                "estimate" => GetOrganizationFocusReportSource.Estimate,
                "invoice" => GetOrganizationFocusReportSource.Invoice,
                _ => null,
            };
        }
    }
}
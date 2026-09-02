
#nullable enable

namespace Fal
{
    /// <summary>
    /// Report source. 'invoice' returns finalized invoice data for a billing month. 'estimate' returns real-time usage estimates for a date range. 'tagged-estimate' returns the same date range from the tagged usage aggregate, populating the Tags column; it requires tagged reporting to be enabled for the organization and at least one activated tag key, and its figures can differ from 'estimate' — the aggregate deduplicates by request, covers endpoint requests only, and refreshes on its own schedule rather than continuously.<br/>
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
        /// <summary>
        ///
        /// </summary>
        TaggedEstimate,
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
                GetOrganizationFocusReportSource.TaggedEstimate => "tagged-estimate",
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
                "tagged-estimate" => GetOrganizationFocusReportSource.TaggedEstimate,
                _ => null,
            };
        }
    }
}
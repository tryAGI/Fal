
#nullable enable

namespace Fal
{
    /// <summary>
    /// Report source. 'invoice' returns finalized invoice data for a billing month. 'estimate' returns real-time usage estimates for a date range. 'tagged-estimate' returns those same estimates with the Tags column populated from the X-Fal-Tags tags set on your requests; it requires tagged reporting to be enabled for the account, and recent usage is delayed relative to 'estimate'.<br/>
    /// Example: invoice
    /// </summary>
    public enum GetFocusReportSource
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
    public static class GetFocusReportSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFocusReportSource value)
        {
            return value switch
            {
                GetFocusReportSource.Estimate => "estimate",
                GetFocusReportSource.Invoice => "invoice",
                GetFocusReportSource.TaggedEstimate => "tagged-estimate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFocusReportSource? ToEnum(string value)
        {
            return value switch
            {
                "estimate" => GetFocusReportSource.Estimate,
                "invoice" => GetFocusReportSource.Invoice,
                "tagged-estimate" => GetFocusReportSource.TaggedEstimate,
                _ => null,
            };
        }
    }
}
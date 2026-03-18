
#nullable enable

namespace Fal
{
    /// <summary>
    /// Report source. 'invoice' returns finalized invoice data for a billing month. 'estimate' returns real-time usage estimates for a date range.<br/>
    /// Example: invoice
    /// </summary>
    public enum GetFocusReportSource
    {
        /// <summary>
        /// 
        /// </summary>
        Invoice,
        /// <summary>
        /// 
        /// </summary>
        Estimate,
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
                GetFocusReportSource.Invoice => "invoice",
                GetFocusReportSource.Estimate => "estimate",
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
                "invoice" => GetFocusReportSource.Invoice,
                "estimate" => GetFocusReportSource.Estimate,
                _ => null,
            };
        }
    }
}
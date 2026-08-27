
#nullable enable

namespace Fal
{
    /// <summary>
    /// Expand the report to the whole organization. Only valid for an organization root; each team is reported as a BillingAccount and, under shared (pooled) billing, per-team SubAccount attribution is added. Omit for a single-account report.<br/>
    /// Example: organization
    /// </summary>
    public enum GetFocusReportExpand
    {
        /// <summary>
        ///
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFocusReportExpandExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFocusReportExpand value)
        {
            return value switch
            {
                GetFocusReportExpand.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFocusReportExpand? ToEnum(string value)
        {
            return value switch
            {
                "organization" => GetFocusReportExpand.Organization,
                _ => null,
            };
        }
    }
}
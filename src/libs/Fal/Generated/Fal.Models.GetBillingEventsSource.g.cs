
#nullable enable

namespace Fal
{
    /// <summary>
    /// Data source. 'billed' is the default billed-event feed. 'tagged-billed' reads the tagged billing-event pivot instead, populating each row's 'tags' and enabling the 'tag' filter; it requires tagged reporting to be enabled for the account, and recent events are delayed relative to 'billed'.<br/>
    /// Default Value: billed<br/>
    /// Example: billed
    /// </summary>
    public enum GetBillingEventsSource
    {
        /// <summary>
        ///
        /// </summary>
        Billed,
        /// <summary>
        ///
        /// </summary>
        TaggedBilled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBillingEventsSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBillingEventsSource value)
        {
            return value switch
            {
                GetBillingEventsSource.Billed => "billed",
                GetBillingEventsSource.TaggedBilled => "tagged-billed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBillingEventsSource? ToEnum(string value)
        {
            return value switch
            {
                "billed" => GetBillingEventsSource.Billed,
                "tagged-billed" => GetBillingEventsSource.TaggedBilled,
                _ => null,
            };
        }
    }
}
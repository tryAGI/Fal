
#nullable enable

namespace Fal
{
    /// <summary>
    /// Preset the key was created from, present when mode is preset<br/>
    /// Example: API
    /// </summary>
    public enum ListApiKeysResponseKeyPreset
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Api,
        /// <summary>
        ///
        /// </summary>
        Billing,
        /// <summary>
        ///
        /// </summary>
        Compute,
        /// <summary>
        ///
        /// </summary>
        Deploy,
        /// <summary>
        ///
        /// </summary>
        Full,
        /// <summary>
        ///
        /// </summary>
        Readonly,
        /// <summary>
        ///
        /// </summary>
        Serverless,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListApiKeysResponseKeyPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListApiKeysResponseKeyPreset value)
        {
            return value switch
            {
                ListApiKeysResponseKeyPreset.Agent => "AGENT",
                ListApiKeysResponseKeyPreset.Api => "API",
                ListApiKeysResponseKeyPreset.Billing => "BILLING",
                ListApiKeysResponseKeyPreset.Compute => "COMPUTE",
                ListApiKeysResponseKeyPreset.Deploy => "DEPLOY",
                ListApiKeysResponseKeyPreset.Full => "FULL",
                ListApiKeysResponseKeyPreset.Readonly => "READONLY",
                ListApiKeysResponseKeyPreset.Serverless => "SERVERLESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListApiKeysResponseKeyPreset? ToEnum(string value)
        {
            return value switch
            {
                "AGENT" => ListApiKeysResponseKeyPreset.Agent,
                "API" => ListApiKeysResponseKeyPreset.Api,
                "BILLING" => ListApiKeysResponseKeyPreset.Billing,
                "COMPUTE" => ListApiKeysResponseKeyPreset.Compute,
                "DEPLOY" => ListApiKeysResponseKeyPreset.Deploy,
                "FULL" => ListApiKeysResponseKeyPreset.Full,
                "READONLY" => ListApiKeysResponseKeyPreset.Readonly,
                "SERVERLESS" => ListApiKeysResponseKeyPreset.Serverless,
                _ => null,
            };
        }
    }
}
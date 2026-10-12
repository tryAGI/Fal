
#nullable enable

namespace Fal
{
    /// <summary>
    /// Named permission preset to apply. Defaults to "API" when neither preset nor permissions is given. Mutually exclusive with permissions.<br/>
    /// Example: API
    /// </summary>
    public enum CreateApiKeyRequestPreset
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
    public static class CreateApiKeyRequestPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiKeyRequestPreset value)
        {
            return value switch
            {
                CreateApiKeyRequestPreset.Agent => "AGENT",
                CreateApiKeyRequestPreset.Api => "API",
                CreateApiKeyRequestPreset.Billing => "BILLING",
                CreateApiKeyRequestPreset.Compute => "COMPUTE",
                CreateApiKeyRequestPreset.Deploy => "DEPLOY",
                CreateApiKeyRequestPreset.Full => "FULL",
                CreateApiKeyRequestPreset.Readonly => "READONLY",
                CreateApiKeyRequestPreset.Serverless => "SERVERLESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiKeyRequestPreset? ToEnum(string value)
        {
            return value switch
            {
                "AGENT" => CreateApiKeyRequestPreset.Agent,
                "API" => CreateApiKeyRequestPreset.Api,
                "BILLING" => CreateApiKeyRequestPreset.Billing,
                "COMPUTE" => CreateApiKeyRequestPreset.Compute,
                "DEPLOY" => CreateApiKeyRequestPreset.Deploy,
                "FULL" => CreateApiKeyRequestPreset.Full,
                "READONLY" => CreateApiKeyRequestPreset.Readonly,
                "SERVERLESS" => CreateApiKeyRequestPreset.Serverless,
                _ => null,
            };
        }
    }
}
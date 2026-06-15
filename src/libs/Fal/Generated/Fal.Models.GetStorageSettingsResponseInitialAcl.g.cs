
#nullable enable

namespace Fal
{
    /// <summary>
    /// Default ACL applied to newly uploaded files, or null if the system default (public) is used
    /// </summary>
    public sealed partial class GetStorageSettingsResponseInitialAcl
    {
        /// <summary>
        /// Fallback decision when no user-specific rule matches<br/>
        /// Example: allow
        /// </summary>
        /// <example>allow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.GetStorageSettingsResponseInitialAclDefaultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.GetStorageSettingsResponseInitialAclDefault Default { get; set; }

        /// <summary>
        /// User-specific overrides to the default decision. Users are returned as nicknames where possible.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.GetStorageSettingsResponseInitialAclRule> Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStorageSettingsResponseInitialAcl" /> class.
        /// </summary>
        /// <param name="default">
        /// Fallback decision when no user-specific rule matches<br/>
        /// Example: allow
        /// </param>
        /// <param name="rules">
        /// User-specific overrides to the default decision. Users are returned as nicknames where possible.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetStorageSettingsResponseInitialAcl(
            global::Fal.GetStorageSettingsResponseInitialAclDefault @default,
            global::System.Collections.Generic.IList<global::Fal.GetStorageSettingsResponseInitialAclRule> rules)
        {
            this.Default = @default;
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStorageSettingsResponseInitialAcl" /> class.
        /// </summary>
        public GetStorageSettingsResponseInitialAcl()
        {
        }

    }
}
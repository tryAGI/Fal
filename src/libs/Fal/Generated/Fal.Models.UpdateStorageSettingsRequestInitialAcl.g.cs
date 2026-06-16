
#nullable enable

namespace Fal
{
    /// <summary>
    /// Default ACL applied to newly uploaded files. Null uses the system default (public).
    /// </summary>
    public sealed partial class UpdateStorageSettingsRequestInitialAcl
    {
        /// <summary>
        /// Fallback decision when no user-specific rule matches<br/>
        /// Example: allow
        /// </summary>
        /// <example>allow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.UpdateStorageSettingsRequestInitialAclDefaultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.UpdateStorageSettingsRequestInitialAclDefault Default { get; set; }

        /// <summary>
        /// User-specific overrides to the default decision<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::Fal.UpdateStorageSettingsRequestInitialAclRule>? Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStorageSettingsRequestInitialAcl" /> class.
        /// </summary>
        /// <param name="default">
        /// Fallback decision when no user-specific rule matches<br/>
        /// Example: allow
        /// </param>
        /// <param name="rules">
        /// User-specific overrides to the default decision<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateStorageSettingsRequestInitialAcl(
            global::Fal.UpdateStorageSettingsRequestInitialAclDefault @default,
            global::System.Collections.Generic.IList<global::Fal.UpdateStorageSettingsRequestInitialAclRule>? rules)
        {
            this.Default = @default;
            this.Rules = rules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStorageSettingsRequestInitialAcl" /> class.
        /// </summary>
        public UpdateStorageSettingsRequestInitialAcl()
        {
        }

    }
}
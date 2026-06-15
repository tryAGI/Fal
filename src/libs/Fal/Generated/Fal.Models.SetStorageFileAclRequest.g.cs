
#nullable enable

namespace Fal
{
    /// <summary>
    /// Access Control List for a fal CDN file
    /// </summary>
    public sealed partial class SetStorageFileAclRequest
    {
        /// <summary>
        /// Fallback decision when no user-specific rule matches<br/>
        /// Example: allow
        /// </summary>
        /// <example>allow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.SetStorageFileAclRequestDefaultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.SetStorageFileAclRequestDefault Default { get; set; }

        /// <summary>
        /// User-specific overrides to the default decision<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::Fal.SetStorageFileAclRequestRule>? Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetStorageFileAclRequest" /> class.
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
        public SetStorageFileAclRequest(
            global::Fal.SetStorageFileAclRequestDefault @default,
            global::System.Collections.Generic.IList<global::Fal.SetStorageFileAclRequestRule>? rules)
        {
            this.Default = @default;
            this.Rules = rules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetStorageFileAclRequest" /> class.
        /// </summary>
        public SetStorageFileAclRequest()
        {
        }

    }
}
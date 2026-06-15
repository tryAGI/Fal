
#nullable enable

namespace Fal
{
    /// <summary>
    /// Access Control List currently applied to the file
    /// </summary>
    public sealed partial class GetStorageFileAclResponse
    {
        /// <summary>
        /// Fallback decision when no user-specific rule matches<br/>
        /// Example: allow
        /// </summary>
        /// <example>allow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.GetStorageFileAclResponseDefaultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.GetStorageFileAclResponseDefault Default { get; set; }

        /// <summary>
        /// User-specific overrides to the default decision. Users are returned as nicknames where possible.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.GetStorageFileAclResponseRule> Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStorageFileAclResponse" /> class.
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
        public GetStorageFileAclResponse(
            global::Fal.GetStorageFileAclResponseDefault @default,
            global::System.Collections.Generic.IList<global::Fal.GetStorageFileAclResponseRule> rules)
        {
            this.Default = @default;
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStorageFileAclResponse" /> class.
        /// </summary>
        public GetStorageFileAclResponse()
        {
        }

    }
}
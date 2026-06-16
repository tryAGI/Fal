
#nullable enable

namespace Fal
{
    /// <summary>
    /// A per-user access control rule
    /// </summary>
    public sealed partial class GetStorageSettingsResponseInitialAclRule
    {
        /// <summary>
        /// User nickname or user ID the rule applies to<br/>
        /// Example: some-user
        /// </summary>
        /// <example>some-user</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// Access decision applied to this user<br/>
        /// Example: allow
        /// </summary>
        /// <example>allow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("decision")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.GetStorageSettingsResponseInitialAclRuleDecisionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.GetStorageSettingsResponseInitialAclRuleDecision Decision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStorageSettingsResponseInitialAclRule" /> class.
        /// </summary>
        /// <param name="user">
        /// User nickname or user ID the rule applies to<br/>
        /// Example: some-user
        /// </param>
        /// <param name="decision">
        /// Access decision applied to this user<br/>
        /// Example: allow
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetStorageSettingsResponseInitialAclRule(
            string user,
            global::Fal.GetStorageSettingsResponseInitialAclRuleDecision decision)
        {
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Decision = decision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStorageSettingsResponseInitialAclRule" /> class.
        /// </summary>
        public GetStorageSettingsResponseInitialAclRule()
        {
        }

    }
}
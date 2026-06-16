
#nullable enable

namespace Fal
{
    /// <summary>
    /// Organization team details
    /// </summary>
    public sealed partial class GetOrganizationTeamsResponseTeam
    {
        /// <summary>
        /// Team username/identifier (unique within the organization)<br/>
        /// Example: acme-corp
        /// </summary>
        /// <example>acme-corp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Human-readable display name of the team<br/>
        /// Example: Acme Corporation
        /// </summary>
        /// <example>Acme Corporation</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// True if this is the root organization team; false for sub-teams<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_org_root")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOrgRoot { get; set; }

        /// <summary>
        /// Team creation timestamp in ISO8601 format<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationTeamsResponseTeam" /> class.
        /// </summary>
        /// <param name="username">
        /// Team username/identifier (unique within the organization)<br/>
        /// Example: acme-corp
        /// </param>
        /// <param name="name">
        /// Human-readable display name of the team<br/>
        /// Example: Acme Corporation
        /// </param>
        /// <param name="isOrgRoot">
        /// True if this is the root organization team; false for sub-teams<br/>
        /// Example: true
        /// </param>
        /// <param name="createdAt">
        /// Team creation timestamp in ISO8601 format<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationTeamsResponseTeam(
            string username,
            string name,
            bool isOrgRoot,
            string createdAt)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsOrgRoot = isOrgRoot;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationTeamsResponseTeam" /> class.
        /// </summary>
        public GetOrganizationTeamsResponseTeam()
        {
        }

    }
}
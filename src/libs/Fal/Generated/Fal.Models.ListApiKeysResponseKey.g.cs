
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Fal
{
    /// <summary>
    /// API key information
    /// </summary>
    public sealed partial class ListApiKeysResponseKey
    {
        /// <summary>
        /// Unique identifier for the API key<br/>
        /// Example: abc123def456
        /// </summary>
        /// <example>abc123def456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyId { get; set; }

        /// <summary>
        /// User-provided friendly name for the key<br/>
        /// Example: Production Key
        /// </summary>
        /// <example>Production Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// Coarse scope of a legacy API key. Deprecated: superseded by mode, preset and permissions, and omitted for keys that carry granular permissions.<br/>
        /// Example: API
        /// </summary>
        /// <example>API</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.ListApiKeysResponseKeyScopeJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Fal.ListApiKeysResponseKeyScope? Scope { get; set; }

        /// <summary>
        /// ISO8601 timestamp when the key was created<br/>
        /// Example: 2025-01-15T12:00:00Z
        /// </summary>
        /// <example>2025-01-15T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// User-provided description of what the key is for<br/>
        /// Example: CI deploy key for the main environment
        /// </summary>
        /// <example>CI deploy key for the main environment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// How the key's permissions are expressed: a named preset, a custom permission list, or a legacy scope.<br/>
        /// Example: preset
        /// </summary>
        /// <example>preset</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.ListApiKeysResponseKeyModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.ListApiKeysResponseKeyMode Mode { get; set; }

        /// <summary>
        /// Preset the key was created from, present when mode is preset<br/>
        /// Example: API
        /// </summary>
        /// <example>API</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.ListApiKeysResponseKeyPresetJsonConverter))]
        public global::Fal.ListApiKeysResponseKeyPreset? Preset { get; set; }

        /// <summary>
        /// Resolved permissions, present for preset and custom keys<br/>
        /// Example: [models:requests:read, models:requests:write]
        /// </summary>
        /// <example>[models:requests:read, models:requests:write]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<string>? Permissions { get; set; }

        /// <summary>
        /// ISO8601 timestamp when the key expires, or null if it doesn't<br/>
        /// Example: 2025-07-15T12:00:00Z
        /// </summary>
        /// <example>2025-07-15T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// Nickname of the user who created this key (when expanded)<br/>
        /// Example: developer
        /// </summary>
        /// <example>developer</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_nickname")]
        public string? CreatorNickname { get; set; }

        /// <summary>
        /// Email of the user who created this key (when expanded)<br/>
        /// Example: developer@example.com
        /// </summary>
        /// <example>developer@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_email")]
        public string? CreatorEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListApiKeysResponseKey" /> class.
        /// </summary>
        /// <param name="keyId">
        /// Unique identifier for the API key<br/>
        /// Example: abc123def456
        /// </param>
        /// <param name="alias">
        /// User-provided friendly name for the key<br/>
        /// Example: Production Key
        /// </param>
        /// <param name="createdAt">
        /// ISO8601 timestamp when the key was created<br/>
        /// Example: 2025-01-15T12:00:00Z
        /// </param>
        /// <param name="mode">
        /// How the key's permissions are expressed: a named preset, a custom permission list, or a legacy scope.<br/>
        /// Example: preset
        /// </param>
        /// <param name="description">
        /// User-provided description of what the key is for<br/>
        /// Example: CI deploy key for the main environment
        /// </param>
        /// <param name="preset">
        /// Preset the key was created from, present when mode is preset<br/>
        /// Example: API
        /// </param>
        /// <param name="permissions">
        /// Resolved permissions, present for preset and custom keys<br/>
        /// Example: [models:requests:read, models:requests:write]
        /// </param>
        /// <param name="expiresAt">
        /// ISO8601 timestamp when the key expires, or null if it doesn't<br/>
        /// Example: 2025-07-15T12:00:00Z
        /// </param>
        /// <param name="creatorNickname">
        /// Nickname of the user who created this key (when expanded)<br/>
        /// Example: developer
        /// </param>
        /// <param name="creatorEmail">
        /// Email of the user who created this key (when expanded)<br/>
        /// Example: developer@example.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListApiKeysResponseKey(
            string keyId,
            string alias,
            string createdAt,
            global::Fal.ListApiKeysResponseKeyMode mode,
            string? description,
            global::Fal.ListApiKeysResponseKeyPreset? preset,
            global::System.Collections.Generic.IList<string>? permissions,
            string? expiresAt,
            string? creatorNickname,
            string? creatorEmail)
        {
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Description = description;
            this.Mode = mode;
            this.Preset = preset;
            this.Permissions = permissions;
            this.ExpiresAt = expiresAt;
            this.CreatorNickname = creatorNickname;
            this.CreatorEmail = creatorEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListApiKeysResponseKey" /> class.
        /// </summary>
        public ListApiKeysResponseKey()
        {
        }

    }
}
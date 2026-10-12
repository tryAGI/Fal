
#nullable enable

namespace Fal
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateApiKeyRequest
    {
        /// <summary>
        /// Required friendly name for the API key<br/>
        /// Example: Production Key
        /// </summary>
        /// <example>Production Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// Optional description of what the key is for<br/>
        /// Example: CI deploy key for the main environment
        /// </summary>
        /// <example>CI deploy key for the main environment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Named permission preset to apply. Defaults to "API" when neither preset nor permissions is given. Mutually exclusive with permissions.<br/>
        /// Example: API
        /// </summary>
        /// <example>API</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.CreateApiKeyRequestPresetJsonConverter))]
        public global::Fal.CreateApiKeyRequestPreset? Preset { get; set; }

        /// <summary>
        /// Explicit list of permissions to grant instead of a preset. Mutually exclusive with preset.<br/>
        /// Example: [models:requests:read, models:requests:write]
        /// </summary>
        /// <example>[models:requests:read, models:requests:write]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<string>? Permissions { get; set; }

        /// <summary>
        /// ISO8601 timestamp after which the key stops working<br/>
        /// Example: 2025-07-15T12:00:00Z
        /// </summary>
        /// <example>2025-07-15T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequest" /> class.
        /// </summary>
        /// <param name="alias">
        /// Required friendly name for the API key<br/>
        /// Example: Production Key
        /// </param>
        /// <param name="description">
        /// Optional description of what the key is for<br/>
        /// Example: CI deploy key for the main environment
        /// </param>
        /// <param name="preset">
        /// Named permission preset to apply. Defaults to "API" when neither preset nor permissions is given. Mutually exclusive with permissions.<br/>
        /// Example: API
        /// </param>
        /// <param name="permissions">
        /// Explicit list of permissions to grant instead of a preset. Mutually exclusive with preset.<br/>
        /// Example: [models:requests:read, models:requests:write]
        /// </param>
        /// <param name="expiresAt">
        /// ISO8601 timestamp after which the key stops working<br/>
        /// Example: 2025-07-15T12:00:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeyRequest(
            string alias,
            string? description,
            global::Fal.CreateApiKeyRequestPreset? preset,
            global::System.Collections.Generic.IList<string>? permissions,
            global::System.DateTime? expiresAt)
        {
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Description = description;
            this.Preset = preset;
            this.Permissions = permissions;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequest" /> class.
        /// </summary>
        public CreateApiKeyRequest()
        {
        }

    }
}
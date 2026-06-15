
#nullable enable

namespace Fal
{
    /// <summary>
    /// Account-level storage lifecycle settings
    /// </summary>
    public sealed partial class UpdateStorageSettingsResponse
    {
        /// <summary>
        /// Seconds after which newly uploaded files automatically expire, or null if auto-expiration is disabled<br/>
        /// Example: 86400
        /// </summary>
        /// <example>86400</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_duration_seconds")]
        public int? ExpirationDurationSeconds { get; set; }

        /// <summary>
        /// Default ACL applied to newly uploaded files, or null if the system default (public) is used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initial_acl")]
        public global::Fal.UpdateStorageSettingsResponseInitialAcl? InitialAcl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStorageSettingsResponse" /> class.
        /// </summary>
        /// <param name="expirationDurationSeconds">
        /// Seconds after which newly uploaded files automatically expire, or null if auto-expiration is disabled<br/>
        /// Example: 86400
        /// </param>
        /// <param name="initialAcl">
        /// Default ACL applied to newly uploaded files, or null if the system default (public) is used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateStorageSettingsResponse(
            int? expirationDurationSeconds,
            global::Fal.UpdateStorageSettingsResponseInitialAcl? initialAcl)
        {
            this.ExpirationDurationSeconds = expirationDurationSeconds;
            this.InitialAcl = initialAcl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStorageSettingsResponse" /> class.
        /// </summary>
        public UpdateStorageSettingsResponse()
        {
        }

    }
}
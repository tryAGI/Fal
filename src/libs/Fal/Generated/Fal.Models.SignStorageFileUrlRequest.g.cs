
#nullable enable

namespace Fal
{
    /// <summary>
    /// Signing options for the file URL
    /// </summary>
    public sealed partial class SignStorageFileUrlRequest
    {
        /// <summary>
        /// How long the signed URL stays valid, in seconds (max 7 days)<br/>
        /// Example: 3600
        /// </summary>
        /// <example>3600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpirationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignStorageFileUrlRequest" /> class.
        /// </summary>
        /// <param name="expirationSeconds">
        /// How long the signed URL stays valid, in seconds (max 7 days)<br/>
        /// Example: 3600
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignStorageFileUrlRequest(
            int expirationSeconds)
        {
            this.ExpirationSeconds = expirationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignStorageFileUrlRequest" /> class.
        /// </summary>
        public SignStorageFileUrlRequest()
        {
        }

    }
}
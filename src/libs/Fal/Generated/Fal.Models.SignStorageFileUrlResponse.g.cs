
#nullable enable

namespace Fal
{
    /// <summary>
    /// Signed URL response
    /// </summary>
    public sealed partial class SignStorageFileUrlResponse
    {
        /// <summary>
        /// URL with an embedded signature granting temporary access<br/>
        /// Example: https://v3.fal.media/files/b/0a1b2c3d/output.png?identity=...
        /// </summary>
        /// <example>https://v3.fal.media/files/b/0a1b2c3d/output.png?identity=...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SignedUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignStorageFileUrlResponse" /> class.
        /// </summary>
        /// <param name="signedUrl">
        /// URL with an embedded signature granting temporary access<br/>
        /// Example: https://v3.fal.media/files/b/0a1b2c3d/output.png?identity=...
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignStorageFileUrlResponse(
            string signedUrl)
        {
            this.SignedUrl = signedUrl ?? throw new global::System.ArgumentNullException(nameof(signedUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignStorageFileUrlResponse" /> class.
        /// </summary>
        public SignStorageFileUrlResponse()
        {
        }

    }
}
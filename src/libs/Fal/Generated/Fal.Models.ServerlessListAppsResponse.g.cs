
#nullable enable

namespace Fal
{
    /// <summary>
    /// The caller's serverless applications
    /// </summary>
    public sealed partial class ServerlessListAppsResponse
    {
        /// <summary>
        /// Serverless applications owned by the authenticated account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.ServerlessListAppsResponseApp> Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListAppsResponse" /> class.
        /// </summary>
        /// <param name="apps">
        /// Serverless applications owned by the authenticated account
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerlessListAppsResponse(
            global::System.Collections.Generic.IList<global::Fal.ServerlessListAppsResponseApp> apps)
        {
            this.Apps = apps ?? throw new global::System.ArgumentNullException(nameof(apps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListAppsResponse" /> class.
        /// </summary>
        public ServerlessListAppsResponse()
        {
        }

    }
}
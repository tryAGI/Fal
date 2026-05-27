
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAssetCollectionsResponse
    {
        /// <summary>
        /// Asset collections visible to the authenticated user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.ListAssetCollectionsResponseCollection> Collections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAssetCollectionsResponse" /> class.
        /// </summary>
        /// <param name="collections">
        /// Asset collections visible to the authenticated user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAssetCollectionsResponse(
            global::System.Collections.Generic.IList<global::Fal.ListAssetCollectionsResponseCollection> collections)
        {
            this.Collections = collections ?? throw new global::System.ArgumentNullException(nameof(collections));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAssetCollectionsResponse" /> class.
        /// </summary>
        public ListAssetCollectionsResponse()
        {
        }

    }
}
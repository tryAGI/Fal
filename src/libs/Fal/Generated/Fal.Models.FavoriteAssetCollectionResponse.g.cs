
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FavoriteAssetCollectionResponse
    {
        /// <summary>
        /// Asset collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.FavoriteAssetCollectionResponseCollection Collection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteAssetCollectionResponse" /> class.
        /// </summary>
        /// <param name="collection">
        /// Asset collection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FavoriteAssetCollectionResponse(
            global::Fal.FavoriteAssetCollectionResponseCollection collection)
        {
            this.Collection = collection ?? throw new global::System.ArgumentNullException(nameof(collection));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FavoriteAssetCollectionResponse" /> class.
        /// </summary>
        public FavoriteAssetCollectionResponse()
        {
        }

    }
}
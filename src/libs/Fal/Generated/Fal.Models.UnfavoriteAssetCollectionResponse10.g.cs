
#nullable enable

namespace Fal
{
    /// <summary>
    /// Standard error response format
    /// </summary>
    public sealed partial class UnfavoriteAssetCollectionResponse10
    {
        /// <summary>
        /// Error details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.UnfavoriteAssetCollectionResponseError9 Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnfavoriteAssetCollectionResponse10" /> class.
        /// </summary>
        /// <param name="error">
        /// Error details
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnfavoriteAssetCollectionResponse10(
            global::Fal.UnfavoriteAssetCollectionResponseError9 error)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnfavoriteAssetCollectionResponse10" /> class.
        /// </summary>
        public UnfavoriteAssetCollectionResponse10()
        {
        }

    }
}
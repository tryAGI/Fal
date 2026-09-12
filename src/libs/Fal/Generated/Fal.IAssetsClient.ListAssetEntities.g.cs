#nullable enable

namespace Fal
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// List asset entities<br/>
        /// List saved characters, props, environments, styles, and scenes in the authenticated account. Returns their @mention handles and defining reference images. Uses limit and offset pagination; omit types to include every entity type.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of entities to return<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="offset">
        /// Number of entities to skip<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="types">
        /// Entity types to include, comma-separated. Omit to list all types.<br/>
        /// Example: [prop, environment]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.ListAssetEntitiesResponse> ListAssetEntitiesAsync(
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<global::Fal.ListAssetEntitiesType>? types = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List asset entities<br/>
        /// List saved characters, props, environments, styles, and scenes in the authenticated account. Returns their @mention handles and defining reference images. Uses limit and offset pagination; omit types to include every entity type.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of entities to return<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="offset">
        /// Number of entities to skip<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="types">
        /// Entity types to include, comma-separated. Omit to list all types.<br/>
        /// Example: [prop, environment]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.ListAssetEntitiesResponse>> ListAssetEntitiesAsResponseAsync(
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<global::Fal.ListAssetEntitiesType>? types = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
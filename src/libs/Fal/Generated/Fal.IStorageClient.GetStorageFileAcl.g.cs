#nullable enable

namespace Fal
{
    public partial interface IStorageClient
    {
        /// <summary>
        /// Get file ACL<br/>
        /// Returns the Access Control List currently applied to a fal CDN file.<br/>
        /// The ACL consists of a default decision (`allow`, `forbid`, or `hide`) plus<br/>
        /// optional per-user rules that override the default. Rule users are returned as<br/>
        /// nicknames where possible.<br/>
        /// **Authentication:** Required. The API key must have the `assets:read` permission.<br/>
        ///     
        /// </summary>
        /// <param name="url">
        /// Full URL of the fal CDN file, as returned by the upload APIs (https://v3.fal.media/files/b/&lt;id&gt;/&lt;filename&gt;). Must not contain query parameters.<br/>
        /// Example: https://v3.fal.media/files/b/0a1b2c3d/output.png
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.GetStorageFileAclResponse> GetStorageFileAclAsync(
            string url,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get file ACL<br/>
        /// Returns the Access Control List currently applied to a fal CDN file.<br/>
        /// The ACL consists of a default decision (`allow`, `forbid`, or `hide`) plus<br/>
        /// optional per-user rules that override the default. Rule users are returned as<br/>
        /// nicknames where possible.<br/>
        /// **Authentication:** Required. The API key must have the `assets:read` permission.<br/>
        ///     
        /// </summary>
        /// <param name="url">
        /// Full URL of the fal CDN file, as returned by the upload APIs (https://v3.fal.media/files/b/&lt;id&gt;/&lt;filename&gt;). Must not contain query parameters.<br/>
        /// Example: https://v3.fal.media/files/b/0a1b2c3d/output.png
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.GetStorageFileAclResponse>> GetStorageFileAclAsResponseAsync(
            string url,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
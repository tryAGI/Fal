#nullable enable

namespace Fal
{
    public partial interface IStorageClient
    {
        /// <summary>
        /// Set file ACL<br/>
        /// Replaces the Access Control List of a fal CDN file.<br/>
        /// The ACL consists of a default decision (`allow`, `forbid`, or `hide`) plus<br/>
        /// optional per-user rules that override the default. Rule users may be specified<br/>
        /// by nickname or user ID. Setting `default` to `allow` with no rules makes the<br/>
        /// file public; `forbid` or `hide` restricts it to the rules you provide.<br/>
        /// Rules referencing users that do not exist are dropped. The response reflects<br/>
        /// the ACL actually applied, so verify it contains the rules you sent.<br/>
        /// **Authentication:** Required. The API key must have the `assets:write` permission.<br/>
        ///     
        /// </summary>
        /// <param name="url">
        /// Full URL of the fal CDN file, as returned by the upload APIs (https://v3.fal.media/files/b/&lt;id&gt;/&lt;filename&gt;). Must not contain query parameters.<br/>
        /// Example: https://v3.fal.media/files/b/0a1b2c3d/output.png
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.SetStorageFileAclResponse> SetStorageFileAclAsync(
            string url,

            global::Fal.SetStorageFileAclRequest request,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set file ACL<br/>
        /// Replaces the Access Control List of a fal CDN file.<br/>
        /// The ACL consists of a default decision (`allow`, `forbid`, or `hide`) plus<br/>
        /// optional per-user rules that override the default. Rule users may be specified<br/>
        /// by nickname or user ID. Setting `default` to `allow` with no rules makes the<br/>
        /// file public; `forbid` or `hide` restricts it to the rules you provide.<br/>
        /// Rules referencing users that do not exist are dropped. The response reflects<br/>
        /// the ACL actually applied, so verify it contains the rules you sent.<br/>
        /// **Authentication:** Required. The API key must have the `assets:write` permission.<br/>
        ///     
        /// </summary>
        /// <param name="url">
        /// Full URL of the fal CDN file, as returned by the upload APIs (https://v3.fal.media/files/b/&lt;id&gt;/&lt;filename&gt;). Must not contain query parameters.<br/>
        /// Example: https://v3.fal.media/files/b/0a1b2c3d/output.png
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.SetStorageFileAclResponse>> SetStorageFileAclAsResponseAsync(
            string url,

            global::Fal.SetStorageFileAclRequest request,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set file ACL<br/>
        /// Replaces the Access Control List of a fal CDN file.<br/>
        /// The ACL consists of a default decision (`allow`, `forbid`, or `hide`) plus<br/>
        /// optional per-user rules that override the default. Rule users may be specified<br/>
        /// by nickname or user ID. Setting `default` to `allow` with no rules makes the<br/>
        /// file public; `forbid` or `hide` restricts it to the rules you provide.<br/>
        /// Rules referencing users that do not exist are dropped. The response reflects<br/>
        /// the ACL actually applied, so verify it contains the rules you sent.<br/>
        /// **Authentication:** Required. The API key must have the `assets:write` permission.<br/>
        ///     
        /// </summary>
        /// <param name="url">
        /// Full URL of the fal CDN file, as returned by the upload APIs (https://v3.fal.media/files/b/&lt;id&gt;/&lt;filename&gt;). Must not contain query parameters.<br/>
        /// Example: https://v3.fal.media/files/b/0a1b2c3d/output.png
        /// </param>
        /// <param name="default">
        /// Fallback decision when no user-specific rule matches<br/>
        /// Example: allow
        /// </param>
        /// <param name="rules">
        /// User-specific overrides to the default decision<br/>
        /// Default Value: []
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.SetStorageFileAclResponse> SetStorageFileAclAsync(
            string url,
            global::Fal.SetStorageFileAclRequestDefault @default,
            global::System.Collections.Generic.IList<global::Fal.SetStorageFileAclRequestRule>? rules = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
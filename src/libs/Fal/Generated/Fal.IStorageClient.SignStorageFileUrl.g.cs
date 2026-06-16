#nullable enable

namespace Fal
{
    public partial interface IStorageClient
    {
        /// <summary>
        /// Sign file URL<br/>
        /// Creates a signed URL that grants temporary access to a fal CDN file,<br/>
        /// regardless of its ACL. Useful for sharing access-restricted files.<br/>
        /// The signature is valid for `expiration_seconds` (up to 7 days).<br/>
        /// **Authentication:** Required. The API key must have the `assets:read` permission.<br/>
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
        global::System.Threading.Tasks.Task<global::Fal.SignStorageFileUrlResponse> SignStorageFileUrlAsync(
            string url,

            global::Fal.SignStorageFileUrlRequest request,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sign file URL<br/>
        /// Creates a signed URL that grants temporary access to a fal CDN file,<br/>
        /// regardless of its ACL. Useful for sharing access-restricted files.<br/>
        /// The signature is valid for `expiration_seconds` (up to 7 days).<br/>
        /// **Authentication:** Required. The API key must have the `assets:read` permission.<br/>
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
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.SignStorageFileUrlResponse>> SignStorageFileUrlAsResponseAsync(
            string url,

            global::Fal.SignStorageFileUrlRequest request,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sign file URL<br/>
        /// Creates a signed URL that grants temporary access to a fal CDN file,<br/>
        /// regardless of its ACL. Useful for sharing access-restricted files.<br/>
        /// The signature is valid for `expiration_seconds` (up to 7 days).<br/>
        /// **Authentication:** Required. The API key must have the `assets:read` permission.<br/>
        ///     
        /// </summary>
        /// <param name="url">
        /// Full URL of the fal CDN file, as returned by the upload APIs (https://v3.fal.media/files/b/&lt;id&gt;/&lt;filename&gt;). Must not contain query parameters.<br/>
        /// Example: https://v3.fal.media/files/b/0a1b2c3d/output.png
        /// </param>
        /// <param name="expirationSeconds">
        /// How long the signed URL stays valid, in seconds (max 7 days)<br/>
        /// Example: 3600
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.SignStorageFileUrlResponse> SignStorageFileUrlAsync(
            string url,
            int expirationSeconds,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Fal
{
    public partial interface IStorageClient
    {
        /// <summary>
        /// Get storage settings<br/>
        /// Returns the account-level storage lifecycle settings applied to newly uploaded<br/>
        /// fal CDN files:<br/>
        /// - `expiration_duration_seconds`: how long files live before being<br/>
        ///   automatically deleted (null disables auto-expiration).<br/>
        /// - `initial_acl`: the default ACL applied to new uploads (null means the<br/>
        ///   system default, which is public).<br/>
        /// Both fields are null when the account has never saved settings.<br/>
        /// **Authentication:** Required. The API key must have the `account:settings:read` permission.<br/>
        ///     
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.GetStorageSettingsResponse> GetStorageSettingsAsync(
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get storage settings<br/>
        /// Returns the account-level storage lifecycle settings applied to newly uploaded<br/>
        /// fal CDN files:<br/>
        /// - `expiration_duration_seconds`: how long files live before being<br/>
        ///   automatically deleted (null disables auto-expiration).<br/>
        /// - `initial_acl`: the default ACL applied to new uploads (null means the<br/>
        ///   system default, which is public).<br/>
        /// Both fields are null when the account has never saved settings.<br/>
        /// **Authentication:** Required. The API key must have the `account:settings:read` permission.<br/>
        ///     
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.GetStorageSettingsResponse>> GetStorageSettingsAsResponseAsync(
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
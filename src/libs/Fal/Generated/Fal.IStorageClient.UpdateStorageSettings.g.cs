#nullable enable

namespace Fal
{
    public partial interface IStorageClient
    {
        /// <summary>
        /// Update storage settings<br/>
        /// Replaces the account-level storage lifecycle settings applied to newly<br/>
        /// uploaded fal CDN files. Omitted or null fields are cleared (reset to the<br/>
        /// system default), so always send the full desired configuration.<br/>
        /// ACL rules referencing users that do not exist are dropped. The response<br/>
        /// reflects the settings actually saved, so verify it contains the rules you sent.<br/>
        /// These are the same settings that the per-request<br/>
        /// `X-Fal-Object-Lifecycle-Preference` header overrides on individual requests.<br/>
        /// **Authentication:** Required. The API key must have the `account:settings:write` permission.<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.UpdateStorageSettingsResponse> UpdateStorageSettingsAsync(

            global::Fal.UpdateStorageSettingsRequest request,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update storage settings<br/>
        /// Replaces the account-level storage lifecycle settings applied to newly<br/>
        /// uploaded fal CDN files. Omitted or null fields are cleared (reset to the<br/>
        /// system default), so always send the full desired configuration.<br/>
        /// ACL rules referencing users that do not exist are dropped. The response<br/>
        /// reflects the settings actually saved, so verify it contains the rules you sent.<br/>
        /// These are the same settings that the per-request<br/>
        /// `X-Fal-Object-Lifecycle-Preference` header overrides on individual requests.<br/>
        /// **Authentication:** Required. The API key must have the `account:settings:write` permission.<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.UpdateStorageSettingsResponse>> UpdateStorageSettingsAsResponseAsync(

            global::Fal.UpdateStorageSettingsRequest request,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update storage settings<br/>
        /// Replaces the account-level storage lifecycle settings applied to newly<br/>
        /// uploaded fal CDN files. Omitted or null fields are cleared (reset to the<br/>
        /// system default), so always send the full desired configuration.<br/>
        /// ACL rules referencing users that do not exist are dropped. The response<br/>
        /// reflects the settings actually saved, so verify it contains the rules you sent.<br/>
        /// These are the same settings that the per-request<br/>
        /// `X-Fal-Object-Lifecycle-Preference` header overrides on individual requests.<br/>
        /// **Authentication:** Required. The API key must have the `account:settings:write` permission.<br/>
        ///     
        /// </summary>
        /// <param name="expirationDurationSeconds">
        /// Seconds after which newly uploaded files automatically expire and are deleted. Null disables auto-expiration.<br/>
        /// Example: 86400
        /// </param>
        /// <param name="initialAcl">
        /// Default ACL applied to newly uploaded files. Null uses the system default (public).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.UpdateStorageSettingsResponse> UpdateStorageSettingsAsync(
            int? expirationDurationSeconds = default,
            global::Fal.UpdateStorageSettingsRequestInitialAcl? initialAcl = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
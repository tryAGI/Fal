#nullable enable

namespace Fal
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// Organization Teams<br/>
        /// Returns the list of teams in your organization with their details.<br/>
        /// &gt; **Availability:** This endpoint is available to enterprise customers with organizations enabled. Contact your account team or support@fal.ai to request access.<br/>
        /// Must be called with an admin API key on the organization's root team.<br/>
        /// **Key Features:**<br/>
        /// - List all teams within the organization<br/>
        /// - Identify the organization's root team via `is_org_root`<br/>
        /// - View team usernames and display names<br/>
        /// See [fal.ai docs](https://docs.fal.ai) for more details.<br/>
        ///     
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.GetOrganizationTeamsResponse> GetOrganizationTeamsAsync(
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Organization Teams<br/>
        /// Returns the list of teams in your organization with their details.<br/>
        /// &gt; **Availability:** This endpoint is available to enterprise customers with organizations enabled. Contact your account team or support@fal.ai to request access.<br/>
        /// Must be called with an admin API key on the organization's root team.<br/>
        /// **Key Features:**<br/>
        /// - List all teams within the organization<br/>
        /// - Identify the organization's root team via `is_org_root`<br/>
        /// - View team usernames and display names<br/>
        /// See [fal.ai docs](https://docs.fal.ai) for more details.<br/>
        ///     
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.GetOrganizationTeamsResponse>> GetOrganizationTeamsAsResponseAsync(
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
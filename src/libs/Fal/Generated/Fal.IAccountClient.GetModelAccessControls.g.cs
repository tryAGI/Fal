#nullable enable

namespace Fal
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Model Access Controls Report<br/>
        /// Returns the current model access controls for your organization as a CSV download.<br/>
        /// &gt; **Availability:** This endpoint is available to enterprise customers with model access controls enabled. Contact your account team or support@fal.ai to request access.<br/>
        /// The report includes each model's endpoint ID, title, category, enterprise readiness status, and the resolved UI and API access state (ALLOWED or BLOCKED).<br/>
        ///     
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetModelAccessControlsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
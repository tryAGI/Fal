#nullable enable

namespace Fal
{
    public partial interface IServerlessClient
    {

        /// <summary>
        /// List files (root)<br/>
        /// Lists files and folders in the root of your project storage.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Fal.ServerlessListRootResponseItem>> ServerlessListRootAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
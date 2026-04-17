#nullable enable

namespace Soniox
{
    public partial interface ITranscriptionsClient
    {
        /// <summary>
        /// Get transcriptions count<br/>
        /// Returns the total number of transcriptions, split by request scope.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.GetTranscriptionsCountResponse> GetTranscriptionsCountAsync(
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
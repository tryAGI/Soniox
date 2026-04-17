#nullable enable

namespace Soniox
{
    public partial interface ITranscriptionsClient
    {
        /// <summary>
        /// Get transcriptions<br/>
        /// Retrieves list of transcriptions.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of transcriptions to return.<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor for the next page of results.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.GetTranscriptionsResponse> GetTranscriptionsAsync(
            int? limit = default,
            string? cursor = default,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
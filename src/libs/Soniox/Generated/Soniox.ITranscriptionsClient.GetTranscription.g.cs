#nullable enable

namespace Soniox
{
    public partial interface ITranscriptionsClient
    {
        /// <summary>
        /// Get transcription<br/>
        /// Retrieves detailed information about a specific transcription.
        /// </summary>
        /// <param name="transcriptionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.Transcription> GetTranscriptionAsync(
            global::System.Guid transcriptionId,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
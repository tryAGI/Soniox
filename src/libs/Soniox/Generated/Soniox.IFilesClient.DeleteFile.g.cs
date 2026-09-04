#nullable enable

namespace Soniox
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Delete file<br/>
        /// Permanently deletes specified file. If a transcription that has not started processing yet still references the file, that transcription fails with `file_not_found`, so delete the file only after the transcription reaches `completed` or `error`.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteFileAsync(
            global::System.Guid fileId,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete file<br/>
        /// Permanently deletes specified file. If a transcription that has not started processing yet still references the file, that transcription fails with `file_not_found`, so delete the file only after the transcription reaches `completed` or `error`.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.AutoSDKHttpResponse> DeleteFileAsResponseAsync(
            global::System.Guid fileId,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
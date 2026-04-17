#nullable enable

namespace Soniox
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload file<br/>
        /// Uploads a new file.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.File> UploadFileAsync(

            global::Soniox.UploadFileRequest request,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload file<br/>
        /// Uploads a new file.
        /// </summary>
        /// <param name="clientReferenceId">
        /// Optional tracking identifier string. Does not need to be unique.
        /// </param>
        /// <param name="file">
        /// The file to upload. Original file name will be used unless a custom filename is provided.
        /// </param>
        /// <param name="filename">
        /// The file to upload. Original file name will be used unless a custom filename is provided.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.File> UploadFileAsync(
            byte[] file,
            string filename,
            string? clientReferenceId = default,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
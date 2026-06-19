#nullable enable

namespace Soniox
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Create voice<br/>
        /// Uploads a reference audio clip and creates a new voice.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.Voice> CreateVoiceAsync(

            global::Soniox.CreateVoiceRequest request,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice<br/>
        /// Uploads a reference audio clip and creates a new voice.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.AutoSDKHttpResponse<global::Soniox.Voice>> CreateVoiceAsResponseAsync(

            global::Soniox.CreateVoiceRequest request,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice<br/>
        /// Uploads a reference audio clip and creates a new voice.
        /// </summary>
        /// <param name="name">
        /// A name for the voice, unique within your project.
        /// </param>
        /// <param name="file">
        /// The reference audio clip for the voice.
        /// </param>
        /// <param name="filename">
        /// The reference audio clip for the voice.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.Voice> CreateVoiceAsync(
            string name,
            byte[] file,
            string filename,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create voice<br/>
        /// Uploads a reference audio clip and creates a new voice.
        /// </summary>
        /// <param name="name">
        /// A name for the voice, unique within your project.
        /// </param>
        /// <param name="file">
        /// The reference audio clip for the voice.
        /// </param>
        /// <param name="filename">
        /// The reference audio clip for the voice.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.Voice> CreateVoiceAsync(
            string name,
            global::System.IO.Stream file,
            string filename,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice<br/>
        /// Uploads a reference audio clip and creates a new voice.
        /// </summary>
        /// <param name="name">
        /// A name for the voice, unique within your project.
        /// </param>
        /// <param name="file">
        /// The reference audio clip for the voice.
        /// </param>
        /// <param name="filename">
        /// The reference audio clip for the voice.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.AutoSDKHttpResponse<global::Soniox.Voice>> CreateVoiceAsResponseAsync(
            string name,
            global::System.IO.Stream file,
            string filename,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
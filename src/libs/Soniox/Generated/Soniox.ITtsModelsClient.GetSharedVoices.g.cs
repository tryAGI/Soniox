#nullable enable

namespace Soniox
{
    public partial interface ITtsModelsClient
    {
        /// <summary>
        /// Get shared voices<br/>
        /// Retrieves the shared voices built into a TTS model, optionally filtered by gender, age, accent, use case and style. All given filters must match. For the voices you have cloned yourself, see `GET /v1/voices` instead.
        /// </summary>
        /// <param name="model">
        /// Id of the TTS model whose voices to return.
        /// </param>
        /// <param name="gender">
        /// Only return voices of this gender.
        /// </param>
        /// <param name="age">
        /// Only return voices of this age.
        /// </param>
        /// <param name="accent">
        /// Only return voices with this accent.
        /// </param>
        /// <param name="useCase">
        /// Only return voices tagged with every listed use case. Repeat the parameter to pass several values, or separate them with commas.
        /// </param>
        /// <param name="style">
        /// Only return voices tagged with every listed style. Repeat the parameter to pass several values, or separate them with commas.
        /// </param>
        /// <param name="limit">
        /// Maximum number of voices to return.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor for the next page of results. Pass the same filters alongside it; the cursor points into the filtered list, not the whole catalogue.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.GetSharedVoicesResponse> GetSharedVoicesAsync(
            string model,
            global::Soniox.TTSVoiceGender? gender = default,
            global::Soniox.TTSVoiceAge? age = default,
            string? accent = default,
            global::System.Collections.Generic.IList<string>? useCase = default,
            global::System.Collections.Generic.IList<string>? style = default,
            int? limit = default,
            string? cursor = default,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get shared voices<br/>
        /// Retrieves the shared voices built into a TTS model, optionally filtered by gender, age, accent, use case and style. All given filters must match. For the voices you have cloned yourself, see `GET /v1/voices` instead.
        /// </summary>
        /// <param name="model">
        /// Id of the TTS model whose voices to return.
        /// </param>
        /// <param name="gender">
        /// Only return voices of this gender.
        /// </param>
        /// <param name="age">
        /// Only return voices of this age.
        /// </param>
        /// <param name="accent">
        /// Only return voices with this accent.
        /// </param>
        /// <param name="useCase">
        /// Only return voices tagged with every listed use case. Repeat the parameter to pass several values, or separate them with commas.
        /// </param>
        /// <param name="style">
        /// Only return voices tagged with every listed style. Repeat the parameter to pass several values, or separate them with commas.
        /// </param>
        /// <param name="limit">
        /// Maximum number of voices to return.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor for the next page of results. Pass the same filters alongside it; the cursor points into the filtered list, not the whole catalogue.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.AutoSDKHttpResponse<global::Soniox.GetSharedVoicesResponse>> GetSharedVoicesAsResponseAsync(
            string model,
            global::Soniox.TTSVoiceGender? gender = default,
            global::Soniox.TTSVoiceAge? age = default,
            string? accent = default,
            global::System.Collections.Generic.IList<string>? useCase = default,
            global::System.Collections.Generic.IList<string>? style = default,
            int? limit = default,
            string? cursor = default,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
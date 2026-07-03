#nullable enable

using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Soniox;

/// <summary>
/// Text-to-speech request for the Soniox REST TTS endpoint.
/// </summary>
public sealed class SonioxTextToSpeechRequest
{
    /// <summary>
    /// Text-to-speech model to use.
    /// </summary>
    [JsonPropertyName("model")]
    public string Model { get; set; } = SonioxClient.DefaultTtsModel;

    /// <summary>
    /// Language code of the input text.
    /// </summary>
    [JsonPropertyName("language")]
    public required string Language { get; set; } = SonioxClient.DefaultTtsLanguage;

    /// <summary>
    /// Voice to use: a built-in voice name, or the ID of a cloned voice.
    /// </summary>
    [JsonPropertyName("voice")]
    public required string Voice { get; set; }

    /// <summary>
    /// Output audio format, for example <c>wav</c>, <c>mp3</c>, <c>pcm_s16le</c>, or <c>pcm_s16be</c>.
    /// </summary>
    [JsonPropertyName("audio_format")]
    public required string AudioFormat { get; set; } = SonioxClient.DefaultTtsAudioFormat;

    /// <summary>
    /// Input text to generate audio from.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    /// <summary>
    /// Optional output sample rate in Hz.
    /// </summary>
    [JsonPropertyName("sample_rate")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? SampleRate { get; set; }

    /// <summary>
    /// Optional output bitrate in bits per second.
    /// </summary>
    [JsonPropertyName("bitrate")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Bitrate { get; set; }

    /// <summary>
    /// Optional tracking identifier. Ignored when authenticating with a temporary API key.
    /// </summary>
    [JsonPropertyName("client_reference_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ClientReferenceId { get; set; }

    /// <summary>
    /// Optional speaking rate from <c>0.7</c> to <c>1.3</c>; <c>1.0</c> is normal speed.
    /// </summary>
    [JsonPropertyName("speed")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? Speed { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SonioxTextToSpeechRequest"/> class.
    /// </summary>
#if NET7_0_OR_GREATER
    [System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
    public SonioxTextToSpeechRequest(
        string text,
        string voice,
        string language = SonioxClient.DefaultTtsLanguage,
        string audioFormat = SonioxClient.DefaultTtsAudioFormat,
        string model = SonioxClient.DefaultTtsModel)
    {
        Text = text ?? throw new ArgumentNullException(nameof(text));
        Voice = voice ?? throw new ArgumentNullException(nameof(voice));
        Language = language ?? throw new ArgumentNullException(nameof(language));
        AudioFormat = audioFormat ?? throw new ArgumentNullException(nameof(audioFormat));
        Model = model ?? throw new ArgumentNullException(nameof(model));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SonioxTextToSpeechRequest"/> class.
    /// </summary>
    public SonioxTextToSpeechRequest()
    {
    }
}

/// <summary>
/// Error payload returned by the Soniox REST TTS endpoint.
/// </summary>
public sealed class SonioxTextToSpeechError
{
    /// <summary>
    /// HTTP status code for the error.
    /// </summary>
    [JsonPropertyName("error_code")]
    public int ErrorCode { get; set; }

    /// <summary>
    /// Machine-readable error category.
    /// </summary>
    [JsonPropertyName("error_type")]
    public string? ErrorType { get; set; }

    /// <summary>
    /// Human-readable error message.
    /// </summary>
    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// Optional documentation URL with additional information.
    /// </summary>
    [JsonPropertyName("more_info")]
    public string? MoreInfo { get; set; }

    /// <summary>
    /// Request id to include when contacting Soniox support.
    /// </summary>
    [JsonPropertyName("request_id")]
    public string? RequestId { get; set; }
}

/// <summary>
/// Hand-written Text-to-Speech REST support.
/// </summary>
public partial class SonioxClient
{
    /// <summary>
    /// REST endpoint for Soniox Text-to-Speech generation.
    /// </summary>
    public const string TextToSpeechRestUrl = "https://tts-rt.soniox.com/tts";

    /// <summary>
    /// Default language used by convenience Text-to-Speech overloads.
    /// </summary>
    public const string DefaultTtsLanguage = "en";

    /// <summary>
    /// Default output audio format used by convenience Text-to-Speech overloads.
    /// </summary>
    public const string DefaultTtsAudioFormat = "wav";

    private static readonly Uri s_textToSpeechRestUri = new(TextToSpeechRestUrl);

    /// <summary>
    /// Generates speech audio with the Soniox REST Text-to-Speech endpoint.
    /// </summary>
    /// <param name="request">Text-to-speech request. The <see cref="SonioxTextToSpeechRequest.Voice"/> value can be a built-in voice name or a cloned voice ID.</param>
    /// <param name="requestId">Optional request ID for tracing.</param>
    /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    /// <returns>Generated audio bytes.</returns>
    /// <exception cref="ApiException">Thrown when Soniox returns a non-success response.</exception>
    public async Task<byte[]> GenerateSpeechAsync(
        SonioxTextToSpeechRequest request,
        string? requestId = default,
        AutoSDKRequestOptions? requestOptions = default,
        CancellationToken cancellationToken = default)
    {
        using var stream = await GenerateSpeechAsStreamAsync(
            request: request,
            requestId: requestId,
            requestOptions: requestOptions,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        if (stream is MemoryStream memoryStream)
        {
            return memoryStream.ToArray();
        }

        using var copy = new MemoryStream();
        await stream.CopyToAsync(copy, cancellationToken).ConfigureAwait(false);
        return copy.ToArray();
    }

    /// <summary>
    /// Generates speech audio with the Soniox REST Text-to-Speech endpoint.
    /// </summary>
    /// <param name="text">Input text to generate audio from.</param>
    /// <param name="voice">Built-in voice name, or the ID of a cloned voice.</param>
    /// <param name="language">Language code of the input text.</param>
    /// <param name="audioFormat">Output audio format.</param>
    /// <param name="model">Text-to-speech model to use.</param>
    /// <param name="sampleRate">Optional output sample rate in Hz.</param>
    /// <param name="bitrate">Optional output bitrate in bits per second.</param>
    /// <param name="clientReferenceId">Optional tracking identifier. Ignored when authenticating with a temporary API key.</param>
    /// <param name="speed">Optional speaking rate from <c>0.7</c> to <c>1.3</c>.</param>
    /// <param name="requestId">Optional request ID for tracing.</param>
    /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    /// <returns>Generated audio bytes.</returns>
    /// <exception cref="ApiException">Thrown when Soniox returns a non-success response.</exception>
    public Task<byte[]> GenerateSpeechAsync(
        string text,
        string voice,
        string language = DefaultTtsLanguage,
        string audioFormat = DefaultTtsAudioFormat,
        string model = DefaultTtsModel,
        int? sampleRate = default,
        int? bitrate = default,
        string? clientReferenceId = default,
        double? speed = default,
        string? requestId = default,
        AutoSDKRequestOptions? requestOptions = default,
        CancellationToken cancellationToken = default)
    {
        var request = new SonioxTextToSpeechRequest(
            text: text,
            voice: voice,
            language: language,
            audioFormat: audioFormat,
            model: model)
        {
            SampleRate = sampleRate,
            Bitrate = bitrate,
            ClientReferenceId = clientReferenceId,
            Speed = speed,
        };

        return GenerateSpeechAsync(
            request: request,
            requestId: requestId,
            requestOptions: requestOptions,
            cancellationToken: cancellationToken);
    }

    /// <summary>
    /// Generates speech audio with the Soniox REST Text-to-Speech endpoint.
    /// </summary>
    /// <param name="request">Text-to-speech request. The <see cref="SonioxTextToSpeechRequest.Voice"/> value can be a built-in voice name or a cloned voice ID.</param>
    /// <param name="requestId">Optional request ID for tracing.</param>
    /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
    /// <param name="cancellationToken">The token to cancel the operation with.</param>
    /// <returns>A seekable stream containing generated audio bytes.</returns>
    /// <exception cref="ApiException">Thrown when Soniox returns a non-success response.</exception>
    public async Task<Stream> GenerateSpeechAsStreamAsync(
        SonioxTextToSpeechRequest request,
        string? requestId = default,
        AutoSDKRequestOptions? requestOptions = default,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request);

        PrepareArguments(client: HttpClient);

        using var timeoutCancellationTokenSource = AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
            clientOptions: Options,
            requestOptions: requestOptions,
            cancellationToken: cancellationToken);
        var effectiveCancellationToken = timeoutCancellationTokenSource?.Token ?? cancellationToken;
        var maxAttempts = AutoSDKRequestOptionsSupport.GetMaxAttempts(
            clientOptions: Options,
            requestOptions: requestOptions,
            supportsRetry: true);

        for (var attempt = 1; attempt <= maxAttempts; attempt++)
        {
            using var httpRequest = CreateTextToSpeechHttpRequest(request, requestId, requestOptions);
            HttpResponseMessage? response = null;

            try
            {
                await AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                    clientOptions: Options,
                    context: CreateTextToSpeechHookContext(
                        httpRequest,
                        requestOptions: requestOptions,
                        response: null,
                        exception: null,
                        attempt: attempt,
                        maxAttempts: maxAttempts,
                        willRetry: false,
                        retryDelay: null,
                        retryReason: string.Empty,
                        cancellationToken: effectiveCancellationToken)).ConfigureAwait(false);

                response = await HttpClient.SendAsync(
                    request: httpRequest,
                    completionOption: HttpCompletionOption.ResponseHeadersRead,
                    cancellationToken: effectiveCancellationToken).ConfigureAwait(false);

                ProcessResponse(client: HttpClient, response: response);

                if (AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(response.StatusCode) && attempt < maxAttempts)
                {
                    var retryDelay = AutoSDKRequestOptionsSupport.GetRetryDelay(
                        clientOptions: Options,
                        requestOptions: requestOptions,
                        response: response,
                        attempt: attempt);

                    await AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                        clientOptions: Options,
                        context: CreateTextToSpeechHookContext(
                            httpRequest,
                            requestOptions: requestOptions,
                            response: response,
                            exception: null,
                            attempt: attempt,
                            maxAttempts: maxAttempts,
                            willRetry: true,
                            retryDelay: retryDelay,
                            retryReason: response.StatusCode.ToString(),
                            cancellationToken: effectiveCancellationToken)).ConfigureAwait(false);

                    response.Dispose();
                    response = null;
                    await AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(retryDelay, effectiveCancellationToken).ConfigureAwait(false);
                    continue;
                }

                if (response.IsSuccessStatusCode)
                {
                    var bytes = await response.Content.ReadAsByteArrayAsync(effectiveCancellationToken).ConfigureAwait(false);
                    var stream = new MemoryStream(bytes, writable: false);

                    await AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                        clientOptions: Options,
                        context: CreateTextToSpeechHookContext(
                            httpRequest,
                            requestOptions: requestOptions,
                            response: response,
                            exception: null,
                            attempt: attempt,
                            maxAttempts: maxAttempts,
                            willRetry: false,
                            retryDelay: null,
                            retryReason: string.Empty,
                            cancellationToken: effectiveCancellationToken)).ConfigureAwait(false);

                    return stream;
                }

                var errorBody = await response.Content.ReadAsStringAsync(effectiveCancellationToken).ConfigureAwait(false);
                var exception = CreateTextToSpeechApiException(response, errorBody);

                await AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                    clientOptions: Options,
                    context: CreateTextToSpeechHookContext(
                        httpRequest,
                        requestOptions: requestOptions,
                        response: response,
                        exception: exception,
                        attempt: attempt,
                        maxAttempts: maxAttempts,
                        willRetry: false,
                        retryDelay: null,
                        retryReason: response.StatusCode.ToString(),
                        cancellationToken: effectiveCancellationToken)).ConfigureAwait(false);

                throw exception;
            }
            catch (HttpRequestException exception) when (attempt < maxAttempts)
            {
                var retryDelay = AutoSDKRequestOptionsSupport.GetRetryDelay(
                    clientOptions: Options,
                    requestOptions: requestOptions,
                    response: response,
                    attempt: attempt);

                await AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                    clientOptions: Options,
                    context: CreateTextToSpeechHookContext(
                        httpRequest,
                        requestOptions: requestOptions,
                        response: response,
                        exception: exception,
                        attempt: attempt,
                        maxAttempts: maxAttempts,
                        willRetry: true,
                        retryDelay: retryDelay,
                        retryReason: exception.GetType().Name,
                        cancellationToken: effectiveCancellationToken)).ConfigureAwait(false);

                await AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(retryDelay, effectiveCancellationToken).ConfigureAwait(false);
            }
            finally
            {
                response?.Dispose();
            }
        }

        throw new InvalidOperationException("Soniox Text-to-Speech request did not complete.");
    }

    private HttpRequestMessage CreateTextToSpeechHttpRequest(
        SonioxTextToSpeechRequest request,
        string? requestId,
        AutoSDKRequestOptions? requestOptions)
    {
        var uri = AutoSDKRequestOptionsSupport.AppendQueryParameters(
            path: TextToSpeechRestUrl,
            clientParameters: Options.QueryParameters,
            requestParameters: requestOptions?.QueryParameters);

        var httpRequest = new HttpRequestMessage(HttpMethod.Post, new Uri(uri, UriKind.Absolute));
#if NET6_0_OR_GREATER
        httpRequest.Version = System.Net.HttpVersion.Version11;
        httpRequest.VersionPolicy = HttpVersionPolicy.RequestVersionOrHigher;
#endif

        ApplyTextToSpeechAuthorizations(httpRequest, requestOptions);

        if (requestId is { Length: > 0 })
        {
            httpRequest.Headers.TryAddWithoutValidation("X-Request-Id", requestId);
        }

        var json = JsonSerializer.Serialize(
            request,
            SonioxTextToSpeechJsonSerializerContext.Default.SonioxTextToSpeechRequest);
        httpRequest.Content = new StringContent(json, Encoding.UTF8, "application/json");

        AutoSDKRequestOptionsSupport.ApplyHeaders(
            request: httpRequest,
            clientHeaders: Options.Headers,
            requestHeaders: requestOptions?.Headers);

        PrepareRequest(client: HttpClient, request: httpRequest);
        return httpRequest;
    }

    private void ApplyTextToSpeechAuthorizations(
        HttpRequestMessage httpRequest,
        AutoSDKRequestOptions? requestOptions)
    {
        if (requestOptions?.Authorizations is { Count: > 0 } requestAuthorizations)
        {
            for (var i = 0; i < requestAuthorizations.Count; i++)
            {
                ApplyTextToSpeechAuthorization(httpRequest, requestAuthorizations[i]);
            }

            AutoSDKHttpRequestOptions.StampAuthorizationOverride(httpRequest);
            return;
        }

        for (var i = 0; i < Authorizations.Count; i++)
        {
            ApplyTextToSpeechAuthorization(httpRequest, Authorizations[i]);
        }
    }

    private static void ApplyTextToSpeechAuthorization(
        HttpRequestMessage httpRequest,
        EndPointAuthorization authorization)
    {
        if (authorization.Type is "Http" or "OAuth2" or "OpenIdConnect")
        {
            httpRequest.Headers.Authorization = new AuthenticationHeaderValue(
                scheme: authorization.Name,
                parameter: authorization.Value);
        }
        else if (authorization.Type == "ApiKey" && authorization.Location == "Header")
        {
            httpRequest.Headers.Remove(authorization.Name);
            httpRequest.Headers.Add(authorization.Name, authorization.Value);
        }
    }

    private static void ApplyTextToSpeechAuthorization(
        HttpRequestMessage httpRequest,
        AutoSDKAuthorizationValue authorization)
    {
        if (authorization.Type is "Http" or "OAuth2" or "OpenIdConnect")
        {
            httpRequest.Headers.Authorization = new AuthenticationHeaderValue(
                scheme: authorization.Scheme,
                parameter: authorization.Value);
        }
        else if (authorization.Type == "ApiKey" &&
                 authorization.Location == "Header" &&
                 authorization.HeaderName is { Length: > 0 })
        {
            httpRequest.Headers.Remove(authorization.HeaderName);
            httpRequest.Headers.Add(authorization.HeaderName, authorization.Value);
        }
    }

    private AutoSDKHookContext CreateTextToSpeechHookContext(
        HttpRequestMessage request,
        AutoSDKRequestOptions? requestOptions,
        HttpResponseMessage? response,
        Exception? exception,
        int attempt,
        int maxAttempts,
        bool willRetry,
        TimeSpan? retryDelay,
        string retryReason,
        CancellationToken cancellationToken)
    {
        return AutoSDKRequestOptionsSupport.CreateHookContext(
            operationId: "GenerateSpeech",
            methodName: "GenerateSpeechAsync",
            pathTemplate: "\"/tts\"",
            httpMethod: "POST",
            baseUri: s_textToSpeechRestUri,
            request: request,
            response: response,
            exception: exception,
            clientOptions: Options,
            requestOptions: requestOptions,
            attempt: attempt,
            maxAttempts: maxAttempts,
            willRetry: willRetry,
            retryDelay: retryDelay,
            retryReason: retryReason,
            cancellationToken: cancellationToken);
    }

    private static ApiException CreateTextToSpeechApiException(HttpResponseMessage response, string responseBody)
    {
        var message = $"Soniox Text-to-Speech request failed with status {(int)response.StatusCode}.";
        try
        {
            var error = JsonSerializer.Deserialize(
                responseBody,
                SonioxTextToSpeechJsonSerializerContext.Default.SonioxTextToSpeechError);
            if (error?.ErrorMessage is { Length: > 0 })
            {
                message = error.ErrorType is { Length: > 0 }
                    ? $"{error.ErrorType}: {error.ErrorMessage}"
                    : error.ErrorMessage;
            }
        }
        catch (JsonException)
        {
        }

        return ApiException.Create(
            statusCode: response.StatusCode,
            message: message,
            innerException: null,
            responseBody: responseBody,
            responseHeaders: GetTextToSpeechResponseHeaders(response));
    }

    private static Dictionary<string, IEnumerable<string>> GetTextToSpeechResponseHeaders(HttpResponseMessage response)
    {
        var headers = new Dictionary<string, IEnumerable<string>>(StringComparer.OrdinalIgnoreCase);

        foreach (var header in response.Headers)
        {
            headers[header.Key] = header.Value;
        }

        foreach (var header in response.Content.Headers)
        {
            headers[header.Key] = header.Value;
        }

        return headers;
    }
}

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(SonioxTextToSpeechRequest))]
[JsonSerializable(typeof(SonioxTextToSpeechError))]
internal sealed partial class SonioxTextToSpeechJsonSerializerContext : JsonSerializerContext
{
}

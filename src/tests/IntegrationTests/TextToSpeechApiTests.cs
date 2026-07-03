using System.Net;
using System.Text;
using System.Text.Json;

namespace Soniox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task TextToSpeech_GeneratesSpeechWithClonedVoiceId()
    {
        var clonedVoiceId = Guid.NewGuid();
        var handler = new RecordingHandler(_ => new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new ByteArrayContent(new byte[] { 1, 2, 3, 4 }),
        });

        using var httpClient = new HttpClient(handler);
        using var client = new SonioxClient("test-api-key", httpClient);

        var audio = await client.GenerateSpeechAsync(
            text: "Hello from a cloned voice.",
            voice: clonedVoiceId.ToString(),
            language: "en",
            audioFormat: "wav",
            sampleRate: 24000,
            clientReferenceId: "voice-clone-test",
            requestId: "request-123");

        audio.Should().Equal(new byte[] { 1, 2, 3, 4 });
        handler.RequestUri.Should().Be(new Uri(SonioxClient.TextToSpeechRestUrl));
        handler.AuthorizationScheme.Should().Be("Bearer");
        handler.AuthorizationValue.Should().Be("test-api-key");
        handler.RequestId.Should().Be("request-123");
        handler.ContentType.Should().Be("application/json");

        using var json = JsonDocument.Parse(handler.RequestBody!);
        var root = json.RootElement;
        root.GetProperty("model").GetString().Should().Be(SonioxClient.DefaultTtsModel);
        root.GetProperty("language").GetString().Should().Be("en");
        root.GetProperty("voice").GetString().Should().Be(clonedVoiceId.ToString());
        root.GetProperty("audio_format").GetString().Should().Be("wav");
        root.GetProperty("text").GetString().Should().Be("Hello from a cloned voice.");
        root.GetProperty("sample_rate").GetInt32().Should().Be(24000);
        root.GetProperty("client_reference_id").GetString().Should().Be("voice-clone-test");
    }

    [TestMethod]
    public async Task TextToSpeech_ThrowsApiExceptionWithTtsErrorBody()
    {
        const string errorBody = """
        {
          "error_code": 400,
          "error_type": "invalid_request",
          "error_message": "Invalid voice 'missing' for model 'tts-rt-v1'.",
          "more_info": "https://soniox.com/docs/api-reference/errors#invalid-request",
          "request_id": "req_123"
        }
        """;

        var handler = new RecordingHandler(_ => new HttpResponseMessage(HttpStatusCode.BadRequest)
        {
            Content = new StringContent(errorBody),
        });

        using var httpClient = new HttpClient(handler);
        using var client = new SonioxClient("test-api-key", httpClient);

        var act = async () => await client.GenerateSpeechAsync(
            text: "Hello",
            voice: "missing");

        var exception = await act.Should().ThrowAsync<ApiException>();
        exception.Which.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        exception.Which.Message.Should().Contain("invalid_request");
        exception.Which.ResponseBody.Should().Contain("Invalid voice");
        handler.RequestUri.Should().Be(new Uri(SonioxClient.TextToSpeechRestUrl));
    }

    [TestMethod]
    public async Task GeneratedTextToSpeechClient_UsesTtsHostFromAggregateClient()
    {
        var handler = new RecordingHandler(_ => new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new ByteArrayContent(new byte[] { 5, 6, 7 }),
        });

        using var httpClient = new HttpClient(handler);
        using var client = new SonioxClient("test-api-key", httpClient);

        var audio = await client.Tts.GenerateTtsAsync(
            language: "en",
            voice: "Adrian",
            audioFormat: "wav",
            text: "Hello from the generated TTS client.",
            xRequestId: "generated-request-123",
            sampleRate: 24000);

        audio.Should().Equal(new byte[] { 5, 6, 7 });
        handler.RequestUri.Should().Be(new Uri(SonioxClient.TextToSpeechRestUrl));
        handler.AuthorizationScheme.Should().Be("Bearer");
        handler.AuthorizationValue.Should().Be("test-api-key");
        handler.RequestId.Should().Be("generated-request-123");

        using var json = JsonDocument.Parse(handler.RequestBody!);
        var root = json.RootElement;
        root.GetProperty("model").GetString().Should().Be(SonioxClient.DefaultTtsModel);
        root.GetProperty("language").GetString().Should().Be("en");
        root.GetProperty("voice").GetString().Should().Be("Adrian");
        root.GetProperty("audio_format").GetString().Should().Be("wav");
        root.GetProperty("text").GetString().Should().Be("Hello from the generated TTS client.");
        root.GetProperty("sample_rate").GetInt32().Should().Be(24000);
    }

    [TestMethod]
    public async Task VoiceCloning_UsesGeneratedVoiceManagementEndpoints()
    {
        var voiceId = Guid.NewGuid();
        var handler = new VoiceManagementHandler(voiceId);

        using var httpClient = new HttpClient(handler);
        using var client = new SonioxClient("test-api-key", httpClient);

        var created = await client.Voices.CreateVoiceAsync(
            name: "sdk-voice",
            file: new byte[] { 1, 2, 3 },
            filename: "sample.wav");
        var fetched = await client.Voices.GetVoiceAsync(voiceId);
        var recomputed = await client.Voices.RecomputeVoiceAsync(voiceId, SonioxClient.DefaultTtsModel);
        await client.Voices.DeleteVoiceAsync(voiceId);

        created.Id.Should().Be(voiceId);
        fetched.Models.Should().ContainSingle(model => model.Model == SonioxClient.DefaultTtsModel);
        recomputed.Models.Should().ContainSingle(model => model.Status == VoiceModelStatus.Ready);
        handler.Requests.Should().Equal(
            "POST /v1/voices",
            $"GET /v1/voices/{voiceId}",
            $"POST /v1/voices/{voiceId}/recompute",
            $"DELETE /v1/voices/{voiceId}");
        handler.AllRequestsWereAuthorized.Should().BeTrue();
        handler.CreateVoiceContentType.Should().Be("multipart/form-data");
        handler.CreateVoiceBody.Should().Contain("name=\"name\"");
        handler.CreateVoiceBody.Should().Contain("sdk-voice");
        handler.CreateVoiceBody.Should().Contain("filename=\"sample.wav\"");
        handler.RecomputeVoiceBody.Should().Contain(SonioxClient.DefaultTtsModel);
    }

    private sealed class RecordingHandler : HttpMessageHandler
    {
        private readonly Func<HttpRequestMessage, HttpResponseMessage> _responseFactory;

        public RecordingHandler(Func<HttpRequestMessage, HttpResponseMessage> responseFactory)
        {
            _responseFactory = responseFactory;
        }

        public Uri? RequestUri { get; private set; }

        public string? RequestBody { get; private set; }

        public string? AuthorizationScheme { get; private set; }

        public string? AuthorizationValue { get; private set; }

        public string? RequestId { get; private set; }

        public string? ContentType { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            RequestUri = request.RequestUri;
            AuthorizationScheme = request.Headers.Authorization?.Scheme;
            AuthorizationValue = request.Headers.Authorization?.Parameter;
            RequestId = request.Headers.TryGetValues("X-Request-Id", out var requestIds)
                ? requestIds.SingleOrDefault()
                : null;
            ContentType = request.Content?.Headers.ContentType?.MediaType;
            RequestBody = request.Content is null
                ? null
                : await request.Content.ReadAsStringAsync(cancellationToken);

            return _responseFactory(request);
        }
    }

    private sealed class VoiceManagementHandler : HttpMessageHandler
    {
        private readonly Guid _voiceId;

        public VoiceManagementHandler(Guid voiceId)
        {
            _voiceId = voiceId;
        }

        public List<string> Requests { get; } = [];

        public bool AllRequestsWereAuthorized { get; private set; } = true;

        public string? CreateVoiceContentType { get; private set; }

        public string? CreateVoiceBody { get; private set; }

        public string? RecomputeVoiceBody { get; private set; }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Requests.Add($"{request.Method} {request.RequestUri!.PathAndQuery}");
            AllRequestsWereAuthorized &= request.Headers.Authorization is
            {
                Scheme: "Bearer",
                Parameter: "test-api-key",
            };

            if (request.Method == HttpMethod.Post && request.RequestUri.PathAndQuery == "/v1/voices")
            {
                CreateVoiceContentType = request.Content?.Headers.ContentType?.MediaType;
                CreateVoiceBody = request.Content is null
                    ? null
                    : await request.Content.ReadAsStringAsync(cancellationToken);

                return JsonResponse(HttpStatusCode.Created, VoiceJson("processing"));
            }

            if (request.Method == HttpMethod.Get && request.RequestUri.PathAndQuery == $"/v1/voices/{_voiceId}")
            {
                return JsonResponse(HttpStatusCode.OK, VoiceJson("ready"));
            }

            if (request.Method == HttpMethod.Post && request.RequestUri.PathAndQuery == $"/v1/voices/{_voiceId}/recompute")
            {
                RecomputeVoiceBody = request.Content is null
                    ? null
                    : await request.Content.ReadAsStringAsync(cancellationToken);

                return JsonResponse(HttpStatusCode.OK, VoiceJson("ready"));
            }

            if (request.Method == HttpMethod.Delete && request.RequestUri.PathAndQuery == $"/v1/voices/{_voiceId}")
            {
                return new HttpResponseMessage(HttpStatusCode.NoContent);
            }

            return new HttpResponseMessage(HttpStatusCode.NotFound);
        }

        private string VoiceJson(string status) =>
            $$"""
            {
              "id": "{{_voiceId}}",
              "name": "sdk-voice",
              "filename": "sample.wav",
              "created_at": "2026-07-03T00:00:00Z",
              "models": [
                {
                  "model": "{{SonioxClient.DefaultTtsModel}}",
                  "status": "{{status}}",
                  "error_type": null,
                  "error_message": null
                }
              ]
            }
            """;

        private static HttpResponseMessage JsonResponse(HttpStatusCode statusCode, string json) =>
            new(statusCode)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };
    }
}

#pragma warning disable MEAI001 // MEAI speech-to-text abstractions are preview-gated.

using System.Text.Json;
using Meai = Microsoft.Extensions.AI;

namespace Soniox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void RealtimeAsyncApiModels_SerializeConfigAndResultFrames()
    {
        Realtime.SonioxRealtimeClient.SpeechToTextWebSocketUrl
            .Should().Be(SonioxClient.RealtimeWebSocketUrl);

        var configJson = JsonSerializer.Serialize(
            new Realtime.RealtimeConfig
            {
                ApiKey = "test-key",
                Model = SonioxClient.SttRealtimeV5ModelId,
                AudioFormat = "auto",
                LanguageHints = new[] { "en", "ru" },
                EnableLanguageIdentification = true,
            },
            typeof(Realtime.RealtimeConfig),
            Realtime.RealtimeSourceGenerationContext.Default);

        configJson.Should().Contain("\"model\":\"stt-rt-v5\"");
        configJson.Should().Contain("\"language_hints\":[\"en\",\"ru\"]");

        var resultJson = JsonSerializer.Serialize(
            new Realtime.RealtimeResult
            {
                Tokens =
                [
                    new Realtime.RealtimeToken
                    {
                        Text = "hello",
                        StartMs = 10,
                        EndMs = 120,
                        Language = "en",
                        IsFinal = true,
                    },
                ],
                FinalAudioProcMs = 120,
                TotalAudioProcMs = 160,
                Finished = true,
            },
            typeof(Realtime.RealtimeResult),
            Realtime.RealtimeSourceGenerationContext.Default);

        var update = SonioxClient.ParseServerFrame(resultJson, "response", out var finished);

        finished.Should().BeTrue();
        update.Should().NotBeNull();
        update!.Kind.Should().Be(Meai.SpeechToTextResponseUpdateKind.TextUpdated);
        update.Text.Should().Be("hello");
        update.AdditionalProperties![SonioxSpeechToTextPropertyNames.FinalAudioProcessedMs].Should().Be(120);
    }
}

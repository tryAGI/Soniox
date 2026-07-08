#pragma warning disable MEAI001 // MEAI speech-to-text abstractions are preview-gated.

using System.Text.Json;
using Meai = Microsoft.Extensions.AI;

namespace Soniox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void RealtimeAsyncApiModels_SerializeConfigAndResultFrames()
    {
        Realtime.SonioxRealtimeClient.DefaultBaseUrl
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

    [TestMethod]
    public void RealtimeTtsAsyncApiModels_SerializeStreamingFrames()
    {
        Realtime.Tts.SonioxTtsRealtimeClient.DefaultBaseUrl
            .Should().Be(SonioxClient.TextToSpeechRealtimeWebSocketUrl);

        var configJson = JsonSerializer.Serialize(
            new Realtime.Tts.TtsConfig
            {
                ApiKey = "test-key",
                StreamId = "stream-001",
                Model = SonioxClient.DefaultTtsModel,
                Language = SonioxClient.DefaultTtsLanguage,
                Voice = "Adrian",
                AudioFormat = SonioxClient.DefaultTtsAudioFormat,
                SampleRate = 24000,
                ReturnTimestamps = true,
                Speed = 1.2,
            },
            typeof(Realtime.Tts.TtsConfig),
            Realtime.Tts.TtsRealtimeSourceGenerationContext.Default);

        configJson.Should().Contain("\"stream_id\":\"stream-001\"");
        configJson.Should().Contain("\"return_timestamps\":true");
        configJson.Should().Contain("\"speed\":1.2");

        var textJson = JsonSerializer.Serialize(
            new Realtime.Tts.TtsText
            {
                StreamId = "stream-001",
                Text = "Hello from realtime TTS.",
                TextEnd = true,
            },
            typeof(Realtime.Tts.TtsText),
            Realtime.Tts.TtsRealtimeSourceGenerationContext.Default);

        textJson.Should().Contain("\"text_end\":true");

        var audioEvent = Realtime.Tts.ServerEvent.FromTtsAudio(new Realtime.Tts.TtsAudio
        {
            StreamId = "stream-001",
            Audio = Convert.ToBase64String(new byte[] { 1, 2, 3 }),
            AudioEnd = true,
            Timestamps = new Realtime.Tts.TtsTimestamps
            {
                Characters = ["H"],
                CharacterStartTimesSeconds = [0],
                CharacterEndTimesSeconds = [0.1],
            },
        });

        var parsedAudio = Realtime.Tts.ServerEvent.FromJson(
            audioEvent.ToJson(Realtime.Tts.TtsRealtimeSourceGenerationContext.Default),
            Realtime.Tts.TtsRealtimeSourceGenerationContext.Default);

        parsedAudio.Should().NotBeNull();
        parsedAudio!.Value.IsTtsAudio.Should().BeTrue();
        var parsedTtsAudio = parsedAudio.Value.PickTtsAudio();
        parsedTtsAudio.AudioEnd.Should().BeTrue();
        parsedTtsAudio.Timestamps.Should().NotBeNull();
        parsedTtsAudio.Timestamps!.Characters.Should().Equal("H");
        parsedTtsAudio.Timestamps.CharacterStartTimesSeconds.Should().Equal(0);
        parsedTtsAudio.Timestamps.CharacterEndTimesSeconds.Should().Equal(0.1);

        var parsedTerminated = Realtime.Tts.ServerEvent.FromJson(
            """{"terminated":true,"stream_id":"stream-001"}""",
            Realtime.Tts.TtsRealtimeSourceGenerationContext.Default);

        parsedTerminated.Should().NotBeNull();
        parsedTerminated!.Value.IsTtsTerminated.Should().BeTrue();
        parsedTerminated.Value.PickTtsTerminated().StreamId.Should().Be("stream-001");
    }
}

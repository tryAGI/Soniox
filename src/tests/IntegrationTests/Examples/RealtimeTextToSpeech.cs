/*
order: 45
title: Realtime Text-to-Speech
slug: realtime-text-to-speech

Streams text to the Soniox realtime Text-to-Speech WebSocket API. The default
test path serializes generated messages without making a network call. Set
`SONIOX_RUN_REALTIME_TTS_EXAMPLE=1` to run the paid live example.
*/

using System.Text.Json;
using TtsRealtime = Soniox.Realtime.Tts;

namespace Soniox.IntegrationTests;

public partial class Tests
{
    private const string RunRealtimeTtsExampleFlag = "SONIOX_RUN_REALTIME_TTS_EXAMPLE";

    [TestMethod]
    public async Task Example_RealtimeTextToSpeech()
    {
        var streamId = $"sdk-example-{Guid.NewGuid():N}";
        var config = new TtsRealtime.TtsConfig
        {
            ApiKey = GetOptionalEnvironmentVariable("SONIOX_API_KEY") ?? "test-key",
            StreamId = streamId,
            Model = SonioxClient.DefaultTtsModel,
            Language = SonioxClient.DefaultTtsLanguage,
            Voice = "Adrian",
            AudioFormat = SonioxClient.DefaultTtsAudioFormat,
            SampleRate = 24000,
        };
        var textChunks = new[]
        {
            new TtsRealtime.TtsText
            {
                StreamId = streamId,
                Text = "Hello from realtime ",
                TextEnd = false,
            },
            new TtsRealtime.TtsText
            {
                StreamId = streamId,
                Text = "Text-to-Speech.",
                TextEnd = true,
            },
        };
        var keepAlive = new TtsRealtime.TtsKeepAlive { KeepAlive = true };
        var cancel = new TtsRealtime.TtsCancel { StreamId = streamId, Cancel = true };

        if (!IsEnvironmentFlagEnabled(RunRealtimeTtsExampleFlag))
        {
            var configJson = JsonSerializer.Serialize(
                config,
                typeof(TtsRealtime.TtsConfig),
                TtsRealtime.TtsRealtimeSourceGenerationContext.Default);
            var firstTextJson = JsonSerializer.Serialize(
                textChunks[0],
                typeof(TtsRealtime.TtsText),
                TtsRealtime.TtsRealtimeSourceGenerationContext.Default);
            var keepAliveJson = JsonSerializer.Serialize(
                keepAlive,
                typeof(TtsRealtime.TtsKeepAlive),
                TtsRealtime.TtsRealtimeSourceGenerationContext.Default);
            var cancelJson = JsonSerializer.Serialize(
                cancel,
                typeof(TtsRealtime.TtsCancel),
                TtsRealtime.TtsRealtimeSourceGenerationContext.Default);

            configJson.Should().Contain("\"stream_id\"");
            firstTextJson.Should().Contain("\"text_end\":false");
            keepAliveJson.Should().Contain("\"keep_alive\":true");
            cancelJson.Should().Contain("\"cancel\":true");
            return;
        }

        using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(45));
        await using var client = new TtsRealtime.SonioxTtsRealtimeClient();

        await client.ConnectAsync(
            keepAliveInterval: TimeSpan.FromSeconds(15),
            connectTimeout: TimeSpan.FromSeconds(10),
            cancellationToken: cancellationTokenSource.Token);

        config.ApiKey = GetRequiredEnvironmentVariable("SONIOX_API_KEY");
        await client.SendTtsConfigAsync(config, cancellationTokenSource.Token);
        await client.SendTtsTextAsync(textChunks[0], cancellationTokenSource.Token);
        await client.SendTtsKeepAliveAsync(keepAlive, cancellationTokenSource.Token);
        await client.SendTtsTextAsync(textChunks[1], cancellationTokenSource.Token);

        var result = await CollectRealtimeTtsResultAsync(
            client: client,
            streamId: streamId,
            cancellationToken: cancellationTokenSource.Token);

        result.AudioBytes.Should().BeGreaterThan(0);
        result.AudioEnded.Should().BeTrue();
        result.Terminated.Should().BeTrue();
    }
}

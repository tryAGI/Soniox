using TtsRealtime = Soniox.Realtime.Tts;

namespace Soniox.IntegrationTests;

public partial class Tests
{
    private const string RunPaidTestsFlag = "SONIOX_RUN_PAID_TESTS";
    private const string RunRealtimeTtsSmokeTestFlag = "SONIOX_RUN_REALTIME_TTS_SMOKE_TEST";

    [TestMethod]
    public async Task RealtimeTts_WebSocketSmokeTest_GeneratesAudio()
    {
        if (!IsEnvironmentFlagEnabled(RunRealtimeTtsSmokeTestFlag) &&
            !IsEnvironmentFlagEnabled(RunPaidTestsFlag))
        {
            throw new AssertInconclusiveException(
                $"Set {RunRealtimeTtsSmokeTestFlag}=1 to run this paid realtime TTS smoke test.");
        }

        var result = await RunRealtimeTtsSessionAsync(
            apiKey: GetRequiredEnvironmentVariable("SONIOX_API_KEY"),
            textChunks: ["Hi."],
            sendKeepAliveBeforeFinalText: false);

        result.AudioBytes.Should().BeGreaterThan(0);
        result.AudioEnded.Should().BeTrue();
        result.CharacterTimestampCount.Should().BeGreaterThan(0);
        result.Terminated.Should().BeTrue();
    }

    private static async Task<RealtimeTtsSessionResult> RunRealtimeTtsSessionAsync(
        string apiKey,
        IReadOnlyList<string> textChunks,
        bool sendKeepAliveBeforeFinalText)
    {
        var streamId = $"sdk-smoke-{Guid.NewGuid():N}";
        using var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(45));
        await using var client = new TtsRealtime.SonioxTtsRealtimeClient();

        try
        {
            await client.ConnectAsync(
                keepAliveInterval: TimeSpan.FromSeconds(15),
                connectTimeout: TimeSpan.FromSeconds(10),
                cancellationToken: cancellationTokenSource.Token);

            await client.SendTtsConfigAsync(
                new TtsRealtime.TtsConfig
                {
                    ApiKey = apiKey,
                    StreamId = streamId,
                    Model = SonioxClient.DefaultTtsModel,
                    Language = SonioxClient.DefaultTtsLanguage,
                    Voice = "Adrian",
                    AudioFormat = SonioxClient.DefaultTtsAudioFormat,
                    SampleRate = 24000,
                    ClientReferenceId = "dotnet-sdk-smoke-test",
                    ReturnTimestamps = true,
                    Speed = 1.1,
                },
                cancellationTokenSource.Token);

            for (var index = 0; index < textChunks.Count; index++)
            {
                if (sendKeepAliveBeforeFinalText && index == textChunks.Count - 1)
                {
                    await client.SendTtsKeepAliveAsync(
                        new TtsRealtime.TtsKeepAlive { KeepAlive = true },
                        cancellationTokenSource.Token);
                }

                await client.SendTtsTextAsync(
                    new TtsRealtime.TtsText
                    {
                        StreamId = streamId,
                        Text = textChunks[index],
                        TextEnd = index == textChunks.Count - 1,
                    },
                    cancellationTokenSource.Token);
            }

            return await CollectRealtimeTtsResultAsync(
                client: client,
                streamId: streamId,
                cancellationToken: cancellationTokenSource.Token);
        }
        catch (OperationCanceledException) when (cancellationTokenSource.IsCancellationRequested)
        {
            throw new AssertInconclusiveException("Timed out waiting for Soniox realtime TTS smoke response.");
        }
    }

    private static async Task<RealtimeTtsSessionResult> CollectRealtimeTtsResultAsync(
        TtsRealtime.SonioxTtsRealtimeClient client,
        string streamId,
        CancellationToken cancellationToken)
    {
        var audioBytes = 0;
        var audioEnded = false;
        var characterTimestampCount = 0;

        await foreach (var serverEvent in client.ReceiveUpdatesAsync(cancellationToken))
        {
            if (serverEvent.IsTtsError)
            {
                ThrowForRealtimeTtsError(serverEvent.PickTtsError());
            }

            if (serverEvent.IsTtsAudio)
            {
                var audio = serverEvent.PickTtsAudio();
                if (!string.Equals(audio.StreamId, streamId, StringComparison.Ordinal))
                {
                    continue;
                }

                if (audio.Audio is { Length: > 0 } chunk)
                {
                    audioBytes += Convert.FromBase64String(chunk).Length;
                }

                audioEnded |= audio.AudioEnd == true;
                characterTimestampCount += audio.Timestamps?.Characters?.Count ?? 0;
                continue;
            }

            if (serverEvent.IsTtsTerminated)
            {
                var terminated = serverEvent.PickTtsTerminated();
                if (string.Equals(terminated.StreamId, streamId, StringComparison.Ordinal))
                {
                    return new RealtimeTtsSessionResult(
                        AudioBytes: audioBytes,
                        AudioEnded: audioEnded,
                        CharacterTimestampCount: characterTimestampCount,
                        Terminated: terminated.Terminated == true);
                }
            }
        }

        return new RealtimeTtsSessionResult(
            AudioBytes: audioBytes,
            AudioEnded: audioEnded,
            CharacterTimestampCount: characterTimestampCount,
            Terminated: false);
    }

    private static void ThrowForRealtimeTtsError(TtsRealtime.TtsError error)
    {
        var message = $"Soniox realtime TTS returned {error.ErrorCode} ({error.ErrorType}): {error.ErrorMessage}";
        if (IsRealtimeTtsEnvironmentError(error))
        {
            throw new AssertInconclusiveException(message);
        }

        throw new AssertFailedException(message);
    }

    private static bool IsRealtimeTtsEnvironmentError(TtsRealtime.TtsError error)
    {
        if (error.ErrorCode is 401 or 402 or 403 or 408 or 429 or 503)
        {
            return true;
        }

        return error.ErrorType is
            "unauthenticated" or
            "organization_balance_exhausted" or
            "organization_monthly_budget_exhausted" or
            "project_monthly_budget_exhausted" or
            "temp_api_key_session_expired" or
            "request_timeout" or
            "limit_exceeded" or
            "service_unavailable";
    }

    private readonly record struct RealtimeTtsSessionResult(
        int AudioBytes,
        bool AudioEnded,
        int CharacterTimestampCount,
        bool Terminated);
}

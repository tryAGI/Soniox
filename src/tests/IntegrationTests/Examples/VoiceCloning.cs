/*
order: 40
title: Voice cloning with Text-to-Speech
slug: voice-cloning

Creates a Soniox voice clone from a short reference clip, waits until it is
ready for the current TTS model, then uses the cloned voice ID in a REST
Text-to-Speech request.

Set `SONIOX_VOICE_CLONE_AUDIO_PATH` to a clear speech sample you have the
rights and consent to clone. Soniox accepts reference clips up to 20 seconds.
*/

namespace Soniox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_VoiceCloning()
    {
        var audioPath =
            Environment.GetEnvironmentVariable("SONIOX_VOICE_CLONE_AUDIO_PATH") is { Length: > 0 } path ? path :
            throw new AssertInconclusiveException("SONIOX_VOICE_CLONE_AUDIO_PATH environment variable is not found.");

        using var client = GetAuthenticatedClient();
        await using var referenceAudio = System.IO.File.OpenRead(audioPath);

        var voice = await client.Voices.CreateVoiceAsync(
            name: $"sdk-example-{Guid.NewGuid():N}",
            file: referenceAudio,
            filename: System.IO.Path.GetFileName(audioPath));

        try
        {
            voice = await WaitForVoiceReadyAsync(
                client: client,
                voiceId: voice.Id,
                model: SonioxClient.DefaultTtsModel);

            var audio = await client.GenerateSpeechAsync(
                text: "Hello from a cloned Soniox voice.",
                voice: voice.Id.ToString(),
                language: "en",
                audioFormat: "wav",
                sampleRate: 24000);

            audio.Should().NotBeEmpty();
        }
        finally
        {
            await client.Voices.DeleteVoiceAsync(voice.Id);
        }
    }

    private static async Task<Voice> WaitForVoiceReadyAsync(
        SonioxClient client,
        Guid voiceId,
        string model)
    {
        var deadline = DateTimeOffset.UtcNow.AddSeconds(30);
        var voice = await client.Voices.GetVoiceAsync(voiceId);

        while (DateTimeOffset.UtcNow < deadline)
        {
            var modelStatus = voice.Models.FirstOrDefault(item => item.Model == model);
            if (modelStatus?.Status is VoiceModelStatus.Ready)
            {
                return voice;
            }

            if (modelStatus?.Status is VoiceModelStatus.Failed)
            {
                throw new InvalidOperationException(
                    $"Voice {voiceId} failed for model {model}: {modelStatus.ErrorType} - {modelStatus.ErrorMessage}");
            }

            await Task.Delay(1000);
            voice = await client.Voices.GetVoiceAsync(voiceId);
        }

        throw new TimeoutException($"Voice {voiceId} was not ready for model {model} within 30 seconds.");
    }
}

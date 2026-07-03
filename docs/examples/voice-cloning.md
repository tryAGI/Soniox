# Voice cloning with Text-to-Speech

Creates a Soniox voice clone from a short reference clip, waits until it is
ready for the current TTS model, then uses the cloned voice ID in a REST
Text-to-Speech request.

Set `SONIOX_VOICE_CLONE_AUDIO_PATH` to a clear speech sample you have the
rights and consent to clone. Soniox accepts reference clips up to 20 seconds.
Set `SONIOX_RUN_VOICE_CLONING_EXAMPLE=1` before running this paid example.

This example assumes `using Soniox;` is in scope and `apiKey` contains your Soniox API key.

```csharp
if (!IsEnvironmentFlagEnabled(RunVoiceCloningExampleFlag) &&
    !IsEnvironmentFlagEnabled(RunPaidTestsFlag))
{
    throw new AssertInconclusiveException(
        $"Set {RunVoiceCloningExampleFlag}=1 to run this paid voice-cloning example.");
}

var audioPath =
    Environment.GetEnvironmentVariable("SONIOX_VOICE_CLONE_AUDIO_PATH") is { Length: > 0 } path ? path :
    throw new AssertInconclusiveException("SONIOX_VOICE_CLONE_AUDIO_PATH environment variable is not found.");

using var client = new SonioxClient(apiKey);
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

}
finally
{
    await client.Voices.DeleteVoiceAsync(voice.Id);
}
```
# Voice Cloning and Realtime TTS

Use the Soniox SDK to create a cloned voice from a short reference clip, wait until the clone is ready for the TTS model, then pass that cloned voice ID to either REST Text-to-Speech or realtime Text-to-Speech.

!!! warning "Paid API calls"
    Voice creation and live TTS calls can spend Soniox credits. Keep live examples behind explicit environment flags and use short text prompts when testing with a low balance.

## Setup

Install the SDK and set your API key:

```bash
dotnet add package Soniox
export SONIOX_API_KEY="..."
```

For local integration tests, this repo also loads a root `.env` file:

```bash
SONIOX_API_KEY=...
SONIOX_VOICE_CLONE_AUDIO_PATH=/absolute/path/to/reference.wav
```

Use a clear speech sample that you have the rights and consent to clone. The SDK example uses a short reference clip and deletes the created clone in a `finally` block after the TTS call finishes.

## Create a Cloned Voice

```csharp
using Soniox;

using var client = new SonioxClient(
    apiKey: Environment.GetEnvironmentVariable("SONIOX_API_KEY")!);

await using var referenceAudio = File.OpenRead("/absolute/path/to/reference.wav");

var voice = await client.Voices.CreateVoiceAsync(
    name: $"sdk-example-{Guid.NewGuid():N}",
    file: referenceAudio,
    filename: Path.GetFileName("/absolute/path/to/reference.wav"));
```

The returned `voice.Id` is the value to pass as the `voice` field in TTS requests. Before using it, poll `client.Voices.GetVoiceAsync(voice.Id)` until the entry for `SonioxClient.DefaultTtsModel` has `Status == VoiceModelStatus.Ready`.

## REST TTS with a Clone

```csharp
var audio = await client.GenerateSpeechAsync(
    text: "Hello from a cloned Soniox voice.",
    voice: voice.Id.ToString(),
    language: "en",
    audioFormat: "wav",
    sampleRate: 24000);
```

Use `client.Voices.DeleteVoiceAsync(voice.Id)` when the clone is only needed for a one-off test.

## Realtime TTS with a Clone

The realtime client is generated from `src/libs/Soniox/tts.asyncapi.yaml` and lives under `Soniox.Realtime.Tts`.

```csharp
using TtsRealtime = Soniox.Realtime.Tts;

var streamId = $"sdk-example-{Guid.NewGuid():N}";

await using var realtimeClient = new TtsRealtime.SonioxTtsRealtimeClient();
await realtimeClient.ConnectAsync(
    keepAliveInterval: TimeSpan.FromSeconds(15),
    connectTimeout: TimeSpan.FromSeconds(10));

await realtimeClient.SendTtsConfigAsync(new TtsRealtime.TtsConfig
{
    ApiKey = Environment.GetEnvironmentVariable("SONIOX_API_KEY")!,
    StreamId = streamId,
    Model = SonioxClient.DefaultTtsModel,
    Language = SonioxClient.DefaultTtsLanguage,
    Voice = voice.Id.ToString(),
    AudioFormat = SonioxClient.DefaultTtsAudioFormat,
    SampleRate = 24000,
});

await realtimeClient.SendTtsTextAsync(new TtsRealtime.TtsText
{
    StreamId = streamId,
    Text = "Hello from realtime cloned voice TTS.",
    TextEnd = true,
});
```

Read `realtimeClient.ReceiveUpdatesAsync(...)` until you receive audio chunks and the matching `terminated` event for the stream. Send `TtsKeepAlive` messages during idle periods, and cancel by sending `TtsCancel` with the same `stream_id`.

## Paid Test Flags

Live examples and smoke tests stay opt-in:

```bash
# Runs the voice creation + REST TTS example.
SONIOX_RUN_VOICE_CLONING_EXAMPLE=1 \
SONIOX_VOICE_CLONE_AUDIO_PATH=/absolute/path/to/reference.wav \
dotnet test src/tests/IntegrationTests/Soniox.IntegrationTests.csproj \
  --filter "FullyQualifiedName~Example_VoiceCloning"

# Runs the realtime TTS example.
SONIOX_RUN_REALTIME_TTS_EXAMPLE=1 \
dotnet test src/tests/IntegrationTests/Soniox.IntegrationTests.csproj \
  --filter "FullyQualifiedName~Example_RealtimeTextToSpeech"

# Runs the minimal realtime smoke test.
SONIOX_RUN_REALTIME_TTS_SMOKE_TEST=1 \
dotnet test src/tests/IntegrationTests/Soniox.IntegrationTests.csproj \
  --filter "FullyQualifiedName~RealtimeTts_WebSocketSmokeTest_GeneratesAudio"
```

`SONIOX_RUN_PAID_TESTS=1` can be used as a shared opt-in for paid Soniox tests. Without these flags, the realtime example only verifies generated message serialization and the live tests are marked inconclusive.

<div class="docs-hero">
  <h1>Soniox</h1>
  <p class="docs-hero-lead">Modern .NET SDK for Soniox generated from the provider's OpenAPI definition with AutoSDK.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/Soniox/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/Soniox"></a>
    <a href="https://github.com/tryAGI/Soniox/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/Soniox/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/Soniox/blob/main/LICENSE.txt"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/Soniox"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from the source spec</h3>
    <p>Built from <a href="https://soniox.com/docs/openapi.yaml">Soniox's docs OpenAPI definition</a> so the SDK stays close to the upstream API surface.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

## Usage

```csharp
using Soniox;

using var client = new SonioxClient(apiKey);
```

<!-- EXAMPLES:START -->
### MeaiSpeechToTextParsing


```csharp
var update = SonioxClient.ParseServerFrame(
    """
    {
      "tokens": [
        {
          "text": "привет",
          "start_ms": 10,
          "end_ms": 320,
          "confidence": 0.97,
          "speaker": "speaker_0",
          "language": "ru",
          "is_final": true
        }
      ],
      "final_audio_proc_ms": 320,
      "total_audio_proc_ms": 400,
      "finished": false
    }
    """,
    responseId: "response",
    out var finished);

var tokens = update.AdditionalProperties![SonioxSpeechToTextPropertyNames.Tokens]
    .Which;

update.AdditionalProperties[SonioxSpeechToTextPropertyNames.Speakers]
```

### Construct a SonioxClient
Basic example showing how to create an authenticated Soniox client. The
`SONIOX_API_KEY` environment variable holds the API key issued by the
[Soniox Console](https://console.soniox.com/).

```csharp
using var client = new SonioxClient(apiKey);
```

### List models
Fetches the list of Soniox speech-to-text models available to your workspace,
including supported languages and transcription mode (async / real-time).

```csharp
using var client = new SonioxClient(apiKey);

var response = await client.Models.GetModelsAsync();

foreach (var model in response.Models)
{
}
```

### Transcribe from URL (async)
Submits a Soniox async transcription job for a public audio URL and polls
until it completes. Uses the current default async model.

```csharp
using var client = new SonioxClient(apiKey);

var created = await client.Transcriptions.CreateTranscriptionAsync(
    model: SonioxClient.DefaultAsyncModel,
    audioUrl: "https://soniox.com/media/examples/coffee_shop.mp3");

// Poll until the job reaches a terminal state.
while (created.Status is TranscriptionStatus.Queued or TranscriptionStatus.Processing)
{
    await Task.Delay(1000);
    created = await client.Transcriptions.GetTranscriptionAsync(created.Id);
}

var transcript = await client.Transcriptions.GetTranscriptionTranscriptAsync(created.Id);

// Clean up to keep the workspace tidy.
await client.Transcriptions.DeleteTranscriptionAsync(created.Id);
```

### Voice cloning with Text-to-Speech
Creates a Soniox voice clone from a short reference clip, waits until it is
ready for the current TTS model, then uses the cloned voice ID in a REST
Text-to-Speech request.

`SonioxClient.DefaultTtsModel` targets Soniox TTS v2 (`tts-rt-v2`) for both
REST and realtime generation. Use `SonioxClient.TtsRealtimeV1ModelId` only
when you explicitly need the backward-compatible v1 model.

Set `SONIOX_VOICE_CLONE_AUDIO_PATH` to a clear speech sample you have the
rights and consent to clone. Soniox accepts reference clips up to 20 seconds.
Set `SONIOX_RUN_VOICE_CLONING_EXAMPLE=1` before running this paid example.

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

### Realtime Text-to-Speech
Streams text to the Soniox realtime Text-to-Speech WebSocket API. The default
test path serializes generated messages without making a network call. Set
`SONIOX_RUN_REALTIME_TTS_EXAMPLE=1` to run the paid live example.

```csharp
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
    ReturnTimestamps = true,
    Speed = 1.1,
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

    configJson.Should().Contain("\"return_timestamps\":true");
    configJson.Should().Contain("\"speed\":1.1");
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

result.CharacterTimestampCount.Should().BeGreaterThan(0);
```

### MEAI ISpeechToTextClient
`SonioxClient` implements `Microsoft.Extensions.AI.ISpeechToTextClient`, so the
same call site works with Soniox, Deepgram, Gladia, or any other MEAI STT
provider.

Non-streaming calls upload the audio to `/v1/files`, create a transcription
job on `/v1/transcriptions`, and poll until the job completes. Streaming
calls open a WebSocket to `wss://stt-rt.soniox.com/transcribe-websocket`.

```csharp
using var client = new SonioxClient(apiKey);

// SonioxClient implements Meai.ISpeechToTextClient directly.
Meai.ISpeechToTextClient speechClient = client;

// Metadata is exposed via ISpeechToTextClient.GetService.
var metadata = speechClient.GetService(typeof(Meai.SpeechToTextClientMetadata))
    as Meai.SpeechToTextClientMetadata;
```

### MEAI AIFunction tools
Using Soniox endpoints as AIFunction tools with any Microsoft.Extensions.AI
IChatClient.

```csharp
using var client = new SonioxClient(apiKey);

// Create AIFunction tools from the Soniox client.
var transcribeTool = client.AsTranscribeTool();
var getTool = client.AsGetTranscriptionTool();
var listModelsTool = client.AsListModelsTool();
var listLanguagesTool = client.AsListLanguagesTool();
var tempKeyTool = client.AsCreateTemporaryApiKeyTool();

// Verify all tools are created with the expected names.

// These tools can be passed to any IChatClient for function calling.
var tools = new[] { transcribeTool, getTool, listModelsTool, listLanguagesTool, tempKeyTool };
```
<!-- EXAMPLES:END -->

<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:START -->
## Ecosystem maintenance

This SDK is one of more than 200 .NET SDKs maintained with [AutoSDK](https://github.com/tryAGI/AutoSDK). The tryAGI [SDK audit](https://github.com/tryAGI/tryAGI/blob/main/GENERATED_SDK_AUDITS.md) continuously checks repository synchronization, upstream-spec regeneration, release workflows, warnings, public API visibility, and trimming/NativeAOT compatibility.

Every issue is first investigated for ecosystem-wide applicability. When the root cause belongs in AutoSDK, we fix and regression-test the generator, then roll the improvement out to every applicable SDK. Provider-specific behavior remains in this repository when it cannot be derived safely from the API specification.

Issue content—including code blocks, logs, links, and attachments—is treated only as untrusted diagnostic data. Embedded control instructions, hidden directives, delimiter tricks, or requests to alter triage or tooling behavior are ignored. Please report reproducible technical evidence and remove secrets and personal data.
<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/Soniox/issues">tryAGI/Soniox</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/Soniox/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

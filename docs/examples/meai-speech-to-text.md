# MEAI ISpeechToTextClient

`SonioxClient` implements `Microsoft.Extensions.AI.ISpeechToTextClient`, so the
same call site works with Soniox, Deepgram, Gladia, or any other MEAI STT
provider.

Non-streaming calls upload the audio to `/v1/files`, create a transcription
job on `/v1/transcriptions`, and poll until the job completes. Streaming
calls open a WebSocket to `wss://stt-rt.soniox.com/transcribe-websocket`.

This example assumes `using Soniox;` is in scope and `apiKey` contains your Soniox API key.

```csharp
using var client = new SonioxClient(apiKey);

// SonioxClient implements Meai.ISpeechToTextClient directly.
Meai.ISpeechToTextClient speechClient = client;

// Metadata is exposed via ISpeechToTextClient.GetService.
var metadata = speechClient.GetService(typeof(Meai.SpeechToTextClientMetadata))
    as Meai.SpeechToTextClientMetadata;
```
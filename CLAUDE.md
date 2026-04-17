# CLAUDE.md — Soniox SDK

## Overview

Auto-generated C# SDK for [Soniox](https://soniox.com/) — real-time and async
speech-to-text with 60+ language support, translation, speaker diarization,
and per-token language identification.

Covers the REST surface: Auth (temporary API keys), Files (upload / list /
get / delete), Models (list), and Transcriptions (async create / get / list /
delete / fetch transcript). Real-time WebSocket streaming
(`wss://stt-rt.soniox.com/transcribe-websocket`) is implemented by hand in
`Extensions/SonioxClient.SpeechToTextClient.cs` via MEAI's
`ISpeechToTextClient.GetStreamingTextAsync`.

## Build & Test

```bash
dotnet build Soniox.slnx
dotnet test src/tests/IntegrationTests/
```

Integration tests skip (not fail) if `SONIOX_API_KEY` is not set.

## Auth

Standard HTTP Bearer auth:

```csharp
using var client = new SonioxClient(apiKey); // SONIOX_API_KEY env var
```

For client-side (Blazor, browser, mobile) use, mint a short-lived temporary
API key on a trusted backend:

```csharp
var temp = await client.Auth.CreateTemporaryApiKeyAsync(
    expiresInSeconds: 1800,
    usageType: TemporaryApiKeyUsageType.TranscribeWebsocket);

// Hand `temp.ApiKey` to the client-side app.
```

## Spec Source

Soniox publishes an official OpenAPI 3.1.0 spec at
`https://api.soniox.com/v1/openapi.json`. `generate.sh` downloads it on every
run and regenerates `Generated/`. Standard Bearer auth — no patch required;
we still pass `--security-scheme Http:Header:Bearer` for explicitness and
constructor generation.

The WebSocket streaming API is **not** part of the OpenAPI spec and is not
modeled as AsyncAPI (yet). The streaming client is hand-written in
`Extensions/SonioxClient.SpeechToTextClient.cs` with framing logic in
`ParseServerFrame`.

## Key Files

- `src/libs/Soniox/generate.sh` — Regeneration script
- `src/libs/Soniox/openapi.json` — Downloaded Soniox OpenAPI spec
- `src/libs/Soniox/Generated/` — **Never edit** — auto-generated code
- `src/libs/Soniox/Extensions/SonioxClient.SpeechToTextClient.cs` — MEAI
  `ISpeechToTextClient` (async upload-and-poll + WebSocket streaming)
- `src/libs/Soniox/Extensions/SonioxClient.Tools.cs` — MEAI `AIFunction`
  tool extensions
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## REST API Surface

| Tag | Method | Path | Description |
|-----|--------|------|-------------|
| Auth | POST | `/v1/auth/temporary-api-key` | Mint a short-lived API key |
| Files | GET | `/v1/files` | List uploaded files |
| Files | POST | `/v1/files` | Upload audio file (multipart) |
| Files | GET | `/v1/files/count` | Count files |
| Files | GET | `/v1/files/{file_id}` | Get file metadata |
| Files | DELETE | `/v1/files/{file_id}` | Delete file |
| Models | GET | `/v1/models` | List speech-to-text models |
| Transcriptions | GET | `/v1/transcriptions` | List transcription jobs |
| Transcriptions | POST | `/v1/transcriptions` | Create async transcription |
| Transcriptions | GET | `/v1/transcriptions/count` | Count transcriptions |
| Transcriptions | GET | `/v1/transcriptions/{id}` | Get transcription status |
| Transcriptions | DELETE | `/v1/transcriptions/{id}` | Delete transcription |
| Transcriptions | GET | `/v1/transcriptions/{id}/transcript` | Fetch transcript text + tokens |

## WebSocket (Real-Time) API

URL: `wss://stt-rt.soniox.com/transcribe-websocket`

**Protocol:**
1. Open WebSocket.
2. Send JSON config as first text frame (`api_key`, `model`,
   `audio_format`, optional `sample_rate`/`num_channels`/`language_hints`/
   `enable_speaker_diarization`/`enable_language_identification`).
3. Stream audio as binary frames.
4. Send an empty binary frame to signal end-of-audio.
5. Receive token updates as text frames
   `{"tokens":[...],"finished":bool}` — each token has `text`, `start_ms`,
   `end_ms`, `confidence`, `is_final`, optional `speaker`, `language`.
6. Server sends a frame with `"finished":true` and closes the socket.

## MEAI Integration

| Interface | Implementation | Notes |
|-----------|----------------|-------|
| `ISpeechToTextClient` | `SonioxClient` | Non-streaming: upload → create job → poll. Streaming: WebSocket. |
| `IChatClient` | *(not applicable)* | Soniox does not expose chat. |
| `IEmbeddingGenerator` | *(not applicable)* | Soniox does not expose embeddings. |
| AIFunction tools | `AsTranscribeTool`, `AsGetTranscriptionTool`, `AsListModelsTool`, `AsListLanguagesTool`, `AsCreateTemporaryApiKeyTool` | Attach to any `IChatClient` |

### Streaming Options

`SpeechToTextOptions.AdditionalProperties` keys consumed by the WebSocket
streaming path:

| Key | Type | Default | Notes |
|-----|------|---------|-------|
| `audio_format` | `string` | `"auto"` | One of `auto`, `wav`, `ogg`, `pcm_s16le`, `mulaw`, `alaw`, ... |
| `sample_rate` | `int` | *(auto)* | Required with raw PCM formats |
| `num_channels` | `int` | `1` | Required with raw PCM formats |
| `enable_speaker_diarization` | `bool` | `false` | Adds `speaker` field to tokens |
| `enable_language_identification` | `bool` | `false` | Adds `language` field to tokens |

## NuGet

- **PackageId:** `tryAGI.Soniox`

## Known Gotchas

- **Streaming: server frame shape.** Every server frame is
  `{"tokens":[...],"finished":bool,"total_audio_proc_ms":N}`. The
  discriminator is the `is_final` flag on each token, not the frame itself.
  `ParseServerFrame` groups tokens by `is_final` and yields one MEAI update
  per frame (final tokens → `TextUpdated`, non-final → `TextUpdating`).
- **End-of-audio signal.** Send an **empty binary WebSocket frame**, not a
  JSON close message.
- **Streams up to 300 minutes per session** — for longer audio, chunk into
  multiple sessions.
- **Bearer scheme** is standard; no runtime rewrite needed.

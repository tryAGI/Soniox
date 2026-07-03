# Transcribe from URL (async)

Submits a Soniox async transcription job for a public audio URL and polls
until it completes. Uses the current default async model.

This example assumes `using Soniox;` is in scope and `apiKey` contains your Soniox API key.

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
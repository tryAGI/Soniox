# List models

Fetches the list of Soniox speech-to-text models available to your workspace,
including supported languages and transcription mode (async / real-time).

This example assumes `using Soniox;` is in scope and `apiKey` contains your Soniox API key.

```csharp
using var client = new SonioxClient(apiKey);

var response = await client.Models.GetModelsAsync();

foreach (var model in response.Models)
{
}
```
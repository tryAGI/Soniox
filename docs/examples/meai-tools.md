# MEAI AIFunction tools

Using Soniox endpoints as AIFunction tools with any Microsoft.Extensions.AI
IChatClient.

This example assumes `using Soniox;` is in scope and `apiKey` contains your Soniox API key.

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
# Construct a SonioxClient

Basic example showing how to create an authenticated Soniox client. The
`SONIOX_API_KEY` environment variable holds the API key issued by the
[Soniox Console](https://console.soniox.com/).

This example assumes `using Soniox;` is in scope and `apiKey` contains your Soniox API key.

```csharp
using var client = new SonioxClient(apiKey);
```
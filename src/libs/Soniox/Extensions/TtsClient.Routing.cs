#nullable enable

using System.Net.Http;

namespace Soniox;

/// <summary>
/// Routing fixes for generated Text-to-Speech operations.
/// </summary>
public sealed partial class TtsClient
{
    private static readonly Uri s_publicApiTtsUri = new("https://api.soniox.com/tts");
    private static readonly Uri s_ttsRestUri = new(SonioxClient.TextToSpeechRestUrl);

    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Performance",
        "CA1822:Mark members as static",
        Justification = "The generated partial method signature is instance-bound.")]
    partial void PrepareGenerateTtsRequest(
        HttpClient httpClient,
        HttpRequestMessage httpRequestMessage,
        string? xRequestId,
        CreateTTSPayload request)
    {
        if (httpRequestMessage.RequestUri is not { IsAbsoluteUri: true } requestUri ||
            !string.Equals(
                requestUri.GetLeftPart(UriPartial.Path),
                s_publicApiTtsUri.ToString(),
                StringComparison.OrdinalIgnoreCase))
        {
            return;
        }

        var builder = new UriBuilder(s_ttsRestUri)
        {
            Query = requestUri.Query.TrimStart('?'),
        };
        httpRequestMessage.RequestUri = builder.Uri;
    }
}

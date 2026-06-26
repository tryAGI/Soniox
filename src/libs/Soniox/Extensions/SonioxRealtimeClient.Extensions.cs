#nullable enable

namespace Soniox.Realtime;

/// <summary>
/// Convenience helpers for Soniox realtime WebSocket clients.
/// </summary>
public sealed partial class SonioxRealtimeClient
{
    /// <summary>
    /// Soniox realtime speech-to-text WebSocket URL.
    /// </summary>
    public const string SpeechToTextWebSocketUrl = SonioxClient.RealtimeWebSocketUrl;

    /// <summary>
    /// Connects to the Soniox realtime speech-to-text WebSocket endpoint.
    /// </summary>
    public Task ConnectSpeechToTextAsync(
        IDictionary<string, string>? additionalHeaders = null,
        IEnumerable<string>? additionalSubProtocols = null,
        TimeSpan? keepAliveInterval = null,
        TimeSpan? connectTimeout = null,
        CancellationToken cancellationToken = default)
    {
        return ConnectAsync(
            uri: new Uri(SpeechToTextWebSocketUrl),
            additionalHeaders: additionalHeaders,
            additionalSubProtocols: additionalSubProtocols,
            keepAliveInterval: keepAliveInterval,
            connectTimeout: connectTimeout,
            cancellationToken: cancellationToken);
    }
}

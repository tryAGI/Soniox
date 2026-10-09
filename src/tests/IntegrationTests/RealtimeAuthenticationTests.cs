using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Soniox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    [DataRow(false, false)]
    [DataRow(false, true)]
    [DataRow(true, false)]
    [DataRow(true, true)]
    public async Task RealtimeAuthentication_AuthenticatesUpgradeAndOmitsKeyFromConfig(
        bool textToSpeech,
        bool useSubProtocols)
    {
        const string apiKey = "snx_temp_local_test_key";
        using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(15));
        using var listener = new TcpListener(IPAddress.Loopback, 0);
        listener.Start();
        var uri = new Uri($"ws://127.0.0.1:{((IPEndPoint)listener.LocalEndpoint).Port}/realtime");
        var serverTask = CaptureRealtimeRequestAsync(listener, useSubProtocols, timeout.Token);
        var protocols = useSubProtocols ? new[] { "soniox-api-key", apiKey } : null;

        if (textToSpeech)
        {
            await using var client = useSubProtocols
                ? new Realtime.Tts.SonioxTtsRealtimeClient()
                : new Realtime.Tts.SonioxTtsRealtimeClient(apiKey);
            await client.ConnectAsync(uri, additionalSubProtocols: protocols, cancellationToken: timeout.Token);
            await client.SendTtsConfigAsync(new Realtime.Tts.TtsConfig
            {
                StreamId = "local-test",
                Model = SonioxClient.DefaultTtsModel,
                Language = "en",
                Voice = "Adrian",
                AudioFormat = "pcm_s16le",
            }, timeout.Token);
            AssertRealtimeRequest(await serverTask, apiKey, useSubProtocols, "tts-rt-v2");
        }
        else
        {
            await using var client = useSubProtocols
                ? new Realtime.SonioxRealtimeClient()
                : new Realtime.SonioxRealtimeClient(apiKey);
            await client.ConnectAsync(uri, additionalSubProtocols: protocols, cancellationToken: timeout.Token);
            await client.SendRealtimeConfigAsync(new Realtime.RealtimeConfig
            {
                Model = SonioxClient.DefaultRealtimeModel,
                AudioFormat = "auto",
            }, timeout.Token);
            AssertRealtimeRequest(await serverTask, apiKey, useSubProtocols, "stt-rt-v5");
        }
    }

    [TestMethod]
    [DataRow(false)]
    [DataRow(true)]
    public async Task RealtimeAuthentication_ReceivesUnauthenticatedErrorAfterUpgrade(bool textToSpeech)
    {
        using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(15));
        using var listener = new TcpListener(IPAddress.Loopback, 0);
        listener.Start();
        var uri = new Uri($"ws://127.0.0.1:{((IPEndPoint)listener.LocalEndpoint).Port}/realtime");
        var serverTask = CaptureRealtimeRequestAsync(listener, false, timeout.Token, emitAuthenticationError: true);

        if (textToSpeech)
        {
            await using var client = new Realtime.Tts.SonioxTtsRealtimeClient("invalid-test-key");
            await client.ConnectAsync(uri, cancellationToken: timeout.Token);
            await client.SendTtsConfigAsync(new Realtime.Tts.TtsConfig
            {
                StreamId = "local-test",
                Model = SonioxClient.DefaultTtsModel,
                Language = "en",
                Voice = "Adrian",
                AudioFormat = "pcm_s16le",
            }, timeout.Token);
            await foreach (var frame in client.ReceiveUpdatesAsync(timeout.Token))
            {
                frame.IsTtsError.Should().BeTrue();
                frame.PickTtsError().ErrorCode.Should().Be(401);
                frame.PickTtsError().ErrorType.Should().Be("unauthenticated");
                await serverTask;
                return;
            }
        }
        else
        {
            await using var client = new Realtime.SonioxRealtimeClient("invalid-test-key");
            await client.ConnectAsync(uri, cancellationToken: timeout.Token);
            await client.SendRealtimeConfigAsync(new Realtime.RealtimeConfig
            {
                Model = SonioxClient.DefaultRealtimeModel,
                AudioFormat = "auto",
            }, timeout.Token);
            await foreach (var frame in client.ReceiveUpdatesAsync(timeout.Token))
            {
                frame.IsRealtimeError.Should().BeTrue();
                frame.PickRealtimeError().ErrorCode.Should().Be(401);
                await serverTask;
                return;
            }
        }

        Assert.Fail("Expected an authentication error frame after a successful WebSocket upgrade.");
    }

    private static void AssertRealtimeRequest(
        (Dictionary<string, string> Headers, string Config) request,
        string apiKey,
        bool useSubProtocols,
        string model)
    {
        if (useSubProtocols)
        {
            request.Headers.Should().NotContainKey("Authorization");
            request.Headers["Sec-WebSocket-Protocol"].Split(',').Select(x => x.Trim())
                .Should().Equal("soniox-api-key", apiKey);
        }
        else
        {
            request.Headers.Should().NotContainKey("Sec-WebSocket-Protocol");
            request.Headers["Authorization"].Should().BeEquivalentTo($"Bearer {apiKey}");
        }

        using var config = JsonDocument.Parse(request.Config);
        config.RootElement.TryGetProperty("api_key", out _).Should().BeFalse();
        config.RootElement.GetProperty("model").GetString().Should().Be(model);
        request.Config.Should().NotContain(apiKey);
    }

    private static async Task<(Dictionary<string, string> Headers, string Config)> CaptureRealtimeRequestAsync(
        TcpListener listener,
        bool useSubProtocols,
        CancellationToken cancellationToken,
        bool emitAuthenticationError = false)
    {
        using var connection = await listener.AcceptTcpClientAsync(cancellationToken);
        await using var stream = connection.GetStream();
        var request = new StringBuilder();
        var singleByte = new byte[1];
        while (!request.ToString().EndsWith("\r\n\r\n", StringComparison.Ordinal))
        {
            if (request.Length > 8192 || await stream.ReadAsync(singleByte, cancellationToken) == 0)
            {
                throw new InvalidOperationException("Invalid local WebSocket upgrade request.");
            }
            request.Append((char)singleByte[0]);
        }

        var headers = request.ToString().Split("\r\n")
            .Where(line => line.Contains(':'))
            .Select(line => line.Split(':', 2))
            .ToDictionary(parts => parts[0], parts => parts[1].Trim(), StringComparer.OrdinalIgnoreCase);
#pragma warning disable CA5350 // SHA-1 is mandated by the WebSocket upgrade protocol, not used for security.
        var accept = Convert.ToBase64String(SHA1.HashData(
            Encoding.ASCII.GetBytes(headers["Sec-WebSocket-Key"] + "258EAFA5-E914-47DA-95CA-C5AB0DC85B11")));
#pragma warning restore CA5350
        var protocolHeader = useSubProtocols ? "Sec-WebSocket-Protocol: soniox-api-key\r\n" : "";
        await stream.WriteAsync(Encoding.ASCII.GetBytes(
            $"HTTP/1.1 101 Switching Protocols\r\nUpgrade: websocket\r\nConnection: Upgrade\r\nSec-WebSocket-Accept: {accept}\r\n{protocolHeader}\r\n"), cancellationToken);
        using var socket = WebSocket.CreateFromStream(stream, isServer: true,
            subProtocol: useSubProtocols ? "soniox-api-key" : null, keepAliveInterval: Timeout.InfiniteTimeSpan);
        using var payload = new MemoryStream();
        var buffer = new byte[4096];
        ValueWebSocketReceiveResult result;
        do
        {
            result = await socket.ReceiveAsync(buffer.AsMemory(), cancellationToken);
            result.MessageType.Should().Be(WebSocketMessageType.Text);
            payload.Write(buffer, 0, result.Count);
        } while (!result.EndOfMessage);
        if (emitAuthenticationError)
        {
            await socket.SendAsync(Encoding.UTF8.GetBytes(
                """{"error_code":401,"error_type":"unauthenticated","error_message":"Invalid test key"}"""),
                WebSocketMessageType.Text, endOfMessage: true, cancellationToken);
        }
        return (headers, Encoding.UTF8.GetString(payload.ToArray()));
    }
}

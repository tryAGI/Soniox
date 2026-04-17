/*
order: 50
title: MEAI ISpeechToTextClient
slug: meai-speech-to-text

`SonioxClient` implements `Microsoft.Extensions.AI.ISpeechToTextClient`, so the
same call site works with Soniox, Deepgram, Gladia, or any other MEAI STT
provider.

Non-streaming calls upload the audio to `/v1/files`, create a transcription
job on `/v1/transcriptions`, and poll until the job completes. Streaming
calls open a WebSocket to `wss://stt-rt.soniox.com/transcribe-websocket`.
*/

#pragma warning disable MEAI001 // MEAI speech-to-text abstractions are preview-gated.

using Meai = Microsoft.Extensions.AI;

namespace Soniox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_AsMeaiSpeechToTextClient()
    {
        using var client = GetAuthenticatedClient();

        //// SonioxClient implements Meai.ISpeechToTextClient directly.
        Meai.ISpeechToTextClient speechClient = client;

        //// Metadata is exposed via ISpeechToTextClient.GetService.
        var metadata = speechClient.GetService(typeof(Meai.SpeechToTextClientMetadata))
            as Meai.SpeechToTextClientMetadata;

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be("soniox");
    }
}

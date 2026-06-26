namespace Soniox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void WellKnownModelIds_ExposeCurrentSonioxModels()
    {
        SonioxClient.SttRealtimeV5ModelId.Should().Be("stt-rt-v5");
        SonioxClient.SttAsyncV5ModelId.Should().Be("stt-async-v5");
        SonioxClient.SttRealtimeV4ModelId.Should().Be("stt-rt-v4");
        SonioxClient.SttAsyncV4ModelId.Should().Be("stt-async-v4");
        SonioxClient.SttRealtimeV3AliasModelId.Should().Be("stt-rt-v3");
        SonioxClient.SttAsyncV3AliasModelId.Should().Be("stt-async-v3");
        SonioxClient.TtsRealtimeV1ModelId.Should().Be("tts-rt-v1");
        SonioxClient.TtsRealtimeV1PreviewAliasModelId.Should().Be("tts-rt-v1-preview");

        SonioxClient.DefaultRealtimeModel.Should().Be(SonioxClient.SttRealtimeV5ModelId);
        SonioxClient.DefaultRealtimeModelId.Should().Be(SonioxClient.DefaultRealtimeModel);
        SonioxClient.DefaultAsyncModel.Should().Be(SonioxClient.SttAsyncV5ModelId);
        SonioxClient.DefaultAsyncModelId.Should().Be(SonioxClient.DefaultAsyncModel);
    }
}

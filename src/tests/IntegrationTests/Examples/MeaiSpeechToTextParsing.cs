#pragma warning disable MEAI001

using Meai = Microsoft.Extensions.AI;

namespace Soniox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_ParseRealtimeFramePreservesTokenMetadata()
    {
        var update = SonioxClient.ParseServerFrame(
            """
            {
              "tokens": [
                {
                  "text": "привет",
                  "start_ms": 10,
                  "end_ms": 320,
                  "confidence": 0.97,
                  "speaker": "speaker_0",
                  "language": "ru",
                  "is_final": true
                }
              ],
              "final_audio_proc_ms": 320,
              "total_audio_proc_ms": 400,
              "finished": false
            }
            """,
            responseId: "response",
            out var finished);

        finished.Should().BeFalse();
        update.Should().NotBeNull();
        update!.Kind.Should().Be(Meai.SpeechToTextResponseUpdateKind.TextUpdated);
        update.Text.Should().Be("привет");
        update.StartTime.Should().Be(TimeSpan.FromMilliseconds(10));
        update.EndTime.Should().Be(TimeSpan.FromMilliseconds(320));

        var tokens = update.AdditionalProperties![SonioxSpeechToTextPropertyNames.Tokens]
            .Should().BeAssignableTo<IReadOnlyList<SonioxRealtimeToken>>()
            .Which;
        tokens.Should().ContainSingle();
        tokens[0].Speaker.Should().Be("speaker_0");
        tokens[0].Language.Should().Be("ru");

        update.AdditionalProperties[SonioxSpeechToTextPropertyNames.Speakers]
            .Should().BeAssignableTo<string[]>()
            .Which.Should().Equal("speaker_0");
    }
}

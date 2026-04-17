/*
order: 30
title: Transcribe from URL (async)
slug: transcribe-from-url

Submits a Soniox async transcription job for a public audio URL and polls
until it completes. Uses the `stt-async-preview` model.
*/

namespace Soniox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_TranscribeFromUrl()
    {
        using var client = GetAuthenticatedClient();

        var created = await client.Transcriptions.CreateTranscriptionAsync(
            model: SonioxClient.DefaultAsyncModel,
            audioUrl: "https://soniox.com/media/examples/coffee_shop.mp3");

        created.Id.Should().NotBe(Guid.Empty);
        created.Model.Should().Be(SonioxClient.DefaultAsyncModel);

        //// Poll until the job reaches a terminal state.
        while (created.Status is TranscriptionStatus.Queued or TranscriptionStatus.Processing)
        {
            await Task.Delay(1000);
            created = await client.Transcriptions.GetTranscriptionAsync(created.Id);
        }

        created.Status.Should().Be(TranscriptionStatus.Completed);

        var transcript = await client.Transcriptions.GetTranscriptionTranscriptAsync(created.Id);
        transcript.Text.Should().NotBeNullOrEmpty();
        transcript.Tokens.Should().NotBeNullOrEmpty();

        //// Clean up to keep the workspace tidy.
        await client.Transcriptions.DeleteTranscriptionAsync(created.Id);
    }
}

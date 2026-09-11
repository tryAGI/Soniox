/*
order: 25
title: Browse Text-to-Speech voices
slug: list-tts-voices

Lists Soniox's shared Text-to-Speech voices for the current model. Filters can be
combined, and every returned voice includes gender, age, accent, use-case, and
style metadata. Follow `NextPageCursor` to continue through the catalog.
*/

namespace Soniox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListTtsVoices()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.TtsModels.GetSharedVoicesAsync(
            model: SonioxClient.DefaultTtsModel,
            useCase: ["conversational"],
            style: ["warm"],
            limit: 20);

        response.Voices.Should().NotBeEmpty();
        foreach (var voice in response.Voices)
        {
            voice.Id.Should().NotBeNullOrEmpty();
            voice.Description.Should().NotBeNullOrEmpty();
            voice.Accent.Should().NotBeNullOrEmpty();
            voice.UseCase.Should().Contain("conversational");
            voice.Style.Should().Contain("warm");
        }

        if (response.NextPageCursor is { Length: > 0 } cursor)
        {
            var nextPage = await client.TtsModels.GetSharedVoicesAsync(
                model: SonioxClient.DefaultTtsModel,
                useCase: ["conversational"],
                style: ["warm"],
                limit: 20,
                cursor: cursor);

            nextPage.Voices.Should().NotBeNull();
        }
    }
}

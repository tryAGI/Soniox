/*
order: 20
title: List models
slug: list-models

Fetches the list of Soniox speech-to-text models available to your workspace,
including supported languages and transcription mode (async / real-time).
*/

namespace Soniox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListModels()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.Models.GetModelsAsync();

        response.Models.Should().NotBeNull();
        response.Models.Should().NotBeEmpty();

        foreach (var model in response.Models)
        {
            model.Id.Should().NotBeNullOrEmpty();
            model.Name.Should().NotBeNullOrEmpty();
            model.Languages.Should().NotBeNull();
        }
    }
}

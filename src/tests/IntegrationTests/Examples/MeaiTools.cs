/*
order: 60
title: MEAI AIFunction tools
slug: meai-tools

Using Soniox endpoints as AIFunction tools with any Microsoft.Extensions.AI
IChatClient.
*/

namespace Soniox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_CreateTools()
    {
        using var client = GetAuthenticatedClient();

        //// Create AIFunction tools from the Soniox client.
        var transcribeTool = client.AsTranscribeTool();
        var getTool = client.AsGetTranscriptionTool();
        var listModelsTool = client.AsListModelsTool();
        var listLanguagesTool = client.AsListLanguagesTool();
        var tempKeyTool = client.AsCreateTemporaryApiKeyTool();

        //// Verify all tools are created with the expected names.
        transcribeTool.Name.Should().Be("Soniox_Transcribe");
        getTool.Name.Should().Be("Soniox_GetTranscription");
        listModelsTool.Name.Should().Be("Soniox_ListModels");
        listLanguagesTool.Name.Should().Be("Soniox_ListLanguages");
        tempKeyTool.Name.Should().Be("Soniox_CreateTemporaryApiKey");

        //// These tools can be passed to any IChatClient for function calling.
        var tools = new[] { transcribeTool, getTool, listModelsTool, listLanguagesTool, tempKeyTool };
        tools.Should().HaveCount(5);
    }
}

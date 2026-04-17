/*
order: 10
title: Construct a SonioxClient
slug: generate

Basic example showing how to create an authenticated Soniox client. The
`SONIOX_API_KEY` environment variable holds the API key issued by the
[Soniox Console](https://console.soniox.com/).
*/

namespace Soniox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_Generate()
    {
        using var client = GetAuthenticatedClient();

        client.Should().NotBeNull();
        client.BaseUri?.ToString().Should().Be("https://api.soniox.com/");
    }
}

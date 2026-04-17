namespace Soniox.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static SonioxClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SONIOX_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("SONIOX_API_KEY environment variable is not found.");

        var client = new SonioxClient(apiKey);
        
        return client;
    }
}

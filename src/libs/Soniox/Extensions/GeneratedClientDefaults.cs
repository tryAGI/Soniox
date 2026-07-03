#nullable enable

#pragma warning disable CA1822 // Generated partial hooks are instance-bound by design.

using System.Net.Http;

namespace Soniox;

internal static class SonioxGeneratedClientDefaults
{
    public static void UseDefaultBaseAddress(HttpClient client, string defaultBaseUrl)
    {
        client.BaseAddress ??= new Uri(defaultBaseUrl);
    }
}

public sealed partial class SonioxClient
{
    partial void Initialized(HttpClient client)
    {
        SonioxGeneratedClientDefaults.UseDefaultBaseAddress(client, DefaultBaseUrl);
    }
}

public sealed partial class AuthClient
{
    partial void Initialized(HttpClient client)
    {
        SonioxGeneratedClientDefaults.UseDefaultBaseAddress(client, DefaultBaseUrl);
    }
}

public sealed partial class ConcurrencyLimitsClient
{
    partial void Initialized(HttpClient client)
    {
        SonioxGeneratedClientDefaults.UseDefaultBaseAddress(client, DefaultBaseUrl);
    }
}

public sealed partial class FilesClient
{
    partial void Initialized(HttpClient client)
    {
        SonioxGeneratedClientDefaults.UseDefaultBaseAddress(client, DefaultBaseUrl);
    }
}

public sealed partial class ModelsClient
{
    partial void Initialized(HttpClient client)
    {
        SonioxGeneratedClientDefaults.UseDefaultBaseAddress(client, DefaultBaseUrl);
    }
}

public sealed partial class TranscriptionsClient
{
    partial void Initialized(HttpClient client)
    {
        SonioxGeneratedClientDefaults.UseDefaultBaseAddress(client, DefaultBaseUrl);
    }
}

public sealed partial class TtsClient
{
    partial void Initialized(HttpClient client)
    {
        SonioxGeneratedClientDefaults.UseDefaultBaseAddress(client, DefaultBaseUrl);
    }
}

public sealed partial class TtsModelsClient
{
    partial void Initialized(HttpClient client)
    {
        SonioxGeneratedClientDefaults.UseDefaultBaseAddress(client, DefaultBaseUrl);
    }
}

public sealed partial class UsageLogsClient
{
    partial void Initialized(HttpClient client)
    {
        SonioxGeneratedClientDefaults.UseDefaultBaseAddress(client, DefaultBaseUrl);
    }
}

public sealed partial class VoicesClient
{
    partial void Initialized(HttpClient client)
    {
        SonioxGeneratedClientDefaults.UseDefaultBaseAddress(client, DefaultBaseUrl);
    }
}

#pragma warning restore CA1822

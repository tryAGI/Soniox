namespace Soniox.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static readonly object s_environmentLoadGate = new();
    private static bool s_environmentLoaded;

    private static SonioxClient GetAuthenticatedClient()
    {
        var apiKey = GetRequiredEnvironmentVariable("SONIOX_API_KEY");

        var client = new SonioxClient(apiKey);
        
        return client;
    }

    private static string GetRequiredEnvironmentVariable(string name)
    {
        return GetOptionalEnvironmentVariable(name) is { Length: > 0 } value
            ? value
            : throw new AssertInconclusiveException($"{name} environment variable is not found.");
    }

    private static string? GetOptionalEnvironmentVariable(string name)
    {
        LoadDotEnv();

        return Environment.GetEnvironmentVariable(name) is { Length: > 0 } value
            ? value
            : null;
    }

    private static bool IsEnvironmentFlagEnabled(string name)
    {
        return GetOptionalEnvironmentVariable(name) is { } value &&
               (string.Equals(value, "1", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(value, "true", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(value, "yes", StringComparison.OrdinalIgnoreCase));
    }

    private static void LoadDotEnv()
    {
        if (s_environmentLoaded)
        {
            return;
        }

        lock (s_environmentLoadGate)
        {
            if (s_environmentLoaded)
            {
                return;
            }

            foreach (var path in GetDotEnvCandidatePaths().Distinct(StringComparer.OrdinalIgnoreCase))
            {
                if (!System.IO.File.Exists(path))
                {
                    continue;
                }

                foreach (var rawLine in System.IO.File.ReadLines(path))
                {
                    var line = rawLine.Trim();
                    if (line.Length == 0 || line.StartsWith('#'))
                    {
                        continue;
                    }

                    if (line.StartsWith("export ", StringComparison.Ordinal))
                    {
                        line = line["export ".Length..].TrimStart();
                    }

                    var equalsIndex = line.IndexOf('=');
                    if (equalsIndex <= 0)
                    {
                        continue;
                    }

                    var name = line[..equalsIndex].Trim();
                    var value = line[(equalsIndex + 1)..].Trim();
                    if (name.Length == 0 || Environment.GetEnvironmentVariable(name) is { Length: > 0 })
                    {
                        continue;
                    }

                    if (value.Length >= 2 &&
                        ((value[0] == '"' && value[^1] == '"') ||
                         (value[0] == '\'' && value[^1] == '\'')))
                    {
                        value = value[1..^1];
                    }

                    Environment.SetEnvironmentVariable(name, value);
                }
            }

            s_environmentLoaded = true;
        }
    }

    private static IEnumerable<string> GetDotEnvCandidatePaths()
    {
        foreach (var path in WalkUpForDotEnv(System.IO.Directory.GetCurrentDirectory()))
        {
            yield return path;
        }

        foreach (var path in WalkUpForDotEnv(AppContext.BaseDirectory))
        {
            yield return path;
        }
    }

    private static IEnumerable<string> WalkUpForDotEnv(string startDirectory)
    {
        var directory = new System.IO.DirectoryInfo(startDirectory);
        while (directory is not null)
        {
            yield return System.IO.Path.Combine(directory.FullName, ".env");
            directory = directory.Parent;
        }
    }
}

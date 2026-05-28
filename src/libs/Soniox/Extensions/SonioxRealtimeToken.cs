#nullable enable

namespace Soniox;

/// <summary>
/// Token metadata returned by Soniox real-time transcription frames.
/// </summary>
public sealed record SonioxRealtimeToken(
    string Text,
    int? StartMs = null,
    int? EndMs = null,
    double? Confidence = null,
    string? Speaker = null,
    string? Language = null,
    bool? IsAudioEvent = null,
    string? TranslationStatus = null,
    bool IsFinal = false);

/// <summary>
/// Additional property keys used by the Soniox MEAI speech-to-text adapter.
/// </summary>
public static class SonioxSpeechToTextPropertyNames
{
    public const string Tokens = "tokens";
    public const string Speakers = "speakers";
    public const string Languages = "languages";
    public const string FinalAudioProcessedMs = "final_audio_proc_ms";
    public const string TotalAudioProcessedMs = "total_audio_proc_ms";
}

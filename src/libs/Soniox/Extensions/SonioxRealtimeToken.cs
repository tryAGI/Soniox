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
    public const string AudioFormat = "audio_format";
    public const string SampleRate = "sample_rate";
    public const string NumChannels = "num_channels";
    public const string LanguageHints = "language_hints";
    public const string LanguageHintsStrict = "language_hints_strict";
    public const string EnableSpeakerDiarization = "enable_speaker_diarization";
    public const string EnableLanguageIdentification = "enable_language_identification";
    public const string EnableEndpointDetection = "enable_endpoint_detection";
    public const string MaxEndpointDelayMs = "max_endpoint_delay_ms";
    public const string EndpointSensitivity = "endpoint_sensitivity";
    public const string EndpointLatencyAdjustmentLevel = "endpoint_latency_adjustment_level";
    public const string ClientReferenceId = "client_reference_id";
    public const string Tokens = "tokens";
    public const string Speakers = "speakers";
    public const string Languages = "languages";
    public const string FinalAudioProcessedMs = "final_audio_proc_ms";
    public const string TotalAudioProcessedMs = "total_audio_proc_ms";
}

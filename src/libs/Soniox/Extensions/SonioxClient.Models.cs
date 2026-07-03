#nullable enable

namespace Soniox;

/// <summary>
/// Well-known Soniox model identifiers.
/// </summary>
public partial class SonioxClient
{
    /// <summary>
    /// Current Soniox real-time speech-to-text model.
    /// </summary>
    public const string SttRealtimeV5ModelId = "stt-rt-v5";

    /// <summary>
    /// Current Soniox async speech-to-text model.
    /// </summary>
    public const string SttAsyncV5ModelId = "stt-async-v5";

    /// <summary>
    /// Soniox real-time speech-to-text v4 model.
    /// </summary>
    public const string SttRealtimeV4ModelId = "stt-rt-v4";

    /// <summary>
    /// Soniox async speech-to-text v4 model.
    /// </summary>
    public const string SttAsyncV4ModelId = "stt-async-v4";

    /// <summary>
    /// Soniox real-time speech-to-text v3 alias.
    /// </summary>
    public const string SttRealtimeV3AliasModelId = "stt-rt-v3";

    /// <summary>
    /// Soniox async speech-to-text v3 alias.
    /// </summary>
    public const string SttAsyncV3AliasModelId = "stt-async-v3";

    /// <summary>
    /// Default model id used for async (pre-recorded) transcription when the
    /// caller does not supply <see cref="Microsoft.Extensions.AI.SpeechToTextOptions.ModelId"/>.
    /// </summary>
    public const string DefaultAsyncModel = SttAsyncV5ModelId;

    /// <summary>
    /// Default model id used for real-time (streaming) transcription when the
    /// caller does not supply <see cref="Microsoft.Extensions.AI.SpeechToTextOptions.ModelId"/>.
    /// </summary>
    public const string DefaultRealtimeModel = SttRealtimeV5ModelId;

    /// <summary>
    /// Alias for <see cref="DefaultAsyncModel"/>.
    /// </summary>
    public const string DefaultAsyncModelId = DefaultAsyncModel;

    /// <summary>
    /// Alias for <see cref="DefaultRealtimeModel"/>.
    /// </summary>
    public const string DefaultRealtimeModelId = DefaultRealtimeModel;

    /// <summary>
    /// Current Soniox real-time text-to-speech model.
    /// </summary>
    public const string TtsRealtimeV1ModelId = "tts-rt-v1";

    /// <summary>
    /// Soniox real-time text-to-speech preview alias.
    /// </summary>
    public const string TtsRealtimeV1PreviewAliasModelId = "tts-rt-v1-preview";

    /// <summary>
    /// Default model id used for text-to-speech generation.
    /// </summary>
    public const string DefaultTtsModel = TtsRealtimeV1ModelId;

    /// <summary>
    /// Alias for <see cref="DefaultTtsModel"/>.
    /// </summary>
    public const string DefaultTtsModelId = DefaultTtsModel;
}

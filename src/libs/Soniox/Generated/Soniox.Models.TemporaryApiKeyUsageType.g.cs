
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public enum TemporaryApiKeyUsageType
    {
        /// <summary>
        /// 
        /// </summary>
        TranscribeWebsocket,
        /// <summary>
        /// 
        /// </summary>
        TtsRt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemporaryApiKeyUsageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemporaryApiKeyUsageType value)
        {
            return value switch
            {
                TemporaryApiKeyUsageType.TranscribeWebsocket => "transcribe_websocket",
                TemporaryApiKeyUsageType.TtsRt => "tts_rt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemporaryApiKeyUsageType? ToEnum(string value)
        {
            return value switch
            {
                "transcribe_websocket" => TemporaryApiKeyUsageType.TranscribeWebsocket,
                "tts_rt" => TemporaryApiKeyUsageType.TtsRt,
                _ => null,
            };
        }
    }
}
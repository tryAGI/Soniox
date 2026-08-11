
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConcurrentStreamsHistoryKind2
    {
        /// <summary>
        /// 
        /// </summary>
        Stt,
        /// <summary>
        /// 
        /// </summary>
        Tts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConcurrentStreamsHistoryKind2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConcurrentStreamsHistoryKind2 value)
        {
            return value switch
            {
                GetConcurrentStreamsHistoryKind2.Stt => "stt",
                GetConcurrentStreamsHistoryKind2.Tts => "tts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConcurrentStreamsHistoryKind2? ToEnum(string value)
        {
            return value switch
            {
                "stt" => GetConcurrentStreamsHistoryKind2.Stt,
                "tts" => GetConcurrentStreamsHistoryKind2.Tts,
                _ => null,
            };
        }
    }
}
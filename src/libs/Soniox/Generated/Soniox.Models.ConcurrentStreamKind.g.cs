
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConcurrentStreamKind
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
    public static class ConcurrentStreamKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConcurrentStreamKind value)
        {
            return value switch
            {
                ConcurrentStreamKind.Stt => "stt",
                ConcurrentStreamKind.Tts => "tts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConcurrentStreamKind? ToEnum(string value)
        {
            return value switch
            {
                "stt" => ConcurrentStreamKind.Stt,
                "tts" => ConcurrentStreamKind.Tts,
                _ => null,
            };
        }
    }
}
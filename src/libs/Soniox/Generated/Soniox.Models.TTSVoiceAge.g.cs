
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public enum TTSVoiceAge
    {
        /// <summary>
        ///
        /// </summary>
        MiddleAged,
        /// <summary>
        ///
        /// </summary>
        Old,
        /// <summary>
        ///
        /// </summary>
        Young,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSVoiceAgeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSVoiceAge value)
        {
            return value switch
            {
                TTSVoiceAge.MiddleAged => "middle_aged",
                TTSVoiceAge.Old => "old",
                TTSVoiceAge.Young => "young",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSVoiceAge? ToEnum(string value)
        {
            return value switch
            {
                "middle_aged" => TTSVoiceAge.MiddleAged,
                "old" => TTSVoiceAge.Old,
                "young" => TTSVoiceAge.Young,
                _ => null,
            };
        }
    }
}
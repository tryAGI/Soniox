
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public enum TTSVoiceGender
    {
        /// <summary>
        ///
        /// </summary>
        Female,
        /// <summary>
        ///
        /// </summary>
        Male,
        /// <summary>
        ///
        /// </summary>
        Neutral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TTSVoiceGenderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TTSVoiceGender value)
        {
            return value switch
            {
                TTSVoiceGender.Female => "female",
                TTSVoiceGender.Male => "male",
                TTSVoiceGender.Neutral => "neutral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TTSVoiceGender? ToEnum(string value)
        {
            return value switch
            {
                "female" => TTSVoiceGender.Female,
                "male" => TTSVoiceGender.Male,
                "neutral" => TTSVoiceGender.Neutral,
                _ => null,
            };
        }
    }
}
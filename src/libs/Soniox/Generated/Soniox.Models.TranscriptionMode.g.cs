
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranscriptionMode
    {
        /// <summary>
        /// 
        /// </summary>
        Async,
        /// <summary>
        /// 
        /// </summary>
        RealTime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionMode value)
        {
            return value switch
            {
                TranscriptionMode.Async => "async",
                TranscriptionMode.RealTime => "real_time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionMode? ToEnum(string value)
        {
            return value switch
            {
                "async" => TranscriptionMode.Async,
                "real_time" => TranscriptionMode.RealTime,
                _ => null,
            };
        }
    }
}
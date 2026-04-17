
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranscriptionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionStatus value)
        {
            return value switch
            {
                TranscriptionStatus.Completed => "completed",
                TranscriptionStatus.Error => "error",
                TranscriptionStatus.Processing => "processing",
                TranscriptionStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TranscriptionStatus.Completed,
                "error" => TranscriptionStatus.Error,
                "processing" => TranscriptionStatus.Processing,
                "queued" => TranscriptionStatus.Queued,
                _ => null,
            };
        }
    }
}
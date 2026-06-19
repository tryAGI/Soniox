
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        NotComputed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceModelStatus value)
        {
            return value switch
            {
                VoiceModelStatus.Failed => "failed",
                VoiceModelStatus.NotComputed => "not_computed",
                VoiceModelStatus.Processing => "processing",
                VoiceModelStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => VoiceModelStatus.Failed,
                "not_computed" => VoiceModelStatus.NotComputed,
                "processing" => VoiceModelStatus.Processing,
                "ready" => VoiceModelStatus.Ready,
                _ => null,
            };
        }
    }
}
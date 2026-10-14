
#nullable enable

namespace Soniox
{
    /// <summary>
    /// `resource:level`; write includes read.
    /// </summary>
    public enum ApiKeyPermission
    {
        /// <summary>
        ///
        /// </summary>
        Files_read,
        /// <summary>
        ///
        /// </summary>
        Files_write,
        /// <summary>
        ///
        /// </summary>
        Legacy_write,
        /// <summary>
        ///
        /// </summary>
        Models_read,
        /// <summary>
        ///
        /// </summary>
        SttAsync_read,
        /// <summary>
        ///
        /// </summary>
        SttAsync_write,
        /// <summary>
        ///
        /// </summary>
        SttRt_write,
        /// <summary>
        ///
        /// </summary>
        TemporaryKeys_write,
        /// <summary>
        ///
        /// </summary>
        TtsRt_write,
        /// <summary>
        ///
        /// </summary>
        Usage_read,
        /// <summary>
        ///
        /// </summary>
        VoiceAgent_read,
        /// <summary>
        ///
        /// </summary>
        VoiceAgent_write,
        /// <summary>
        ///
        /// </summary>
        Voices_read,
        /// <summary>
        ///
        /// </summary>
        Voices_write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiKeyPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyPermission value)
        {
            return value switch
            {
                ApiKeyPermission.Files_read => "files:read",
                ApiKeyPermission.Files_write => "files:write",
                ApiKeyPermission.Legacy_write => "legacy:write",
                ApiKeyPermission.Models_read => "models:read",
                ApiKeyPermission.SttAsync_read => "stt_async:read",
                ApiKeyPermission.SttAsync_write => "stt_async:write",
                ApiKeyPermission.SttRt_write => "stt_rt:write",
                ApiKeyPermission.TemporaryKeys_write => "temporary_keys:write",
                ApiKeyPermission.TtsRt_write => "tts_rt:write",
                ApiKeyPermission.Usage_read => "usage:read",
                ApiKeyPermission.VoiceAgent_read => "voice_agent:read",
                ApiKeyPermission.VoiceAgent_write => "voice_agent:write",
                ApiKeyPermission.Voices_read => "voices:read",
                ApiKeyPermission.Voices_write => "voices:write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyPermission? ToEnum(string value)
        {
            return value switch
            {
                "files:read" => ApiKeyPermission.Files_read,
                "files:write" => ApiKeyPermission.Files_write,
                "legacy:write" => ApiKeyPermission.Legacy_write,
                "models:read" => ApiKeyPermission.Models_read,
                "stt_async:read" => ApiKeyPermission.SttAsync_read,
                "stt_async:write" => ApiKeyPermission.SttAsync_write,
                "stt_rt:write" => ApiKeyPermission.SttRt_write,
                "temporary_keys:write" => ApiKeyPermission.TemporaryKeys_write,
                "tts_rt:write" => ApiKeyPermission.TtsRt_write,
                "usage:read" => ApiKeyPermission.Usage_read,
                "voice_agent:read" => ApiKeyPermission.VoiceAgent_read,
                "voice_agent:write" => ApiKeyPermission.VoiceAgent_write,
                "voices:read" => ApiKeyPermission.Voices_read,
                "voices:write" => ApiKeyPermission.Voices_write,
                _ => null,
            };
        }
    }
}
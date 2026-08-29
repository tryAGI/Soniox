
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Soniox.Realtime.Tts
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Soniox.Realtime.Tts.TtsConfig? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Soniox.Realtime.Tts.TtsText? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Soniox.Realtime.Tts.TtsCancel? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Soniox.Realtime.Tts.TtsKeepAlive? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Soniox.Realtime.Tts.TtsAudio? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Soniox.Realtime.Tts.TtsTimestamps? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Soniox.Realtime.Tts.TtsTerminated? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Soniox.Realtime.Tts.TtsError? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Soniox.Realtime.Tts.ServerEvent? Type14 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType1 { get; set; }
    }
}
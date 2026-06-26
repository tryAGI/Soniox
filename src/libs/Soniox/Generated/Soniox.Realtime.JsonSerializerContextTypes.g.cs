
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Soniox.Realtime
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
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Soniox.Realtime.RealtimeConfig? Type0 { get; set; }
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
        public global::System.Collections.Generic.IList<string>? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Soniox.Realtime.OneOf<string, object>? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Soniox.Realtime.TranslationConfig? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Soniox.Realtime.RealtimeToken? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Soniox.Realtime.RealtimeResult? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Soniox.Realtime.RealtimeToken>? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Soniox.Realtime.RealtimeError? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Soniox.Realtime.ServerEvent? Type13 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Soniox.Realtime.RealtimeToken>? ListType1 { get; set; }
    }
}
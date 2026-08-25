
#nullable enable

namespace Soniox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeError" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeError(
            int errorCode,
            string errorMessage)
        {
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage ?? throw new global::System.ArgumentNullException(nameof(errorMessage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeError" /> class.
        /// </summary>
        public RealtimeError()
        {
        }

    }
}
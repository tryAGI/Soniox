
#nullable enable

namespace Soniox.Realtime.Tts
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsError
    {
        /// <summary>
        /// Stream identifier for stream-scoped errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_id")]
        public string? StreamId { get; set; }

        /// <summary>
        /// HTTP-style status code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ErrorCode { get; set; }

        /// <summary>
        /// Stable machine-readable error category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorType { get; set; }

        /// <summary>
        /// Human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorMessage { get; set; }

        /// <summary>
        /// Optional documentation URL with additional information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("more_info")]
        public string? MoreInfo { get; set; }

        /// <summary>
        /// Request id to provide to Soniox support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsError" /> class.
        /// </summary>
        /// <param name="errorCode">
        /// HTTP-style status code.
        /// </param>
        /// <param name="errorType">
        /// Stable machine-readable error category.
        /// </param>
        /// <param name="errorMessage">
        /// Human-readable error message.
        /// </param>
        /// <param name="streamId">
        /// Stream identifier for stream-scoped errors.
        /// </param>
        /// <param name="moreInfo">
        /// Optional documentation URL with additional information.
        /// </param>
        /// <param name="requestId">
        /// Request id to provide to Soniox support.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsError(
            int errorCode,
            string errorType,
            string errorMessage,
            string? streamId,
            string? moreInfo,
            string? requestId)
        {
            this.StreamId = streamId;
            this.ErrorCode = errorCode;
            this.ErrorType = errorType ?? throw new global::System.ArgumentNullException(nameof(errorType));
            this.ErrorMessage = errorMessage ?? throw new global::System.ArgumentNullException(nameof(errorMessage));
            this.MoreInfo = moreInfo;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsError" /> class.
        /// </summary>
        public TtsError()
        {
        }

    }
}
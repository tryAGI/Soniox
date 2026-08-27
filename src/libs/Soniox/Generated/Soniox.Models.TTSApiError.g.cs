
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TTSApiError
    {
        /// <summary>
        /// HTTP status code for the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ErrorCode { get; set; }

        /// <summary>
        /// Machine-readable error category. Branch your client on this value, not on `error_message`.<br/>
        /// See the [Errors reference](https://soniox.com/docs/api-reference/errors) for the full catalog.<br/>
        /// Examples: `invalid_request`, `unauthenticated`, `limit_exceeded`, `service_unavailable`, `internal_error`.
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
        /// Optional URL pointing to the section on the Soniox docs error reference page that<br/>
        /// describes this `error_type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("more_info")]
        public string? MoreInfo { get; set; }

        /// <summary>
        /// Unique identifier for this request. Include it when contacting support at<br/>
        /// support@soniox.com so we can look up server-side logs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSApiError" /> class.
        /// </summary>
        /// <param name="errorCode">
        /// HTTP status code for the error.
        /// </param>
        /// <param name="errorType">
        /// Machine-readable error category. Branch your client on this value, not on `error_message`.<br/>
        /// See the [Errors reference](https://soniox.com/docs/api-reference/errors) for the full catalog.<br/>
        /// Examples: `invalid_request`, `unauthenticated`, `limit_exceeded`, `service_unavailable`, `internal_error`.
        /// </param>
        /// <param name="errorMessage">
        /// Human-readable error message.
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for this request. Include it when contacting support at<br/>
        /// support@soniox.com so we can look up server-side logs.
        /// </param>
        /// <param name="moreInfo">
        /// Optional URL pointing to the section on the Soniox docs error reference page that<br/>
        /// describes this `error_type`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSApiError(
            int errorCode,
            string errorType,
            string errorMessage,
            string requestId,
            string? moreInfo)
        {
            this.ErrorCode = errorCode;
            this.ErrorType = errorType ?? throw new global::System.ArgumentNullException(nameof(errorType));
            this.ErrorMessage = errorMessage ?? throw new global::System.ArgumentNullException(nameof(errorMessage));
            this.MoreInfo = moreInfo;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSApiError" /> class.
        /// </summary>
        public TTSApiError()
        {
        }

    }
}
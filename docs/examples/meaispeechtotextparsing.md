# MeaiSpeechToTextParsing



This example assumes `using Soniox;` is in scope and `apiKey` contains your Soniox API key.

```csharp
var update = SonioxClient.ParseServerFrame(
    """
    {
      "tokens": [
        {
          "text": "привет",
          "start_ms": 10,
          "end_ms": 320,
          "confidence": 0.97,
          "speaker": "speaker_0",
          "language": "ru",
          "is_final": true
        }
      ],
      "final_audio_proc_ms": 320,
      "total_audio_proc_ms": 400,
      "finished": false
    }
    """,
    responseId: "response",
    out var finished);

var tokens = update.AdditionalProperties![SonioxSpeechToTextPropertyNames.Tokens]
    .Which;

update.AdditionalProperties[SonioxSpeechToTextPropertyNames.Speakers]
```
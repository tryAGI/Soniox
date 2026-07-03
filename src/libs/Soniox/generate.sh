#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors --retry-max-time 90 \
    --connect-timeout 15 --max-time 60
}

# Soniox Public API — official OpenAPI 3.1.0 spec.
#   Source: https://soniox.com/docs/openapi.yaml
#
# Covers: Auth (temporary API keys), Files (upload/list/get/delete),
# Models (list), Transcriptions (async create/get/list/delete, fetch
# transcript), TTS models, REST Text-to-Speech generation, and voice
# cloning management. Real-time WebSocket streaming is generated from the
# handcrafted AsyncAPI specs in asyncapi.yaml and tts.asyncapi.yaml because
# it is not part of the REST OpenAPI surface.
#
# Auth: standard HTTP Bearer (Authorization: Bearer <API_KEY>).
install_autosdk_cli

spec_url="https://soniox.com/docs/openapi.yaml"
spec_path="openapi.yaml"
spec_download_path="${spec_path}.tmp"

rm -f "$spec_download_path"
if fetch_spec "$spec_url" -o "$spec_download_path"; then
  mv "$spec_download_path" "$spec_path"
else
  rm -f "$spec_download_path"
  if [ -f "$spec_path" ]; then
    echo "Warning: failed to fetch latest Soniox OpenAPI spec; using checked-in ${spec_path}." >&2
  else
    echo "Error: failed to fetch latest Soniox OpenAPI spec and no ${spec_path} fallback exists." >&2
    exit 1
  fi
fi

rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Soniox \
  --clientClassName SonioxClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

autosdk generate asyncapi.yaml \
  --namespace Soniox.Realtime \
  --websocket-class-name SonioxRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated

autosdk generate tts.asyncapi.yaml \
  --namespace Soniox.Realtime.Tts \
  --websocket-class-name SonioxTtsRealtimeClient \
  --json-serializer-context TtsRealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated

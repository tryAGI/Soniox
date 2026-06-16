#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# Soniox Public API — official OpenAPI 3.1.0 spec.
#   Source: https://api.soniox.com/v1/openapi.json
#
# Covers: Auth (temporary API keys), Files (upload/list/get/delete),
# Models (list), Transcriptions (async create/get/list/delete, fetch
# transcript). Real-time WebSocket streaming is handled manually in
# Extensions/ (not part of the REST OpenAPI surface).
#
# Auth: standard HTTP Bearer (Authorization: Bearer <API_KEY>).
install_autosdk_cli

rm -rf Generated
fetch_spec --fail --silent --show-error --location https://api.soniox.com/v1/openapi.json -o openapi.json

autosdk generate openapi.json \
  --namespace Soniox \
  --clientClassName SonioxClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

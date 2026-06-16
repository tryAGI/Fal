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

# OpenAPI spec: https://api.fal.ai/v1/openapi.json
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error --location https://api.fal.ai/v1/openapi.json -o openapi.json

# Auth: --security-scheme overrides the spec's apiKey/adminApiKey auth with HTTP bearer.
# Fal uses 'Authorization: Key <api_key>' — FalClient.Authorization.cs rewrites Bearer → Key.
autosdk generate openapi.json \
  --namespace Fal \
  --clientClassName FalClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
